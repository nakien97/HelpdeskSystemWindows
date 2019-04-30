namespace HelpdeskSystem
{
    partial class frmTechnician
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechnician));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabTechnican = new System.Windows.Forms.TabControl();
            this.pgTask = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPhoto = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefund = new System.Windows.Forms.Button();
            this.txtFAQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHanding = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.pgFAQ = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.pgListFAQ = new System.Windows.Forms.TabPage();
            this.dgvFaq = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchFAQ = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOffer = new System.Windows.Forms.DataGridView();
            this.pgProfile = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPurview = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imgAvatarHeader = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabTechnican.SuspendLayout();
            this.pgTask.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.pgFAQ.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.pgListFAQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaq)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffer)).BeginInit();
            this.pgProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTechnican
            // 
            this.tabTechnican.Controls.Add(this.pgTask);
            this.tabTechnican.Controls.Add(this.pgFAQ);
            this.tabTechnican.Controls.Add(this.pgProfile);
            this.tabTechnican.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTechnican.Location = new System.Drawing.Point(11, 74);
            this.tabTechnican.Margin = new System.Windows.Forms.Padding(2);
            this.tabTechnican.Name = "tabTechnican";
            this.tabTechnican.SelectedIndex = 0;
            this.tabTechnican.Size = new System.Drawing.Size(1078, 499);
            this.tabTechnican.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabTechnican.TabIndex = 21;
            // 
            // pgTask
            // 
            this.pgTask.BackColor = System.Drawing.Color.White;
            this.pgTask.Controls.Add(this.panel1);
            this.pgTask.Controls.Add(this.dgvTask);
            this.pgTask.Location = new System.Drawing.Point(4, 26);
            this.pgTask.Margin = new System.Windows.Forms.Padding(2);
            this.pgTask.Name = "pgTask";
            this.pgTask.Padding = new System.Windows.Forms.Padding(2);
            this.pgTask.Size = new System.Drawing.Size(1070, 469);
            this.pgTask.TabIndex = 1;
            this.pgTask.Text = "Task";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlPhoto);
            this.panel1.Controls.Add(this.btnRefund);
            this.panel1.Controls.Add(this.txtFAQ);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBonus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHanding);
            this.panel1.Location = new System.Drawing.Point(657, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 459);
            this.panel1.TabIndex = 1;
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.AutoScroll = true;
            this.pnlPhoto.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.pnlPhoto.AutoSize = true;
            this.pnlPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhoto.Location = new System.Drawing.Point(16, 63);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(362, 85);
            this.pnlPhoto.TabIndex = 12;
            // 
            // btnRefund
            // 
            this.btnRefund.Enabled = false;
            this.btnRefund.Location = new System.Drawing.Point(289, 390);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(75, 38);
            this.btnRefund.TabIndex = 11;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // txtFAQ
            // 
            this.txtFAQ.Location = new System.Drawing.Point(71, 323);
            this.txtFAQ.Name = "txtFAQ";
            this.txtFAQ.ReadOnly = true;
            this.txtFAQ.Size = new System.Drawing.Size(307, 23);
            this.txtFAQ.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "FAQ:";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(71, 161);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.ReadOnly = true;
            this.txtBonus.Size = new System.Drawing.Size(307, 152);
            this.txtBonus.TabIndex = 8;
            this.txtBonus.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bonus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Photo:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(94, 6);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(172, 23);
            this.txtEmployee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request by:";
            // 
            // btnHanding
            // 
            this.btnHanding.Location = new System.Drawing.Point(191, 390);
            this.btnHanding.Name = "btnHanding";
            this.btnHanding.Size = new System.Drawing.Size(75, 38);
            this.btnHanding.TabIndex = 0;
            this.btnHanding.Text = "Handling";
            this.btnHanding.UseVisualStyleBackColor = true;
            this.btnHanding.Click += new System.EventHandler(this.btnHanding_Click);
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.AllowUserToResizeColumns = false;
            this.dgvTask.AllowUserToResizeRows = false;
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTask.BackgroundColor = System.Drawing.Color.White;
            this.dgvTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(22, 5);
            this.dgvTask.MultiSelect = false;
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTask.Size = new System.Drawing.Size(619, 459);
            this.dgvTask.TabIndex = 0;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            this.dgvTask.SelectionChanged += new System.EventHandler(this.dgvTask_SelectionChanged);
            // 
            // pgFAQ
            // 
            this.pgFAQ.Controls.Add(this.tabControl2);
            this.pgFAQ.Location = new System.Drawing.Point(4, 26);
            this.pgFAQ.Margin = new System.Windows.Forms.Padding(2);
            this.pgFAQ.Name = "pgFAQ";
            this.pgFAQ.Padding = new System.Windows.Forms.Padding(2);
            this.pgFAQ.Size = new System.Drawing.Size(1070, 469);
            this.pgFAQ.TabIndex = 3;
            this.pgFAQ.Text = "FAQ";
            this.pgFAQ.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.pgListFAQ);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(5, 5);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1000, 461);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            // 
            // pgListFAQ
            // 
            this.pgListFAQ.Controls.Add(this.dgvFaq);
            this.pgListFAQ.Controls.Add(this.btnSearch);
            this.pgListFAQ.Controls.Add(this.txtSearchFAQ);
            this.pgListFAQ.Location = new System.Drawing.Point(4, 26);
            this.pgListFAQ.Name = "pgListFAQ";
            this.pgListFAQ.Padding = new System.Windows.Forms.Padding(3);
            this.pgListFAQ.Size = new System.Drawing.Size(992, 431);
            this.pgListFAQ.TabIndex = 0;
            this.pgListFAQ.Text = "List FAQ";
            this.pgListFAQ.UseVisualStyleBackColor = true;
            // 
            // dgvFaq
            // 
            this.dgvFaq.AllowUserToAddRows = false;
            this.dgvFaq.AllowUserToDeleteRows = false;
            this.dgvFaq.AllowUserToResizeColumns = false;
            this.dgvFaq.AllowUserToResizeRows = false;
            this.dgvFaq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFaq.BackgroundColor = System.Drawing.Color.White;
            this.dgvFaq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFaq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFaq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFaq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaq.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFaq.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFaq.Location = new System.Drawing.Point(4, 59);
            this.dgvFaq.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFaq.Name = "dgvFaq";
            this.dgvFaq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFaq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFaq.RowTemplate.Height = 24;
            this.dgvFaq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaq.Size = new System.Drawing.Size(582, 379);
            this.dgvFaq.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(285, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 38);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchFAQ
            // 
            this.txtSearchFAQ.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchFAQ.Location = new System.Drawing.Point(150, 24);
            this.txtSearchFAQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchFAQ.Name = "txtSearchFAQ";
            this.txtSearchFAQ.Size = new System.Drawing.Size(131, 23);
            this.txtSearchFAQ.TabIndex = 7;
            this.txtSearchFAQ.Text = "Type ID here";
            this.txtSearchFAQ.Enter += new System.EventHandler(this.txtSearchFAQ_Enter);
            this.txtSearchFAQ.Leave += new System.EventHandler(this.txtSearchFAQ_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnOK);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.dgvOffer);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Offer Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(462, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 24);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(411, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(24, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOffer
            // 
            this.dgvOffer.AllowUserToAddRows = false;
            this.dgvOffer.AllowUserToDeleteRows = false;
            this.dgvOffer.AllowUserToResizeColumns = false;
            this.dgvOffer.AllowUserToResizeRows = false;
            this.dgvOffer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOffer.BackgroundColor = System.Drawing.Color.White;
            this.dgvOffer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOffer.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOffer.Location = new System.Drawing.Point(3, 53);
            this.dgvOffer.MultiSelect = false;
            this.dgvOffer.Name = "dgvOffer";
            this.dgvOffer.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOffer.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOffer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOffer.ShowCellToolTips = false;
            this.dgvOffer.ShowEditingIcon = false;
            this.dgvOffer.Size = new System.Drawing.Size(654, 272);
            this.dgvOffer.TabIndex = 0;
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
            this.pgProfile.Size = new System.Drawing.Size(1070, 469);
            this.pgProfile.TabIndex = 2;
            this.pgProfile.Text = "Profile";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtPurview);
            this.panel5.Controls.Add(this.txtEmail);
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
            // txtPurview
            // 
            this.txtPurview.BackColor = System.Drawing.Color.White;
            this.txtPurview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurview.Enabled = false;
            this.txtPurview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurview.Location = new System.Drawing.Point(109, 183);
            this.txtPurview.Name = "txtPurview";
            this.txtPurview.Size = new System.Drawing.Size(286, 26);
            this.txtPurview.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(109, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 26);
            this.txtEmail.TabIndex = 15;
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnChange);
            this.panel4.Controls.Add(this.imgAvatar);
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 262);
            this.panel4.TabIndex = 18;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(51, 198);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(88, 26);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change Avatar";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.DarkGray;
            this.imgAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar.Image")));
            this.imgAvatar.Location = new System.Drawing.Point(21, 22);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(141, 161);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar.TabIndex = 1;
            this.imgAvatar.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 621);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "©";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 622);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "2019 TKHL Company | nService";
            // 
            // linkOut
            // 
            this.linkOut.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkOut.AutoSize = true;
            this.linkOut.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkOut.LinkColor = System.Drawing.Color.Black;
            this.linkOut.Location = new System.Drawing.Point(1001, 52);
            this.linkOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkOut.Name = "linkOut";
            this.linkOut.Size = new System.Drawing.Size(63, 17);
            this.linkOut.TabIndex = 24;
            this.linkOut.TabStop = true;
            this.linkOut.Text = "Sign Out";
            this.linkOut.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOut_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(982, 53);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
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
            // imgAvatarHeader
            // 
            this.imgAvatarHeader.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatarHeader.Image")));
            this.imgAvatarHeader.Location = new System.Drawing.Point(1013, 11);
            this.imgAvatarHeader.Name = "imgAvatarHeader";
            this.imgAvatarHeader.Size = new System.Drawing.Size(51, 39);
            this.imgAvatarHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatarHeader.TabIndex = 27;
            this.imgAvatarHeader.TabStop = false;
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
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1091, 585);
            this.Controls.Add(this.tabTechnican);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkOut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imgAvatarHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTechnician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technician";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTechnician_FormClosing);
            this.Load += new System.EventHandler(this.frmTechnician_Load);
            this.tabTechnican.ResumeLayout(false);
            this.pgTask.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.pgFAQ.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.pgListFAQ.ResumeLayout(false);
            this.pgListFAQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaq)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffer)).EndInit();
            this.pgProfile.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTechnican;
        private System.Windows.Forms.TabPage pgTask;
        private System.Windows.Forms.TabPage pgFAQ;
        private System.Windows.Forms.TabPage pgProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPurview;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox imgAvatarHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage pgListFAQ;
        private System.Windows.Forms.DataGridView dgvFaq;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchFAQ;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvOffer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHanding;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.TextBox txtFAQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtBonus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlPhoto;
    }
}