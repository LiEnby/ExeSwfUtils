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
    public partial class ExtractSwf : Form
    {
        public ExtractSwf()
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

        private void btn_extractSwf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Shockwave Flash (*.swf)|*.swf";
            sfd.Title = "Save file";
            sfd.FileName = Path.ChangeExtension(text_bundledProjectorExe.Text, ".swf");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SwfExeExtractor.ExtractSwf(text_bundledProjectorExe.Text, sfd.FileName);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void text_bundledProjectorExe_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(text_bundledProjectorExe.Text)) btn_extractSwf.Enabled = true;
            else btn_extractSwf.Enabled = false;
        }

        private void ExtractSwf_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
