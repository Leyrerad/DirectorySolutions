using System;
using System.Collections.Generic;
using System.IO;
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
        private List<string> destinationPaths;

        public MoveOrDelete(MainModel model, MainPresenter presenter)
        {
            InitializeComponent();
            mainModel = model;
            this.presenter = presenter;
            destinationPaths = new List<string>();
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

            var confirmResult = MessageBox.Show("Are you sure you want to move all the files in the file list to " + movePathTxt.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete all the files in the file list from your local system?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {

            }
        }

        private void movePathTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(movePathTxt.Text))
            {
                if (Directory.Exists(movePathTxt.Text))
                {
                    if (!destinationPaths.Contains(movePathTxt.Text))
                    {
                        destinationPaths.Add(movePathTxt.Text);
                        var pathLayout = new FlowLayoutPanel()
                        {
                            Size = new System.Drawing.Size(destinationPathsLayout.Width - 30, 30),
                            Name = "pathLayout" + destinationPaths.IndexOf(movePathTxt.Text).ToString()
                        };
                        pathLayout.Controls.Add(new Label() { Text = movePathTxt.Text, Padding = new Padding(0, 5, 0, 0) });
                        var button = new Button() { Name = "btnRemovePath" + destinationPaths.IndexOf(movePathTxt.Text).ToString(), Text = "Remove" };
                        button.Click += Remove_Click;
                        pathLayout.Controls.Add(button);
                        destinationPathsLayout.Controls.Add(pathLayout);
                        movePathTxt.Clear();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Unable to open the directory " + movePathTxt.Text + ".", "Error");
                }
            }          
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            var newName = ctrl.Name.Replace("btnRemovePath", "");
            int index;
            var validIndex = int.TryParse(newName, out index);
            if (validIndex && destinationPaths.Count > 0)
            {
                destinationPaths.RemoveAt(index);
                RefreshListIndexes();
            }          
        }

        private void RefreshListIndexes()
        {
            destinationPathsLayout.Controls.Clear();
            for(int i = 0; i < destinationPaths.Count; i++)
            {
                var pathLayout = new FlowLayoutPanel()
                {
                    Size = new System.Drawing.Size(destinationPathsLayout.Width - 20, 30),
                    Name = "pathLayout" + i.ToString()
                };
                pathLayout.Controls.Add(new Label() { Text = movePathTxt.Text, Padding = new Padding(0, 5, 0, 0) });
                var button = new Button() { Name = "btnRemovePath" + i.ToString(), Text = "Remove" };
                button.Click += Remove_Click;
                pathLayout.Controls.Add(button);
                destinationPathsLayout.Controls.Add(pathLayout);
            }
        }
    }
}
