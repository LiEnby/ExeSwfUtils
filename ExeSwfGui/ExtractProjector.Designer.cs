namespace ExeSwfGui
{
    partial class ExtractProjector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractProjector));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.text_bundledProjectorExe = new System.Windows.Forms.TextBox();
            this.btn_extractProjector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXE File:";
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.Location = new System.Drawing.Point(370, 7);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // text_bundledProjectorExe
            // 
            this.text_bundledProjectorExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_bundledProjectorExe.Location = new System.Drawing.Point(60, 9);
            this.text_bundledProjectorExe.Name = "text_bundledProjectorExe";
            this.text_bundledProjectorExe.Size = new System.Drawing.Size(304, 20);
            this.text_bundledProjectorExe.TabIndex = 2;
            this.text_bundledProjectorExe.TextChanged += new System.EventHandler(this.text_bundledProjectorExe_TextChanged);
            // 
            // btn_extractProjector
            // 
            this.btn_extractProjector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_extractProjector.Enabled = false;
            this.btn_extractProjector.Location = new System.Drawing.Point(15, 35);
            this.btn_extractProjector.Name = "btn_extractProjector";
            this.btn_extractProjector.Size = new System.Drawing.Size(430, 23);
            this.btn_extractProjector.TabIndex = 3;
            this.btn_extractProjector.Text = "Extract Raw Projector";
            this.btn_extractProjector.UseVisualStyleBackColor = true;
            this.btn_extractProjector.Click += new System.EventHandler(this.btn_extractProjector_Click);
            // 
            // ExtractProjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 73);
            this.Controls.Add(this.btn_extractProjector);
            this.Controls.Add(this.text_bundledProjectorExe);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 112);
            this.MinimumSize = new System.Drawing.Size(473, 112);
            this.Name = "ExtractProjector";
            this.Text = "ExeSwfUtils: Extract Raw Projector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtractProjector_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox text_bundledProjectorExe;
        private System.Windows.Forms.Button btn_extractProjector;
    }
}