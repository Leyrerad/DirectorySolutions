using DirectorySolutions.Models;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DirectorySolutions
{
    static class ApiManager
    {
        private const string OMDBKey = "&apikey=1635e42e";
        private const string OMDBUrl = "http://www.omdbapi.com/?t=";
        private static HttpClient client = new HttpClient();
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static async Task<bool> CreateMovieInfoFiles(List<FileInfo> files)
        {
            try
            {
                foreach(var file in files)
                {
                    if(file.Length < 400000000 || Directory.GetFiles(file.DirectoryName).Contains(Path.Combine(file.DirectoryName, "MovieInfo.txt")))
                    {
                        continue;
                    }

                    var cleanFileName = file.Name.Replace("1080p", "").Replace("720p", "").Trim();
                    var requestUrl = OMDBUrl + HttpUtility.UrlEncode(Path.GetFileNameWithoutExtension(cleanFileName)).Trim() + OMDBKey;
                    HttpResponseMessage response = await client.GetAsync(requestUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();                      
                        var movie = JsonConvert.DeserializeObject<Movie>(responseString);                       
                        if (string.Equals(movie.Response, "True"))
                        {
                            movie.FileSize = file.Length;
                            using (var sw = new StreamWriter(Path.Combine(file.DirectoryName, "MovieInfo.txt"), true))
                            {
                                sw.WriteLine(JsonConvert.SerializeObject(movie));
                            }
                        }
                        else
                        {
                            using (var sw = new StreamWriter(@"C:\Logging\UnfoundMovies.txt", true))
                            {
                                sw.WriteLine(file.FullName);
                            }
                        }
                    }       
                }
                return true;
            }
            catch(Exception e)
            {
                logger.Fatal(e);
                return false;
            }
        }

        public static List<Movie> ParseMovieInfoFiles(List<FileInfo> files, out string error)
        {
            try
            {
                files = files.Where(x => x.Length > 400000000).ToList();
                error = "";
                List<Movie> movies = new List<Movie>();
                foreach(var file in files)
                {
                    if(Directory.GetFiles(file.DirectoryName).Contains(Path.Combine(file.DirectoryName, "MovieInfo.txt")))
                    {
                        var movie = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(Path.Combine(file.DirectoryName, "MovieInfo.txt")));
                        movies.Add(movie);
                    }
                }

                return movies;
            }
            catch(Exception e)
            {
                logger.Fatal(e);
                error = e.Message;
                return null;
            }
        }

        public static List<Movie> FilterMovieListBySearchOptions(List<Movie> movies, MovieSearch movieSearchOptions, out string error)
        {
            error = null;
            var filteredMovies = new List<Movie>();

            try
            {
                foreach(var movie in movies)
                {
                    var mTitle = movie.Title.ToLower().Trim();
                    var sTitle = movieSearchOptions.Title.ToLower().Trim();
                    var mYear = Convert.ToInt32(movie.Year);
                    var mRuntime = Convert.ToInt32(movie.Runtime.ToLower().Replace(" min", ""));
                    var mImdb = Convert.ToDouble(movie.imdbRating);
                    var mActors = movie.Actors.ToLower().Trim();
                    var mGenres = movie.Genre.ToLower().Trim();
                    var sActors = movieSearchOptions.TopBilled.ToLower().Split(',').ToList();
                    var sGenres = movieSearchOptions.Genre.ToLower().Split(',').ToList();                  

                    if (!SearchStringFound(sTitle, mTitle)){ continue; }

                    foreach(var sActor in sActors)
                    {
                        if (!SearchStringFound(sActor.Trim(), mActors)) { continue; }
                    }

                    foreach (var sGenre in sGenres)
                    {
                        if (!SearchStringFound(sGenre.Trim(), mGenres)) { continue; }
                    }

                    if (mYear < movieSearchOptions.YearStart || mYear > movieSearchOptions.YearEnd ||
                        mRuntime < movieSearchOptions.RuntimeStart || mRuntime > movieSearchOptions.RuntimeEnd ||
                        mImdb < movieSearchOptions.IMDbRatingStart || mImdb > movieSearchOptions.IMDbRatingEnd)
                    {
                        continue;
                    }

                    filteredMovies.Add(movie);
                }  

                return filteredMovies;
            }
            catch(Exception e)
            {
                error = e.Message;
                logger.Fatal(e);
                return null;       
            }
        }

        public static bool SearchStringFound(string searchString, string movieString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                if (!string.Equals(movieString, searchString) && !movieString.Contains(searchString) && !movieString.StartsWith(searchString) && 
                    !movieString.EndsWith(searchString))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
