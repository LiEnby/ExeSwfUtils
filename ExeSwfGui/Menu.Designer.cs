namespace ExeSwfGui
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_extractSwf = new System.Windows.Forms.Button();
            this.btn_createExe = new System.Windows.Forms.Button();
            this.btn_extractRawProjector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_extractSwf
            // 
            this.btn_extractSwf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_extractSwf.Location = new System.Drawing.Point(12, 12);
            this.btn_extractSwf.Name = "btn_extractSwf";
            this.btn_extractSwf.Size = new System.Drawing.Size(284, 23);
            this.btn_extractSwf.TabIndex = 1;
            this.btn_extractSwf.Text = "Extract SWF From EXE";
            this.btn_extractSwf.UseVisualStyleBackColor = true;
            this.btn_extractSwf.Click += new System.EventHandler(this.btn_extractSwf_Click);
            // 
            // btn_createExe
            // 
            this.btn_createExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createExe.Location = new System.Drawing.Point(12, 41);
            this.btn_createExe.Name = "btn_createExe";
            this.btn_createExe.Size = new System.Drawing.Size(284, 23);
            this.btn_createExe.TabIndex = 2;
            this.btn_createExe.Text = "Create EXE From SWF";
            this.btn_createExe.UseVisualStyleBackColor = true;
            this.btn_createExe.Click += new System.EventHandler(this.btn_createExe_Click);
            // 
            // btn_extractRawProjector
            // 
            this.btn_extractRawProjector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_extractRawProjector.Location = new System.Drawing.Point(12, 70);
            this.btn_extractRawProjector.Name = "btn_extractRawProjector";
            this.btn_extractRawProjector.Size = new System.Drawing.Size(284, 23);
            this.btn_extractRawProjector.TabIndex = 3;
            this.btn_extractRawProjector.Text = "Extract Raw Projector From EXE";
            this.btn_extractRawProjector.UseVisualStyleBackColor = true;
            this.btn_extractRawProjector.Click += new System.EventHandler(this.btn_extractRawProjector_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 102);
            this.Controls.Add(this.btn_extractRawProjector);
            this.Controls.Add(this.btn_createExe);
            this.Controls.Add(this.btn_extractSwf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(324, 1920);
            this.MinimumSize = new System.Drawing.Size(324, 141);
            this.Name = "Menu";
            this.Text = "ExeSwfUtils: Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_extractSwf;
        private System.Windows.Forms.Button btn_createExe;
        private System.Windows.Forms.Button btn_extractRawProjector;
    }
}

