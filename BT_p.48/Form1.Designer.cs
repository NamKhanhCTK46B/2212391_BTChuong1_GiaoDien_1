namespace BT_p._48
{
    partial class frmDemoComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemoComboBox));
            this.lblChonNN = new System.Windows.Forms.Label();
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChonNN
            // 
            resources.ApplyResources(this.lblChonNN, "lblChonNN");
            this.lblChonNN.Name = "lblChonNN";
            // 
            // cboNgoaiNgu
            // 
            resources.ApplyResources(this.cboNgoaiNgu, "cboNgoaiNgu");
            this.cboNgoaiNgu.BackColor = System.Drawing.SystemColors.Window;
            this.cboNgoaiNgu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgoaiNgu_SelectedIndexChanged);
            // 
            // frmDemoComboBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboNgoaiNgu);
            this.Controls.Add(this.lblChonNN);
            this.Name = "frmDemoComboBox";
            this.Load += new System.EventHandler(this.frmDemoComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChonNN;
        private System.Windows.Forms.ComboBox cboNgoaiNgu;
    }
}

