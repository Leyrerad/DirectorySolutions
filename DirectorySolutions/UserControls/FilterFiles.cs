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
    public partial class FilterFiles : UserControl
    {
        private MainModel mainModel;
        private MainPresenter presenter = null;

        public FilterFiles(MainModel model, MainPresenter presenter)
        {
            InitializeComponent();
            mainModel = model;
            sizeOptionCombo.SelectedIndex = 1;
            freshSearchCheck.Checked = true;
            this.presenter = presenter;
            modifiedStartTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            modifiedEndTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string error;
            FileSearch fileSearchOptions;
            if (ValidateFileSearchInputs(out fileSearchOptions, out error))
            {
                if (fileSearchOptions.FreshSearch)
                {
                    if (!presenter.FindAllFilesInTheDirectory(mainModel.GetAllFilePaths(), out error, mainModel.GetSortedBy(false), raiseEvent: false))
                    {
                        MessageBox.Show(error);
                    }
                    if (!presenter.FilterFileListBySearchOptions(fileSearchOptions, out error))
                    {
                        MessageBox.Show(error);
                    }

                }
                else
                {
                    if (!presenter.FilterFileListBySearchOptions(fileSearchOptions, out error))
                    {
                        MessageBox.Show(error);
                    }
                }
            }
        }

        private bool ValidateFileSearchInputs(out FileSearch FileSearchOptions, out string error)
        {
            FileSearchOptions = null;
            error = "";

            try
            {
                var fileName = fileNameTxt.Text;
                var path = pathTxt.Text;
                var extensions = extensionsText.Text;

                DateTime dateStart;
                if (string.IsNullOrEmpty(modifiedStartTime.Text))
                {
                    dateStart = DateTime.MinValue;
                }
                else if (!DateTime.TryParse(modifiedStartTime.Text, out dateStart))
                {
                    error = "The starting date modified is not a date.";
                    return false;
                }

                DateTime dateEnd;
                if (string.IsNullOrEmpty(modifiedEndTime.Text))
                {
                    dateEnd = DateTime.Now;
                }
                else if (!DateTime.TryParse(modifiedEndTime.Text, out dateEnd))
                {
                    error = "The ending date modified is not a date.";
                    return false;
                }

                double sizeStart;
                if (string.IsNullOrEmpty(sizeStartTxt.Text))
                {
                    sizeStart = 0;
                }
                else if (!double.TryParse(sizeStartTxt.Text, out sizeStart))
                {
                    error = "The starting size is not a number.";
                    return false;
                }

                double sizeEnd;
                if (string.IsNullOrEmpty(sizeEndTxt.Text))
                {
                    sizeEnd = 100000000000000;
                }
                else if (!double.TryParse(sizeEndTxt.Text, out sizeEnd))
                {
                    error = "The ending size is not a number.";
                    return false;
                }

                FileSearchOptions = new FileSearch()
                {
                    FileName = fileName,
                    DateModifiedStart = dateStart,
                    DateModifiedEnd = dateEnd,
                    Extensions = extensions,
                    FileSizeStart = Math.Floor(ConvertFileSizeUnitToBytes(sizeStart)),
                    FileSizeEnd = Math.Ceiling(ConvertFileSizeUnitToBytes(sizeEnd)),
                    Path = path,
                    FreshSearch = freshSearchCheck.Checked
                };

                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }

        }

        private double ConvertFileSizeUnitToBytes(double size)
        {
            switch (sizeOptionCombo.SelectedIndex)
            {
                case 0:
                    return size;
                case 1:
                    return size * 1000;
                case 2:
                    return size * 1000000;
                case 3:
                    return size * 1000000000;
                default:
                    return size;
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            presenter.ClearAllTextFields(Controls);
            modifiedStartTime.Value = new DateTime(1970, 1, 1, 0, 0, 0);
            modifiedEndTime.Value = DateTime.Now;
        }
    }
}
