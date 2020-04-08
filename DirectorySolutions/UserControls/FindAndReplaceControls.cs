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
    }
}
