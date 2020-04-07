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

namespace DirectorySolutions
{
    public partial class FindAndReplaceControls : UserControl
    {
        public event EventHandler FindReplaceClicked;
        private string inText;
        private string outText;
        private Form mainForm;

        public FindAndReplaceControls()
        {
            InitializeComponent();
            mainForm = (Parent as Form);
        }

        private void FindAndReplaceControls_Load(object sender, EventArgs e)
        {

        }

        public bool SetAndValidateReplacementTexts()
        {
            var tempInText = inTxt.Text;
            var tempOutText = outTxt.Text;
            if (!string.IsNullOrEmpty(tempInText) && !string.IsNullOrEmpty(tempOutText) && !string.Equals(tempInText, tempOutText))
            {
                inText = tempInText;
                outText = tempOutText;
                inTxtErrorProv.Clear();
                outTxtErrorProv.Clear();
                return true;
            }
            else
            {
                if(!string.IsNullOrEmpty(tempInText) && string.Equals(tempInText, tempOutText))
                {
                    inTxtErrorProv.SetError(inTxt, "Texts cannot be the same.");
                    outTxtErrorProv.SetError(outTxt, "Texts cannot be the same.");
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(tempInText))
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
        
        protected virtual void OnBtnFindReplaceClicked(EventArgs e)
        {
            var handler = FindReplaceClicked;
            if (handler != null)
                handler(this, e);
        }

        private void btnFindReplace_Click(object sender, EventArgs e)
        {
            OnBtnFindReplaceClicked(e);
        }

        public string getInText()
        {
            return inText;
        }
        
        public string getOutText()
        {
            return outText;
        }

        private void btnPreAppend_Click(object sender, EventArgs e)
        {
            var path = mainForm.Controls.Find("filePath", true)[0].Text;
            if (Directory.Exists(path) && FileOperations.getFiles() != null)
            {

            }
        }
    }
}
