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
    public partial class RenameFileForPath : UserControl
    {
        private MainModel mainModel;
        private MainPresenter presenter = null;

        public RenameFileForPath(MainModel model, MainPresenter presenter)
        {
            InitializeComponent();
            mainModel = model;
            this.presenter = presenter;
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            numDirsToInclude.SelectedIndex = 0;
            dirSeperatorChar.SelectedIndex = 0;
            orderBy.SelectedIndex = 0;
            incFilesExist.SelectedIndex = 0;
        }

        private void renameAll_Click(object sender, EventArgs e)
        {
            string error;
            if(!presenter.RenameFilesByDirectory(Convert.ToInt32(numDirsToInclude.SelectedItem), (NameByPathSeperatorEnum)dirSeperatorChar.SelectedIndex, 
                (DisplaySortOptionEnum)(orderBy.SelectedIndex + 1), out error, IsNumberFiles.Checked, incFilesExist.SelectedIndex, spaceBuffer.Checked))
            {
                renameByPathErrorProv.SetError(btnRenameAll, error);
            }
            else
            {
                renameByPathErrorProv.Clear();
            }
        }
    }
}
