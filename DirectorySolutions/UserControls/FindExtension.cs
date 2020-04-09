using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySolutions
{
    public partial class FindExtension : UserControl
    {
        public FindExtension()
        {
            InitializeComponent();
        }

        private void brnFileExtSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(findExtTxt.Text))
            {
                findExtTxt.Focus();
                findExtErrorProv.SetError(findExtTxt, "Extension cannot be blank.");
            }
            else
            {
                findExtErrorProv.Clear();
            }
        }
    }
}
