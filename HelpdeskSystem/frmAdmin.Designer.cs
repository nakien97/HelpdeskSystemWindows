namespace HelpdeskSystem
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.textPurview = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pgListRequest = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picPhotoProfile = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pgFAQ = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchFAQ = new System.Windows.Forms.TextBox();
            this.pgProfile = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.imageAvatar = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pgFAQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pgProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.imageAvatar);
            this.panel4.Controls.Add(this.btnChange);
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 262);
            this.panel4.TabIndex = 18;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(51, 187);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(88, 26);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change Avatar";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // textPurview
            // 
            this.textPurview.BackColor = System.Drawing.Color.White;
            this.textPurview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPurview.Enabled = false;
            this.textPurview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPurview.Location = new System.Drawing.Point(109, 183);
            this.textPurview.Name = "textPurview";
            this.textPurview.Size = new System.Drawing.Size(286, 26);
            this.textPurview.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 26);
            this.textBox1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(11, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Purview:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(109, 73);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(286, 26);
            this.txtPhone.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(11, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Email:";
            // 
            // pgListRequest
            // 
            this.pgListRequest.Location = new System.Drawing.Point(4, 26);
            this.pgListRequest.Margin = new System.Windows.Forms.Padding(2);
            this.pgListRequest.Name = "pgListRequest";
            this.pgListRequest.Padding = new System.Windows.Forms.Padding(2);
            this.pgListRequest.Size = new System.Drawing.Size(616, 469);
            this.pgListRequest.TabIndex = 1;
            this.pgListRequest.Text = "List Request";
            this.pgListRequest.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon-32bit.png");
            this.imageList1.Images.SetKeyName(1, "icon-insert-32bit.png");
            this.imageList1.Images.SetKeyName(2, "checklist-icon.png");
            this.imageList1.Images.SetKeyName(3, "Search-File-icon.png");
            // 
            // picPhotoProfile
            // 
            this.picPhotoProfile.Image = ((System.Drawing.Image)(resources.GetObject("picPhotoProfile.Image")));
            this.picPhotoProfile.Location = new System.Drawing.Point(563, 11);
            this.picPhotoProfile.Name = "picPhotoProfile";
            this.picPhotoProfile.Size = new System.Drawing.Size(51, 39);
            this.picPhotoProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhotoProfile.TabIndex = 20;
            this.picPhotoProfile.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(109, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 26);
            this.txtName.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 621);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "©";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 622);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "2019 TKHL Company | nService";
            // 
            // linkOut
            // 
            this.linkOut.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkOut.AutoSize = true;
            this.linkOut.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkOut.LinkColor = System.Drawing.Color.Black;
            this.linkOut.Location = new System.Drawing.Point(560, 53);
            this.linkOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkOut.Name = "linkOut";
            this.linkOut.Size = new System.Drawing.Size(63, 17);
            this.linkOut.TabIndex = 17;
            this.linkOut.TabStop = true;
            this.linkOut.Text = "Sign Out";
            this.linkOut.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOut_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(541, 53);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(11, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Full Name:";
            // 
            // pgFAQ
            // 
            this.pgFAQ.Controls.Add(this.dataGridView2);
            this.pgFAQ.Controls.Add(this.btnSearch);
            this.pgFAQ.Controls.Add(this.txtSearchFAQ);
            this.pgFAQ.Location = new System.Drawing.Point(4, 26);
            this.pgFAQ.Margin = new System.Windows.Forms.Padding(2);
            this.pgFAQ.Name = "pgFAQ";
            this.pgFAQ.Padding = new System.Windows.Forms.Padding(2);
            this.pgFAQ.Size = new System.Drawing.Size(616, 469);
            this.pgFAQ.TabIndex = 3;
            this.pgFAQ.Text = "FAQ";
            this.pgFAQ.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.Location = new System.Drawing.Point(17, 66);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(582, 379);
            this.dataGridView2.TabIndex = 6;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(561, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchFAQ
            // 
            this.txtSearchFAQ.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchFAQ.Location = new System.Drawing.Point(393, 31);
            this.txtSearchFAQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchFAQ.Name = "txtSearchFAQ";
            this.txtSearchFAQ.Size = new System.Drawing.Size(164, 23);
            this.txtSearchFAQ.TabIndex = 4;
            this.txtSearchFAQ.Text = "ID or keyword";
            this.txtSearchFAQ.Enter += new System.EventHandler(this.txtSearchFAQ_Enter);
            // 
            // pgProfile
            // 
            this.pgProfile.BackColor = System.Drawing.Color.White;
            this.pgProfile.Controls.Add(this.panel5);
            this.pgProfile.Controls.Add(this.panel4);
            this.pgProfile.Location = new System.Drawing.Point(4, 26);
            this.pgProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pgProfile.Name = "pgProfile";
            this.pgProfile.Padding = new System.Windows.Forms.Padding(2);
            this.pgProfile.Size = new System.Drawing.Size(616, 469);
            this.pgProfile.TabIndex = 2;
            this.pgProfile.Text = "Profile";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.textPurview);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtPhone);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(192, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 262);
            this.panel5.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(11, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telephone:";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.pgListRequest);
            this.TabControl1.Controls.Add(this.pgFAQ);
            this.TabControl1.Controls.Add(this.pgProfile);
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(11, 74);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(624, 499);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 14;
            // 
            // imageAvatar
            // 
            this.imageAvatar.BackColor = System.Drawing.Color.DarkGray;
            this.imageAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imageAvatar.Image")));
            this.imageAvatar.Location = new System.Drawing.Point(22, 21);
            this.imageAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.imageAvatar.Name = "imageAvatar";
            this.imageAvatar.Size = new System.Drawing.Size(141, 161);
            this.imageAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAvatar.TabIndex = 3;
            this.imageAvatar.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(652, 508);
            this.Controls.Add(this.picPhotoProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkOut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pgFAQ.ResumeLayout(false);
            this.pgFAQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pgProfile.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox textPurview;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage pgListRequest;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picPhotoProfile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage pgFAQ;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchFAQ;
        private System.Windows.Forms.TabPage pgProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.PictureBox imageAvatar;
    }
}