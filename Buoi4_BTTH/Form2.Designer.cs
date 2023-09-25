namespace Buoi4_BTTH
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.txtFacultyId = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnF2Update = new System.Windows.Forms.Button();
            this.btnF2Remove = new System.Windows.Forms.Button();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalProfessor);
            this.groupBox1.Controls.Add(this.txtFacultyId);
            this.groupBox1.Controls.Add(this.txtFacultyName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin khoa";
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Location = new System.Drawing.Point(138, 192);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(121, 27);
            this.txtTotalProfessor.TabIndex = 5;
            // 
            // txtFacultyId
            // 
            this.txtFacultyId.Location = new System.Drawing.Point(138, 54);
            this.txtFacultyId.Name = "txtFacultyId";
            this.txtFacultyId.Size = new System.Drawing.Size(121, 27);
            this.txtFacultyId.TabIndex = 4;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(138, 122);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(201, 27);
            this.txtFacultyName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tong so GS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma khoa";
            // 
            // btnF2Update
            // 
            this.btnF2Update.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnF2Update.Location = new System.Drawing.Point(107, 346);
            this.btnF2Update.Name = "btnF2Update";
            this.btnF2Update.Size = new System.Drawing.Size(114, 33);
            this.btnF2Update.TabIndex = 19;
            this.btnF2Update.Text = "Them / Sua";
            this.btnF2Update.UseVisualStyleBackColor = false;
            this.btnF2Update.Click += new System.EventHandler(this.btnF2Update_Click);
            // 
            // btnF2Remove
            // 
            this.btnF2Remove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnF2Remove.Location = new System.Drawing.Point(245, 346);
            this.btnF2Remove.Name = "btnF2Remove";
            this.btnF2Remove.Size = new System.Drawing.Size(114, 33);
            this.btnF2Remove.TabIndex = 20;
            this.btnF2Remove.Text = "Xoa";
            this.btnF2Remove.UseVisualStyleBackColor = false;
            this.btnF2Remove.Click += new System.EventHandler(this.btnF2Remove_Click);
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvFaculty.Location = new System.Drawing.Point(380, 56);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(491, 339);
            this.dgvFaculty.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ten khoa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tong so GS";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Location = new System.Drawing.Point(769, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvFaculty);
            this.Controls.Add(this.btnF2Remove);
            this.Controls.Add(this.btnF2Update);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.TextBox txtFacultyId;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnF2Update;
        private System.Windows.Forms.Button btnF2Remove;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnExit;
    }
}