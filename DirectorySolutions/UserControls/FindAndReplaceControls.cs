using System;
using System.Drawing;
using System.Windows.Forms;
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
            operationOptionCombo.SelectedIndex = 0;
            this.Paint += FindAndReplaceControls_Paint;
        }

        private void FindAndReplaceControls_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.FromKnownColor(KnownColor.ControlDarkDark));
            //e.Graphics.DrawLine(pen, 235, 105, 1225, 105);
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

        private void btnFindReplace_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to replace '" + inTxt.Text + "' with '" + outTxt.Text + "' for all " 
                + operationOptionCombo.SelectedItem.ToString() +  " names in this root directory?", "Confirm Replacement", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (ValidateFindAndReplaceInputs())
                {
                    string error;
                    if (!presenter.FindAndReplace(inTxt.Text, outTxt.Text, out error, operationOptionCombo.SelectedIndex))
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
            var confirmResult = MessageBox.Show("Are you sure to prepend '" + prependTxt.Text + "' and append '" 
                + appendTxt.Text + "' for all " + operationOptionCombo.SelectedItem.ToString() + " names in this root directory?", 
                "Confirm Replacement", MessageBoxButtons.YesNo);

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
       
        private void operationOptionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(operationOptionCombo.SelectedIndex == 3 && Controls.Find("warningLable", true).Length < 1)
            {
                var warningLabel = new Label() { Text = "NOTE: File content operations can currently only be completed " +
                    "on text type docutments such as .txt or .doc.", ForeColor = Color.FromKnownColor(KnownColor.Red), Name = "warningLabel"};
                warningLabel.AutoSize = true;
                Controls.Add(warningLabel);
                warningLabel.Location = new Point(prependTxt.Location.X, 
                    prependTxt.Location.Y + prependTxt.Height + 5);
            }
            else
            {
                var controls = Controls.Find("warningLabel", true);
                if(controls.Length > 0)
                {
                    var warningLabel = Controls.Find("warningLabel", true)[0];
                    Controls.Remove(warningLabel);
                }
            }
        }
    }
}
