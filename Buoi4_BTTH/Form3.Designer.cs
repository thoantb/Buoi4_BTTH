namespace Buoi4_BTTH
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtFindId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFindStudent = new System.Windows.Forms.DataGridView();
            this.btnF3Update = new System.Windows.Forms.Button();
            this.btnF3Remove = new System.Windows.Forms.Button();
            this.btxF3Back = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtFindName);
            this.groupBox1.Controls.Add(this.txtFindId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin tim kiem";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(155, 95);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(216, 27);
            this.txtFindName.TabIndex = 4;
            // 
            // txtFindId
            // 
            this.txtFindId.Location = new System.Drawing.Point(155, 49);
            this.txtFindId.Name = "txtFindId";
            this.txtFindId.Size = new System.Drawing.Size(157, 27);
            this.txtFindId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ho Ten SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma So SV";
            // 
            // dgvFindStudent
            // 
            this.dgvFindStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvFindStudent.Location = new System.Drawing.Point(12, 258);
            this.dgvFindStudent.Name = "dgvFindStudent";
            this.dgvFindStudent.RowHeadersWidth = 51;
            this.dgvFindStudent.RowTemplate.Height = 24;
            this.dgvFindStudent.Size = new System.Drawing.Size(860, 212);
            this.dgvFindStudent.TabIndex = 1;
            // 
            // btnF3Update
            // 
            this.btnF3Update.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnF3Update.Location = new System.Drawing.Point(414, 219);
            this.btnF3Update.Name = "btnF3Update";
            this.btnF3Update.Size = new System.Drawing.Size(95, 33);
            this.btnF3Update.TabIndex = 20;
            this.btnF3Update.Text = "Tim Kiem";
            this.btnF3Update.UseVisualStyleBackColor = false;
            this.btnF3Update.Click += new System.EventHandler(this.btnF3Update_Click);
            // 
            // btnF3Remove
            // 
            this.btnF3Remove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnF3Remove.Location = new System.Drawing.Point(520, 219);
            this.btnF3Remove.Name = "btnF3Remove";
            this.btnF3Remove.Size = new System.Drawing.Size(95, 33);
            this.btnF3Remove.TabIndex = 21;
            this.btnF3Remove.Text = "Xoa";
            this.btnF3Remove.UseVisualStyleBackColor = false;
            this.btnF3Remove.Click += new System.EventHandler(this.btnF3Remove_Click);
            // 
            // btxF3Back
            // 
            this.btxF3Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btxF3Back.Location = new System.Drawing.Point(777, 219);
            this.btxF3Back.Name = "btxF3Back";
            this.btxF3Back.Size = new System.Drawing.Size(95, 33);
            this.btxF3Back.TabIndex = 22;
            this.btxF3Back.Text = "Tro ve";
            this.btxF3Back.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma So SV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ho Ten";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ten Khoa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Diem TB";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 482);
            this.Controls.Add(this.btxF3Back);
            this.Controls.Add(this.btnF3Remove);
            this.Controls.Add(this.btnF3Update);
            this.Controls.Add(this.dgvFindStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.TextBox txtFindId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFindStudent;
        private System.Windows.Forms.Button btnF3Update;
        private System.Windows.Forms.Button btnF3Remove;
        private System.Windows.Forms.Button btxF3Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}