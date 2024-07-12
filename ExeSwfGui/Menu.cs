using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExeSwfGui
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_extractSwf_Click(object sender, EventArgs e)
        {
            new ExtractSwf().ShowDialog();
        }

        private void btn_extractRawProjector_Click(object sender, EventArgs e)
        {
            new ExtractProjector().ShowDialog();
        }

        private void btn_createExe_Click(object sender, EventArgs e)
        {
            new CreateProjector().ShowDialog();
        }
    }
}
