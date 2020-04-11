using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectorySolutions.Models;
using DirectorySolutions.Presenters;

namespace DirectorySolutions.UserControls
{
    public partial class MovieManagement : UserControl
    {
        private MainModel mainModel;
        private MainPresenter presenter = null;

        public MovieManagement(MainModel model, MainPresenter presenter)
        {
            mainModel = model;
            this.presenter = presenter;            
            InitializeComponent();
            GenerateToolTips();
            freshSearchCheck.Checked = true;
        }

        private void GenerateToolTips()
        {
            createInfoFilesTooltip.SetToolTip(btnCreateInfoFiles, "This will create a text file with movie information in the directory of each movie. " +
                "Used for searching and filtering.");
        }

        private async void btnCreateInfoFiles_Click(object sender, EventArgs e)
        {
            var filesGenerated = await presenter.GenerateInformationFilesForMovies();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string error;
            MovieSearch movieSearchOptions;
            if(ValidateMovieSearchInputs(out movieSearchOptions, out error))
            {
                if (movieSearchOptions.FreshSearch)
                {
                    if(!presenter.ParseMovieInfoFilesInPath(out error, mainModel.GetSortedBy(false), raiseEvent: false))
                    {
                        MessageBox.Show(error);
                    }
                    if(!presenter.FilterMovieListBySearchOptions(movieSearchOptions, out error))
                    {
                        MessageBox.Show(error);
                    }
                   
                }
                else
                {
                    if (!presenter.FilterMovieListBySearchOptions(movieSearchOptions, out error))
                    {
                        MessageBox.Show(error);
                    }
                }
            }
        }

        private bool ValidateMovieSearchInputs( out MovieSearch movieSearchOptions, out string error)
        {
            movieSearchOptions = null;
            error = "";

            try
            {
                var title = titleSearchTxt.Text;
                var genre = genreTxt.Text;

                int yearStart;
                if (string.IsNullOrEmpty(yearStartTxt.Text))
                {
                    yearStart = 0;
                }
                else if (!int.TryParse(yearStartTxt.Text, out yearStart))
                {
                    error = "The starting Year is not a number.";
                    return false;
                }

                int yearEnd;
                if (string.IsNullOrEmpty(yearEndTxt.Text))
                {
                    yearEnd = DateTime.Now.Year;
                }
                else if (!int.TryParse(yearEndTxt.Text, out yearEnd))
                {
                    error = "The ending Year is not a number.";
                    return false;
                }

                int IMDbRatingStart;
                if(string.IsNullOrEmpty(imdbRatingStartTxt.Text))
                {
                    IMDbRatingStart = 0;
                }
                else if(!int.TryParse(imdbRatingStartTxt.Text, out IMDbRatingStart))
                {
                    error = "The starting IMDb rating is not a number.";
                    return false;
                }

                int IMDbRatingEnd;
                if (string.IsNullOrEmpty(imdbRatingEndTxt.Text))
                {
                    IMDbRatingEnd = 10;
                }
                else if (!int.TryParse(imdbRatingEndTxt.Text, out IMDbRatingEnd))
                {
                    error = "The ending IMDb rating is not a number.";
                    return false;
                }

                int runtimeStart;
                if (string.IsNullOrEmpty(runtimeStartTxt.Text))
                {
                    runtimeStart = 0;
                }
                else if(!int.TryParse(runtimeStartTxt.Text, out runtimeStart))
                {
                    error = "The starting runtime is not a number.";
                    return false;
                }

                int runtimeEnd;
                if (string.IsNullOrEmpty(runtimeEndTxt.Text))
                {
                    runtimeEnd = 2000;
                }
                else if (!int.TryParse(runtimeEndTxt.Text, out runtimeEnd))
                {
                    error = "The ending runtime is not a number.";
                    return false;
                }

                var topBilled = topBilledTxt.Text;

                movieSearchOptions = new MovieSearch()
                {
                    Title = title,
                    Genre = genre,
                    YearStart = yearStart,
                    YearEnd = yearEnd,
                    IMDbRatingStart = IMDbRatingStart,
                    IMDbRatingEnd = IMDbRatingEnd,
                    RuntimeStart = runtimeStart,
                    RuntimeEnd = runtimeEnd,
                    TopBilled = topBilled,
                    FreshSearch = freshSearchCheck.Checked,
                    RequireAllGenres = requireGenresCheck.Checked
                };

                return true;
            }
            catch(Exception e)
            {
                error = e.Message;
                return false;
            }
           
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            presenter.ClearAllTextFields(this.Controls);
        }

    }
}
