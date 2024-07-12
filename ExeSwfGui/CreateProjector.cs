using ExeSwfFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExeSwfGui
{
    public partial class CreateProjector : Form
    {
        public CreateProjector()
        {
            InitializeComponent();
        }

        private void check()
        {
            if (File.Exists(text_selectedProjectorExe.Text) && File.Exists(text_bundledSwfFile.Text)) btn_extractProjector.Enabled = true;
            else btn_extractProjector.Enabled = false;
        }
        private void btn_createProjector_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bundled Projector (*.exe)|*.exe";
            sfd.Title = "Save file";
            sfd.FileName = Path.ChangeExtension(text_bundledSwfFile.Text, ".exe");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SwfExeCreator.CreateExe(text_selectedProjectorExe.Text, text_bundledSwfFile.Text, sfd.FileName);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void text_selectedProjectorExe_TextChanged(object sender, EventArgs e)
        {
            check();
        }
        private void text_bundledSwfFile_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void ExtractProjector_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_browseProjectorExe_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Projector (*.exe)|*.exe";
            ofd.Title = "Browse for file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                text_selectedProjectorExe.Text = ofd.FileName;
            }
        }

        private void btn_browseBundledSwfFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Shockwave Flash (*.swf)|*.swf";
            ofd.Title = "Browse for file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                text_bundledSwfFile.Text = ofd.FileName;
            }
        }

    }
}
