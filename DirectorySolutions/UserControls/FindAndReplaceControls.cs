using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DirectorySolutions.Models;
using DirectorySolutions.Presenters;

namespace DirectorySolutions
{
    public partial class FindAndReplaceControls : UserControl
    {
        private MainModel mainModel;
        private MainPresenter presenter = null;

        public FindAndReplaceControls(MainModel model, MainPresenter presenter)
        {
            InitializeComponent();
            mainModel = model;
            this.presenter = presenter;
            freshSearchCheck.Checked = true;
            sizeOptionCombo.SelectedIndex = 1;
            operationOptionCombo.SelectedIndex = 0;
            modifiedStartTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            modifiedEndTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            SetToolTips();
        }
        
        private bool ValidateFindAndReplaceInputs()
        {
            var inText = inTxt.Text;
            var outText = outTxt.Text;
            if (!string.IsNullOrEmpty(inText) && !string.Equals(inText, outText))
            {
                inTxtErrorProv.Clear();
                outTxtErrorProv.Clear();
                return true;
            }
            else
            {
                if(!string.IsNullOrEmpty(inText) && string.Equals(inText, outText))
                {
                    inTxtErrorProv.SetError(inTxt, "Texts cannot be the same.");
                    outTxtErrorProv.SetError(outTxt, "Texts cannot be the same.");
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(inText))
                    {
                        inTxt.Focus();
                        inTxtErrorProv.SetError(inTxt, "Text cannot be blank.");
                    }
                    else
                    {
                        inTxtErrorProv.Clear();
                    }

                    return false;
                }
            }
        }

        private bool ValidateAppendInputs()
        {
            var prependText = prependTxt.Text;
            var appendText = appendTxt.Text;
            if (!string.IsNullOrEmpty(prependText) || !string.IsNullOrEmpty(appendText))
            {
                prependErrorProv.Clear();
                appendErrorProv.Clear();
                return true;
            }
            else
            {
                if (string.IsNullOrEmpty(prependText) && string.IsNullOrEmpty(appendText))
                {
                    prependErrorProv.SetError(prependTxt, "Text cannot be blank.");
                    appendErrorProv.SetError(appendTxt, "Text cannot be blank.");
                }
                else
                {
                    prependErrorProv.Clear();
                    appendErrorProv.Clear();
                }
                return false;
            }
        }
      
        private void SetToolTips()
        {
            replaceAllTooltip.SetToolTip(btnFindReplace, "This will replace all of the text in the left box with all the text in the right box for all file names " +
                "in this directory.");
        }

        private void btnFindReplace_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to replace all file names in this root directory?","Confirm Replacement", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (ValidateFindAndReplaceInputs())
                {
                    string error;
                    if (!presenter.FindAndReplace(inTxt.Text, outTxt.Text, out error))
                    {
                        replaceAllErrorProv.SetError(btnFindReplace, error);
                    }
                    else
                    {
                        replaceAllErrorProv.Clear();
                    }
                }
            }
              
        }

        private void btnPreAppend_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to replace all file names in this root directory?", "Confirm Replacement", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (ValidateAppendInputs())
                {
                    string error;
                    if (!presenter.PreAndAppend(prependTxt.Text, appendTxt.Text, out error))
                    {
                       PreAppendErrorProv.SetError(btnPreAppend, error);
                    }
                    else
                    {
                        PreAppendErrorProv.Clear();
                    }
                }
            }
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your directory path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    movePathTxt.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            string error;
            if(!presenter.MoveFiles(out error, movePathTxt.Text))
            {
                movePathTxtErrorProv.SetError(movePathTxt, error);
            }
            else
            {
                movePathTxtErrorProv.Clear();
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

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            presenter.ClearAllTextFields(Controls);
            modifiedStartTime.Value = new DateTime(1970, 1, 1, 0, 0, 0);
            modifiedEndTime.Value = DateTime.Now;
        }

    }
}
