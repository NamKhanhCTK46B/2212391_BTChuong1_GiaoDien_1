namespace BT_p._35
{
    partial class frmLinkLable
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
            this.lblMail = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lnkEmail = new System.Windows.Forms.LinkLabel();
            this.lnkVisitWeb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AllowDrop = true;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.Red;
            this.lblMail.Location = new System.Drawing.Point(34, 41);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(148, 25);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Địa chỉ liên hệ";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeb.ForeColor = System.Drawing.Color.Red;
            this.lblWeb.Location = new System.Drawing.Point(34, 101);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(114, 25);
            this.lblWeb.TabIndex = 1;
            this.lblWeb.Text = "Trang web";
            // 
            // lnkEmail
            // 
            this.lnkEmail.AutoSize = true;
            this.lnkEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lnkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEmail.Location = new System.Drawing.Point(236, 41);
            this.lnkEmail.Name = "lnkEmail";
            this.lnkEmail.Size = new System.Drawing.Size(180, 25);
            this.lnkEmail.TabIndex = 2;
            this.lnkEmail.TabStop = true;
            this.lnkEmail.Text = "ctk46b@dlu.edu.vn\r\n";
            this.lnkEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkEmail.VisitedLinkColor = System.Drawing.Color.PaleTurquoise;
            this.lnkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEmail_LinkClicked);
            // 
            // lnkVisitWeb
            // 
            this.lnkVisitWeb.AutoSize = true;
            this.lnkVisitWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkVisitWeb.Location = new System.Drawing.Point(236, 101);
            this.lnkVisitWeb.Name = "lnkVisitWeb";
            this.lnkVisitWeb.Size = new System.Drawing.Size(138, 25);
            this.lnkVisitWeb.TabIndex = 3;
            this.lnkVisitWeb.TabStop = true;
            this.lnkVisitWeb.Text = "cntt.dlu.edu.vn";
            this.lnkVisitWeb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkVisitWeb.VisitedLinkColor = System.Drawing.Color.PaleTurquoise;
            this.lnkVisitWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVisitWeb_LinkClicked);
            // 
            // frmLinkLable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 173);
            this.Controls.Add(this.lnkVisitWeb);
            this.Controls.Add(this.lnkEmail);
            this.Controls.Add(this.lblWeb);
            this.Controls.Add(this.lblMail);
            this.Name = "frmLinkLable";
            this.Text = "LinkLable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.LinkLabel lnkEmail;
        private System.Windows.Forms.LinkLabel lnkVisitWeb;
    }
}

