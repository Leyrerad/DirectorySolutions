using DirectorySolutions.Models;
using DirectorySolutions.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public partial class FileDetails : Form
    {
        private FileInfo file;
        private Movie movie;
        private MainModel mainModel;
        private MainPresenter presenter;

        public FileDetails(FileInfo file, MainModel mainModel, MainPresenter presenter, Movie movie = null)
        {
            InitializeComponent();
            this.file = file;
            this.movie = movie;
            this.mainModel = mainModel;
            this.presenter = presenter;
            PopulateFields();
        }

        private void PopulateFields()
        {
            var viewOption = mainModel.GetGridViewOption();
            System.Reflection.PropertyInfo[] fileProperties;

            if (viewOption == GridViewOptionEnum.Files)
            {
                fileProperties = mainModel.GetFiles()[0].GetType().GetProperties();
            }
            else if(viewOption == GridViewOptionEnum.Directories)
            {
                // REPLACE IF ADDING DIRECTORIES
                fileProperties = mainModel.GetFiles()[0].GetType().GetProperties();
            }
            else
            {
                fileProperties = mainModel.GetMovieList()[0].GetType().GetProperties();
            }
            
     
            foreach(var prop in fileProperties)
            {
                allFieldsLayout.Controls.Add(new FlowLayoutPanel() { Name = prop.Name + "FlowLayout", Size = new Size(830, 42)});
                var controls = Controls.Find(prop.Name + "FlowLayout", true);
                if (controls.Length > 0)
                {
                    var layout = controls[0];
                    var lbl = new Label() { Text = prop.Name + ":", Name= prop.Name + "Lbl" };
                    lbl.Padding =  new Padding(0,5,0,0);
                    layout.Controls.Add(lbl);

                    // REPLACE IF ADDING DIRECTORIES
                    layout.Controls.Add(new TextBox() { Text = viewOption == GridViewOptionEnum.Files ? prop.GetValue(file, null).ToString()
                        : prop.GetValue(movie, null).ToString(), Size = new Size(700, 20), ReadOnly = true});
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process fileopener = new Process();
            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = "\"" + file.FullName + "\"";
            fileopener.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string error;
            //if(!presenter.EditFileName(file.Name, fileNameTxt.Text, file.DirectoryName, out error))
            //{
            //    MessageBox.Show(error, "Error");
            //}
            //else
            //{
            //    file = new FileInfo(Path.Combine(file.DirectoryName, fileNameTxt.Text));
            //    PopulateFields();
            //}
        }
    }
}
