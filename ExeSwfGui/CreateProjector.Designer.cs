namespace ExeSwfGui
{
    partial class CreateProjector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProjector));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browseProjectorExe = new System.Windows.Forms.Button();
            this.text_selectedProjectorExe = new System.Windows.Forms.TextBox();
            this.btn_extractProjector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_bundledSwfFile = new System.Windows.Forms.TextBox();
            this.btn_browseBundledSwfFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projector EXE File:";
            // 
            // btn_browseProjectorExe
            // 
            this.btn_browseProjectorExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browseProjectorExe.Location = new System.Drawing.Point(370, 7);
            this.btn_browseProjectorExe.Name = "btn_browseProjectorExe";
            this.btn_browseProjectorExe.Size = new System.Drawing.Size(75, 23);
            this.btn_browseProjectorExe.TabIndex = 1;
            this.btn_browseProjectorExe.Text = "Browse";
            this.btn_browseProjectorExe.UseVisualStyleBackColor = true;
            this.btn_browseProjectorExe.Click += new System.EventHandler(this.btn_browseProjectorExe_Click);
            // 
            // text_selectedProjectorExe
            // 
            this.text_selectedProjectorExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_selectedProjectorExe.Location = new System.Drawing.Point(113, 9);
            this.text_selectedProjectorExe.Name = "text_selectedProjectorExe";
            this.text_selectedProjectorExe.Size = new System.Drawing.Size(251, 20);
            this.text_selectedProjectorExe.TabIndex = 2;
            this.text_selectedProjectorExe.TextChanged += new System.EventHandler(this.text_selectedProjectorExe_TextChanged);
            // 
            // btn_extractProjector
            // 
            this.btn_extractProjector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_extractProjector.Enabled = false;
            this.btn_extractProjector.Location = new System.Drawing.Point(15, 70);
            this.btn_extractProjector.Name = "btn_extractProjector";
            this.btn_extractProjector.Size = new System.Drawing.Size(430, 23);
            this.btn_extractProjector.TabIndex = 3;
            this.btn_extractProjector.Text = "Create Bundled Projector";
            this.btn_extractProjector.UseVisualStyleBackColor = true;
            this.btn_extractProjector.Click += new System.EventHandler(this.btn_createProjector_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bundled SWF File:";
            // 
            // text_bundledSwfFile
            // 
            this.text_bundledSwfFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_bundledSwfFile.Location = new System.Drawing.Point(113, 38);
            this.text_bundledSwfFile.Name = "text_bundledSwfFile";
            this.text_bundledSwfFile.Size = new System.Drawing.Size(251, 20);
            this.text_bundledSwfFile.TabIndex = 5;
            this.text_bundledSwfFile.TextChanged += new System.EventHandler(this.text_bundledSwfFile_TextChanged);
            // 
            // btn_browseBundledSwfFile
            // 
            this.btn_browseBundledSwfFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browseBundledSwfFile.Location = new System.Drawing.Point(370, 36);
            this.btn_browseBundledSwfFile.Name = "btn_browseBundledSwfFile";
            this.btn_browseBundledSwfFile.Size = new System.Drawing.Size(75, 23);
            this.btn_browseBundledSwfFile.TabIndex = 6;
            this.btn_browseBundledSwfFile.Text = "Browse";
            this.btn_browseBundledSwfFile.UseVisualStyleBackColor = true;
            this.btn_browseBundledSwfFile.Click += new System.EventHandler(this.btn_browseBundledSwfFile_Click);
            // 
            // CreateProjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 108);
            this.Controls.Add(this.btn_browseBundledSwfFile);
            this.Controls.Add(this.text_bundledSwfFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_extractProjector);
            this.Controls.Add(this.text_selectedProjectorExe);
            this.Controls.Add(this.btn_browseProjectorExe);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(473, 1920);
            this.MinimumSize = new System.Drawing.Size(473, 147);
            this.Name = "CreateProjector";
            this.Text = "ExeSwfUtils: Create Bundled Projector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtractProjector_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browseProjectorExe;
        private System.Windows.Forms.TextBox text_selectedProjectorExe;
        private System.Windows.Forms.Button btn_extractProjector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_bundledSwfFile;
        private System.Windows.Forms.Button btn_browseBundledSwfFile;
    }
}