namespace Versioner
{
    partial class Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.labelOldVersion = new System.Windows.Forms.Label();
            this.labelNewVersion = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.numericUpDownOldVersionMajor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOldVersionMinor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOldVersionRev = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNewVersionMajor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNewVersionMinor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNewVersionRev = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersionMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersionMinor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersionRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersionMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersionMinor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersionRev)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOldVersion
            // 
            this.labelOldVersion.AutoSize = true;
            this.labelOldVersion.Location = new System.Drawing.Point(13, 33);
            this.labelOldVersion.Name = "labelOldVersion";
            this.labelOldVersion.Size = new System.Drawing.Size(86, 17);
            this.labelOldVersion.TabIndex = 0;
            this.labelOldVersion.Text = "Old Version:";
            // 
            // labelNewVersion
            // 
            this.labelNewVersion.AutoSize = true;
            this.labelNewVersion.Location = new System.Drawing.Point(13, 78);
            this.labelNewVersion.Name = "labelNewVersion";
            this.labelNewVersion.Size = new System.Drawing.Size(91, 17);
            this.labelNewVersion.TabIndex = 1;
            this.labelNewVersion.Text = "New Version:";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(16, 129);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(248, 29);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // numericUpDownOldVersionMajor
            // 
            this.numericUpDownOldVersionMajor.Enabled = false;
            this.numericUpDownOldVersionMajor.Location = new System.Drawing.Point(113, 27);
            this.numericUpDownOldVersionMajor.Name = "numericUpDownOldVersionMajor";
            this.numericUpDownOldVersionMajor.Size = new System.Drawing.Size(50, 22);
            this.numericUpDownOldVersionMajor.TabIndex = 5;
            // 
            // numericUpDownOldVersionMinor
            // 
            this.numericUpDownOldVersionMinor.Enabled = false;
            this.numericUpDownOldVersionMinor.Location = new System.Drawing.Point(163, 27);
            this.numericUpDownOldVersionMinor.Name = "numericUpDownOldVersionMinor";
            this.numericUpDownOldVersionMinor.Size = new System.Drawing.Size(50, 22);
            this.numericUpDownOldVersionMinor.TabIndex = 6;
            // 
            // numericUpDownOldVersionRev
            // 
            this.numericUpDownOldVersionRev.Enabled = false;
            this.numericUpDownOldVersionRev.Location = new System.Drawing.Point(214, 28);
            this.numericUpDownOldVersionRev.Name = "numericUpDownOldVersionRev";
            this.numericUpDownOldVersionRev.Size = new System.Drawing.Size(50, 22);
            this.numericUpDownOldVersionRev.TabIndex = 7;
            // 
            // numericUpDownNewVersionMajor
            // 
            this.numericUpDownNewVersionMajor.Location = new System.Drawing.Point(113, 76);
            this.numericUpDownNewVersionMajor.Name = "numericUpDownNewVersionMajor";
            this.numericUpDownNewVersionMajor.Size = new System.Drawing.Size(50, 22);
            this.numericUpDownNewVersionMajor.TabIndex = 8;
            this.numericUpDownNewVersionMajor.ValueChanged += new System.EventHandler(this.NumericUpDownNewVersionMajor_ValueChanged);
            // 
            // numericUpDownNewVersionMinor
            // 
            this.numericUpDownNewVersionMinor.Location = new System.Drawing.Point(163, 76);
            this.numericUpDownNewVersionMinor.Name = "numericUpDownNewVersionMinor";
            this.numericUpDownNewVersionMinor.Size = new System.Drawing.Size(50, 22);
            this.numericUpDownNewVersionMinor.TabIndex = 9;
            this.numericUpDownNewVersionMinor.ValueChanged += new System.EventHandler(this.NumericUpDownNewVersionMinor_ValueChanged);
            // 
            // numericUpDownNewVersionRev
            // 
            this.numericUpDownNewVersionRev.Location = new System.Drawing.Point(214, 76);
            this.numericUpDownNewVersionRev.Name = "numericUpDownNewVersionRev";
            this.numericUpDownNewVersionRev.Size = new System.Drawing.Size(50, 22);
            this.numericUpDownNewVersionRev.TabIndex = 10;
            this.numericUpDownNewVersionRev.ValueChanged += new System.EventHandler(this.NumericUpDownNewVersionRev_ValueChanged);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 170);
            this.Controls.Add(this.numericUpDownNewVersionRev);
            this.Controls.Add(this.numericUpDownNewVersionMinor);
            this.Controls.Add(this.numericUpDownNewVersionMajor);
            this.Controls.Add(this.numericUpDownOldVersionRev);
            this.Controls.Add(this.numericUpDownOldVersionMinor);
            this.Controls.Add(this.numericUpDownOldVersionMajor);
            this.Controls.Add(this.update);
            this.Controls.Add(this.labelNewVersion);
            this.Controls.Add(this.labelOldVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gui";
            this.Text = "Update Version";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersionMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersionMinor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldVersionRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersionMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersionMinor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersionRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOldVersion;
        private System.Windows.Forms.Label labelNewVersion;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.NumericUpDown numericUpDownOldVersionMajor;
        private System.Windows.Forms.NumericUpDown numericUpDownOldVersionMinor;
        private System.Windows.Forms.NumericUpDown numericUpDownOldVersionRev;
        private System.Windows.Forms.NumericUpDown numericUpDownNewVersionMajor;
        private System.Windows.Forms.NumericUpDown numericUpDownNewVersionMinor;
        private System.Windows.Forms.NumericUpDown numericUpDownNewVersionRev;
    }
}

