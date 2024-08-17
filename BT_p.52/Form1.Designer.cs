namespace BT_p._52
{
    partial class frmDemoListBox
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
            this.lbClassList = new System.Windows.Forms.ListBox();
            this.lblClassList = new System.Windows.Forms.Label();
            this.lbJoinFootballList = new System.Windows.Forms.ListBox();
            this.lblJoinFootballList = new System.Windows.Forms.Label();
            this.btmAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClassList
            // 
            this.lbClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassList.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbClassList.FormattingEnabled = true;
            this.lbClassList.ItemHeight = 20;
            this.lbClassList.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Hoang Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung"});
            this.lbClassList.Location = new System.Drawing.Point(45, 74);
            this.lbClassList.Name = "lbClassList";
            this.lbClassList.Size = new System.Drawing.Size(249, 304);
            this.lbClassList.TabIndex = 0;
            // 
            // lblClassList
            // 
            this.lblClassList.AutoSize = true;
            this.lblClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassList.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClassList.Location = new System.Drawing.Point(42, 39);
            this.lblClassList.Name = "lblClassList";
            this.lblClassList.Size = new System.Drawing.Size(148, 16);
            this.lblClassList.TabIndex = 1;
            this.lblClassList.Text = "Danh sách sinh viên lớp";
            // 
            // lbJoinFootballList
            // 
            this.lbJoinFootballList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJoinFootballList.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lbJoinFootballList.FormattingEnabled = true;
            this.lbJoinFootballList.ItemHeight = 20;
            this.lbJoinFootballList.Location = new System.Drawing.Point(489, 74);
            this.lbJoinFootballList.Name = "lbJoinFootballList";
            this.lbJoinFootballList.Size = new System.Drawing.Size(284, 304);
            this.lbJoinFootballList.TabIndex = 2;
            // 
            // lblJoinFootballList
            // 
            this.lblJoinFootballList.AutoSize = true;
            this.lblJoinFootballList.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblJoinFootballList.Location = new System.Drawing.Point(486, 39);
            this.lblJoinFootballList.Name = "lblJoinFootballList";
            this.lblJoinFootballList.Size = new System.Drawing.Size(233, 32);
            this.lblJoinFootballList.TabIndex = 3;
            this.lblJoinFootballList.Text = "Danh sách sinh viên tham gia bóng đá\r\n\r\n";
            // 
            // btmAdd
            // 
            this.btmAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmAdd.FlatAppearance.BorderSize = 2;
            this.btmAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btmAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btmAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAdd.Location = new System.Drawing.Point(354, 161);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(80, 40);
            this.btmAdd.TabIndex = 4;
            this.btmAdd.Text = "Chọn";
            this.btmAdd.UseVisualStyleBackColor = false;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemove.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(354, 239);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 40);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmDemoListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.lblJoinFootballList);
            this.Controls.Add(this.lbJoinFootballList);
            this.Controls.Add(this.lblClassList);
            this.Controls.Add(this.lbClassList);
            this.Name = "frmDemoListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClassList;
        private System.Windows.Forms.Label lblClassList;
        private System.Windows.Forms.ListBox lbJoinFootballList;
        private System.Windows.Forms.Label lblJoinFootballList;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

