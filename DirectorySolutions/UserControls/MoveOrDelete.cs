using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DirectorySolutions.Models;
using DirectorySolutions.Presenters;
using Newtonsoft.Json;

namespace DirectorySolutions.UserControls
{
    public partial class MoveOrDelete : UserControl
    {
        private MainModel mainModel;
        private MainPresenter presenter = null;

        public MoveOrDelete(MainModel model, MainPresenter presenter)
        {
            InitializeComponent();
            mainModel = model;
            this.presenter = presenter;
            BuildFastPathContextMenuItems();
        }

        private void BuildFastPathContextMenuItems()
        {
            var fastPaths = JsonConvert.DeserializeObject<List<string>>(Properties.Settings.Default.FastPaths);
            string error;
            if (!presenter.PopulateFastPathContextMenu(fastPathMenuStripMoveDelete, out error, ref fastPaths))
            {
                MessageBox.Show(error, "Error");
            }
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            string error;
            if (!presenter.MoveFiles(out error, movePathTxt.Text))
            {
                movePathTxtErrorProv.SetError(movePathTxt, error);
            }
            else
            {
                movePathTxtErrorProv.Clear();
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
    }
}
