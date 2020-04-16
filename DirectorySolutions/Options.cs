using DirectorySolutions.Models;
using DirectorySolutions.Presenters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public partial class Options : Form
    {
        private MainPresenter presenter = null;
        private MainModel mainModel;
        private System.Reflection.PropertyInfo[] fileProperties;
        private System.Reflection.PropertyInfo[] movieProperties;
        private Dictionary<string, bool> fileColumns;
        private Dictionary<string, bool> movieColumns;
        private List<string> fastPaths;

        public Options(MainModel model, MainPresenter presenter)
        {
            InitializeComponent();
            mainModel = model;
            this.presenter = presenter;
            defaultPathTxt.Text = Properties.Settings.Default["Path"].ToString();
            fileProperties = mainModel.GetFiles()[0].GetType().GetProperties();
            fileColumns = JsonConvert.DeserializeObject<Dictionary<string,bool>>(Properties.Settings.Default.FileColumns);
            movieColumns = JsonConvert.DeserializeObject<Dictionary<string, bool>>(Properties.Settings.Default.MovieColumns);
            fastPaths = JsonConvert.DeserializeObject<List<string>>(Properties.Settings.Default.FastPaths);
            movieProperties = new Movie().GetType().GetProperties();
            omdbApiTxt.Text = Properties.Settings.Default.OMDBKEY;
            FillDisplayOptions();
            BuildFastPathContextMenuItems();
           
        }

        private void BuildFastPathContextMenuItems()
        {           
            string error;
            if (!presenter.PopulateFastPathContextMenu(fastPathMenuStrip, out error, ref fastPaths))
            {
                MessageBox.Show(error, "Error");
            }
        }

        private void FillDisplayOptions()
        {
            foreach(var property in fileProperties)
            {
                displayGridOptionsFiles.Controls.Add(new CheckBox() { Name = property.Name + "Check", Text = property.Name, 
                    Checked = fileColumns == null ? true : fileColumns[property.Name]});
            }

            foreach (var property in movieProperties)
            {
                displayGridOptionsMovies.Controls.Add(new CheckBox() { Name = property.Name + "Check", Text = property.Name, 
                    Checked = movieColumns == null ? true : movieColumns[property.Name]});
            }

            if(fileColumns == null)
            {
                fileColumns = new Dictionary<string, bool>();
            }

            if(movieColumns == null)
            {
                movieColumns = new Dictionary<string, bool>();
            }
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your directory path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    defaultPathTxt.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(defaultPathTxt.Text))
                {
                    if (Directory.Exists(defaultPathTxt.Text))
                    {
                        Properties.Settings.Default["Path"] = defaultPathTxt.Text;
                    }
                    else
                    {
                        MessageBox.Show("Could not find the directory: " + defaultPathTxt.Text, "Path not found");
                    }
                }
              

                foreach (var prop in fileProperties)
                {
                    CheckBox control = (CheckBox)displayGridOptionsFiles.Controls.Find(prop.Name + "Check", true)[0];
                    if (fileColumns != null && fileColumns.ContainsKey(prop.Name))
                    {
                        fileColumns[prop.Name] = control.Checked;
                    }
                    else
                    {
                        fileColumns.Add(prop.Name, control.Checked);
                    }                    
                }

                foreach (var prop in movieProperties)
                {
                    CheckBox control = (CheckBox)displayGridOptionsMovies.Controls.Find(prop.Name + "Check", true)[0];
                    if (movieColumns != null && movieColumns.ContainsKey(prop.Name))
                    {
                        movieColumns[prop.Name] = control.Checked;
                    }
                    else
                    {
                        movieColumns.Add(prop.Name, control.Checked);
                    }
                }

                Properties.Settings.Default["FileColumns"] = JsonConvert.SerializeObject(fileColumns);
                Properties.Settings.Default["MovieColumns"] = JsonConvert.SerializeObject(movieColumns);
                


                Properties.Settings.Default.Save();
                mainModel.RaiseFileListChangedEvent(mainModel.GetFiles());
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your directory path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    fastPathTxt.Text = fbd.SelectedPath;
                }
            }
        }

        private void omdbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.omdbapi.com/apikey.aspx");
        }

        private void btnOmdbApiEdit_Click(object sender, EventArgs e)
        {
            omdbApiTxt.ReadOnly = false;
        }

        private void btnOmdbApiSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(omdbApiTxt.Text))
            {
                Properties.Settings.Default["OMDBKEY"] = omdbApiTxt.Text;
                omdbApiTxt.ReadOnly = true;
                Properties.Settings.Default.Save();
            }
        }

        private void btnSaveFastPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fastPathTxt.Text))
            {
                if (Directory.Exists(fastPathTxt.Text) && !fastPaths.Contains(fastPathTxt.Text))
                {
                    fastPaths.Add(fastPathTxt.Text);
                    Properties.Settings.Default["FastPaths"] = JsonConvert.SerializeObject(fastPaths);
                    Properties.Settings.Default.Save();
                    BuildFastPathContextMenuItems();
                    fastPathTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Could not find the directory: " + defaultPathTxt.Text, "Path not found");
                }
            }
        }

        private void btnRemoveFastPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fastPathTxt.Text))
            {
                if (Directory.Exists(fastPathTxt.Text) && fastPaths.Contains(fastPathTxt.Text))
                {
                    fastPaths.Remove(fastPathTxt.Text);
                    Properties.Settings.Default["FastPaths"] = JsonConvert.SerializeObject(fastPaths);
                    Properties.Settings.Default.Save();
                    BuildFastPathContextMenuItems();
                    fastPathTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Could not find the directory: " + defaultPathTxt.Text, "Path not found");
                }
            }
        }
    }
}
