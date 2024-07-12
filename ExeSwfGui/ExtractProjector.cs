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
    public partial class ExtractProjector : Form
    {
        public ExtractProjector()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bundled Projector (*.exe)|*.exe";
            ofd.Title = "Browse for file";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                text_bundledProjectorExe.Text = ofd.FileName;
            }
        }

        private void btn_extractProjector_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Projector (*.exe)|*.exe";
            sfd.Title = "Save file";
            sfd.FileName = Path.GetFileNameWithoutExtension(text_bundledProjectorExe.Text) + "_raw.exe";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SwfExeExtractor.ExtractRawProjector(text_bundledProjectorExe.Text, sfd.FileName);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void text_bundledProjectorExe_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(text_bundledProjectorExe.Text)) btn_extractProjector.Enabled = true;
            else btn_extractProjector.Enabled = false;
        }

        private void ExtractProjector_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
