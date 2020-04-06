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
    public partial class FindAndReplaceControls : UserControl
    {
        public event EventHandler FindReplaceClicked;

        public FindAndReplaceControls()
        {
            InitializeComponent();
        }

        private void FindAndReplaceControls_Load(object sender, EventArgs e)
        {

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
    }
}
