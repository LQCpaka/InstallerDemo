using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO.Compression;


namespace TRTInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string selectedPath;
        private void btBrowseM_MouseLeave(object sender, EventArgs e)//browse
        {
            btBrowseB.Visible = true;
            btBrowseM.Visible = false;
        }

        private void btBrowseB_MouseEnter(object sender, EventArgs e)//browse
        {
            btBrowseB.Visible = false;
            btBrowseM.Visible = true;
        }

        private void btInstallM_MouseLeave(object sender, EventArgs e)//install
        {
            btInstallB.Visible = true;
            btInstallM.Visible = false;
        }

        private void btInstallB_MouseEnter(object sender, EventArgs e)//install
        {
            btInstallB.Visible = false;
            btInstallM.Visible = true;
        }

        private void btBrowseM_Click(object sender, EventArgs e)
        {
            
            CommonOpenFileDialog browse = new CommonOpenFileDialog();
            browse.IsFolderPicker = true;
            if (browse.ShowDialog() == CommonFileDialogResult.Ok)
            {
                selectedPath = browse.FileName;
                lbfolderPath.Text = selectedPath;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btInstallM_Click(object sender, EventArgs e)
        {

            string sourceFilePath = Path.Combine(Application.StartupPath, "Resource.bin");
            if (selectedPath == null)
            {
                pWrongpath.Visible = true;
                timer1.Start();
            }
            else
            {
                if (!string.IsNullOrEmpty(sourceFilePath))
                {

                    try
                    {
                        using (ZipArchive archive = ZipFile.OpenRead(sourceFilePath))
                        {
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                string fullPath = Path.Combine(selectedPath, entry.FullName);

                                // Create directory if needed
                                if (entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\"))
                                {
                                    Directory.CreateDirectory(fullPath);
                                    continue;
                                }

                                // Extract the file
                                entry.ExtractToFile(fullPath, true);
                            }
                        }

                        pSucceded.Visible = true;
                        timer1.Start();

                    }
                    catch
                    {

                        pFail.Visible = true;
                        timer1.Start();
                    }


                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pWrongpath.Visible = false;
            pFail.Visible = false;
            pSucceded.Visible = false;
            timer1.Stop();
        }

        private void lbfolderPath_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(lbfolderPath, selectedPath);
        }


    }
}
