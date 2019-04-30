namespace HelpdeskSystem
{
    partial class frmTechHanding
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
            this.dgvFAQ = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQ)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFAQ
            // 
            this.dgvFAQ.AllowUserToAddRows = false;
            this.dgvFAQ.AllowUserToDeleteRows = false;
            this.dgvFAQ.AllowUserToResizeColumns = false;
            this.dgvFAQ.AllowUserToResizeRows = false;
            this.dgvFAQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFAQ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFAQ.BackgroundColor = System.Drawing.Color.White;
            this.dgvFAQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFAQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFAQ.Location = new System.Drawing.Point(41, 44);
            this.dgvFAQ.Name = "dgvFAQ";
            this.dgvFAQ.ReadOnly = true;
            this.dgvFAQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFAQ.Size = new System.Drawing.Size(312, 355);
            this.dgvFAQ.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Location = new System.Drawing.Point(278, 419);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 30);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose one or many rows:";
            // 
            // frmTechHanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvFAQ);
            this.Name = "frmTechHanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTechHanding";
            this.Load += new System.EventHandler(this.frmTechHanding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFAQ;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
    }
}