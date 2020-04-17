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
    public partial class FindDuplicates : UserControl
    {
        private MainModel mainModel;
        private MainPresenter presenter;

        public FindDuplicates(MainModel model, MainPresenter presenter)
        {
            InitializeComponent();
        }
    }
}
