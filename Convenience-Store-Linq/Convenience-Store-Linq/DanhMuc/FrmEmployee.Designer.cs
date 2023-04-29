namespace Convenience_Store_Linq.DanhMuc
{
    partial class FrmEmployee
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
            this.txtIDEmp = new System.Windows.Forms.TextBox();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.btnAddEMP = new System.Windows.Forms.Button();
            this.dgvEMPLOYEE = new System.Windows.Forms.DataGridView();
            this.txtPhoneEMP = new System.Windows.Forms.TextBox();
            this.lbPhoneEMP = new System.Windows.Forms.Label();
            this.btnReloadEMP = new System.Windows.Forms.Button();
            this.txtNameEMP = new System.Windows.Forms.TextBox();
            this.lbNameEMP = new System.Windows.Forms.Label();
            this.btnChangedEMP = new System.Windows.Forms.Button();
            this.txtAddressEMP = new System.Windows.Forms.TextBox();
            this.lbAddressEMP = new System.Windows.Forms.Label();
            this.btnExitEMP = new System.Windows.Forms.Button();
            this.txtDateOfBirthEMP = new System.Windows.Forms.TextBox();
            this.lbDateofBirthEMP = new System.Windows.Forms.Label();
            this.btnDeleteEMP = new System.Windows.Forms.Button();
            this.txtPositionEMP = new System.Windows.Forms.TextBox();
            this.lbPositionEMP = new System.Windows.Forms.Label();
            this.txtGenderEMP = new System.Windows.Forms.TextBox();
            this.lbGenderEMP = new System.Windows.Forms.Label();
            this.txtSalaryEMP = new System.Windows.Forms.TextBox();
            this.lbSalaryEMP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.Location = new System.Drawing.Point(36, 26);
            this.txtIDEmp.Multiline = true;
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(267, 45);
            this.txtIDEmp.TabIndex = 0;
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(53, 55);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(20, 16);
            this.lbEmpID.TabIndex = 1;
            this.lbEmpID.Text = "ID";
            // 
            // btnAddEMP
            // 
            this.btnAddEMP.Location = new System.Drawing.Point(804, 26);
            this.btnAddEMP.Name = "btnAddEMP";
            this.btnAddEMP.Size = new System.Drawing.Size(128, 45);
            this.btnAddEMP.TabIndex = 2;
            this.btnAddEMP.Text = "Add";
            this.btnAddEMP.UseVisualStyleBackColor = true;
            this.btnAddEMP.Click += new System.EventHandler(this.btnAddEMP_Click);
            // 
            // dgvEMPLOYEE
            // 
            this.dgvEMPLOYEE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMPLOYEE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEMPLOYEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMPLOYEE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEMPLOYEE.Location = new System.Drawing.Point(0, 333);
            this.dgvEMPLOYEE.Name = "dgvEMPLOYEE";
            this.dgvEMPLOYEE.RowHeadersWidth = 51;
            this.dgvEMPLOYEE.RowTemplate.Height = 24;
            this.dgvEMPLOYEE.Size = new System.Drawing.Size(1315, 281);
            this.dgvEMPLOYEE.TabIndex = 3;
            this.dgvEMPLOYEE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEMPLOYEE_CellContentClick);
            // 
            // txtPhoneEMP
            // 
            this.txtPhoneEMP.Location = new System.Drawing.Point(338, 26);
            this.txtPhoneEMP.Multiline = true;
            this.txtPhoneEMP.Name = "txtPhoneEMP";
            this.txtPhoneEMP.Size = new System.Drawing.Size(267, 45);
            this.txtPhoneEMP.TabIndex = 0;
            // 
            // lbPhoneEMP
            // 
            this.lbPhoneEMP.AutoSize = true;
            this.lbPhoneEMP.Location = new System.Drawing.Point(355, 55);
            this.lbPhoneEMP.Name = "lbPhoneEMP";
            this.lbPhoneEMP.Size = new System.Drawing.Size(46, 16);
            this.lbPhoneEMP.TabIndex = 1;
            this.lbPhoneEMP.Text = "Phone";
            // 
            // btnReloadEMP
            // 
            this.btnReloadEMP.Location = new System.Drawing.Point(1106, 26);
            this.btnReloadEMP.Name = "btnReloadEMP";
            this.btnReloadEMP.Size = new System.Drawing.Size(128, 45);
            this.btnReloadEMP.TabIndex = 2;
            this.btnReloadEMP.Text = "Reload";
            this.btnReloadEMP.UseVisualStyleBackColor = true;
            this.btnReloadEMP.Click += new System.EventHandler(this.btnReloadEMP_Click);
            // 
            // txtNameEMP
            // 
            this.txtNameEMP.Location = new System.Drawing.Point(36, 90);
            this.txtNameEMP.Multiline = true;
            this.txtNameEMP.Name = "txtNameEMP";
            this.txtNameEMP.Size = new System.Drawing.Size(267, 45);
            this.txtNameEMP.TabIndex = 0;
            // 
            // lbNameEMP
            // 
            this.lbNameEMP.AutoSize = true;
            this.lbNameEMP.Location = new System.Drawing.Point(53, 119);
            this.lbNameEMP.Name = "lbNameEMP";
            this.lbNameEMP.Size = new System.Drawing.Size(44, 16);
            this.lbNameEMP.TabIndex = 1;
            this.lbNameEMP.Text = "Name";
            // 
            // btnChangedEMP
            // 
            this.btnChangedEMP.Location = new System.Drawing.Point(804, 90);
            this.btnChangedEMP.Name = "btnChangedEMP";
            this.btnChangedEMP.Size = new System.Drawing.Size(128, 45);
            this.btnChangedEMP.TabIndex = 2;
            this.btnChangedEMP.Text = "Changed";
            this.btnChangedEMP.UseVisualStyleBackColor = true;
            this.btnChangedEMP.Click += new System.EventHandler(this.btnChangedEMP_Click);
            // 
            // txtAddressEMP
            // 
            this.txtAddressEMP.Location = new System.Drawing.Point(338, 90);
            this.txtAddressEMP.Multiline = true;
            this.txtAddressEMP.Name = "txtAddressEMP";
            this.txtAddressEMP.Size = new System.Drawing.Size(267, 45);
            this.txtAddressEMP.TabIndex = 0;
            // 
            // lbAddressEMP
            // 
            this.lbAddressEMP.AutoSize = true;
            this.lbAddressEMP.Location = new System.Drawing.Point(355, 119);
            this.lbAddressEMP.Name = "lbAddressEMP";
            this.lbAddressEMP.Size = new System.Drawing.Size(58, 16);
            this.lbAddressEMP.TabIndex = 1;
            this.lbAddressEMP.Text = "Address";
            // 
            // btnExitEMP
            // 
            this.btnExitEMP.Location = new System.Drawing.Point(1106, 90);
            this.btnExitEMP.Name = "btnExitEMP";
            this.btnExitEMP.Size = new System.Drawing.Size(128, 45);
            this.btnExitEMP.TabIndex = 2;
            this.btnExitEMP.Text = "Exit";
            this.btnExitEMP.UseVisualStyleBackColor = true;
            this.btnExitEMP.Click += new System.EventHandler(this.btnExitEMP_Click);
            // 
            // txtDateOfBirthEMP
            // 
            this.txtDateOfBirthEMP.Location = new System.Drawing.Point(36, 153);
            this.txtDateOfBirthEMP.Multiline = true;
            this.txtDateOfBirthEMP.Name = "txtDateOfBirthEMP";
            this.txtDateOfBirthEMP.Size = new System.Drawing.Size(267, 45);
            this.txtDateOfBirthEMP.TabIndex = 0;
            // 
            // lbDateofBirthEMP
            // 
            this.lbDateofBirthEMP.AutoSize = true;
            this.lbDateofBirthEMP.Location = new System.Drawing.Point(53, 182);
            this.lbDateofBirthEMP.Name = "lbDateofBirthEMP";
            this.lbDateofBirthEMP.Size = new System.Drawing.Size(79, 16);
            this.lbDateofBirthEMP.TabIndex = 1;
            this.lbDateofBirthEMP.Text = "Date of Birth";
            // 
            // btnDeleteEMP
            // 
            this.btnDeleteEMP.Location = new System.Drawing.Point(804, 153);
            this.btnDeleteEMP.Name = "btnDeleteEMP";
            this.btnDeleteEMP.Size = new System.Drawing.Size(128, 45);
            this.btnDeleteEMP.TabIndex = 2;
            this.btnDeleteEMP.Text = "Delete";
            this.btnDeleteEMP.UseVisualStyleBackColor = true;
            this.btnDeleteEMP.Click += new System.EventHandler(this.btnDeleteEMP_Click);
            // 
            // txtPositionEMP
            // 
            this.txtPositionEMP.Location = new System.Drawing.Point(338, 153);
            this.txtPositionEMP.Multiline = true;
            this.txtPositionEMP.Name = "txtPositionEMP";
            this.txtPositionEMP.Size = new System.Drawing.Size(267, 45);
            this.txtPositionEMP.TabIndex = 0;
            // 
            // lbPositionEMP
            // 
            this.lbPositionEMP.AutoSize = true;
            this.lbPositionEMP.Location = new System.Drawing.Point(355, 182);
            this.lbPositionEMP.Name = "lbPositionEMP";
            this.lbPositionEMP.Size = new System.Drawing.Size(55, 16);
            this.lbPositionEMP.TabIndex = 1;
            this.lbPositionEMP.Text = "Position";
            // 
            // txtGenderEMP
            // 
            this.txtGenderEMP.Location = new System.Drawing.Point(36, 221);
            this.txtGenderEMP.Multiline = true;
            this.txtGenderEMP.Name = "txtGenderEMP";
            this.txtGenderEMP.Size = new System.Drawing.Size(267, 45);
            this.txtGenderEMP.TabIndex = 0;
            // 
            // lbGenderEMP
            // 
            this.lbGenderEMP.AutoSize = true;
            this.lbGenderEMP.Location = new System.Drawing.Point(53, 250);
            this.lbGenderEMP.Name = "lbGenderEMP";
            this.lbGenderEMP.Size = new System.Drawing.Size(52, 16);
            this.lbGenderEMP.TabIndex = 1;
            this.lbGenderEMP.Text = "Gender";
            // 
            // txtSalaryEMP
            // 
            this.txtSalaryEMP.Location = new System.Drawing.Point(338, 221);
            this.txtSalaryEMP.Multiline = true;
            this.txtSalaryEMP.Name = "txtSalaryEMP";
            this.txtSalaryEMP.Size = new System.Drawing.Size(267, 45);
            this.txtSalaryEMP.TabIndex = 0;
            // 
            // lbSalaryEMP
            // 
            this.lbSalaryEMP.AutoSize = true;
            this.lbSalaryEMP.Location = new System.Drawing.Point(355, 250);
            this.lbSalaryEMP.Name = "lbSalaryEMP";
            this.lbSalaryEMP.Size = new System.Drawing.Size(46, 16);
            this.lbSalaryEMP.TabIndex = 1;
            this.lbSalaryEMP.Text = "Salary";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 614);
            this.Controls.Add(this.dgvEMPLOYEE);
            this.Controls.Add(this.btnDeleteEMP);
            this.Controls.Add(this.btnExitEMP);
            this.Controls.Add(this.btnChangedEMP);
            this.Controls.Add(this.btnReloadEMP);
            this.Controls.Add(this.btnAddEMP);
            this.Controls.Add(this.lbGenderEMP);
            this.Controls.Add(this.lbSalaryEMP);
            this.Controls.Add(this.lbPositionEMP);
            this.Controls.Add(this.lbDateofBirthEMP);
            this.Controls.Add(this.lbAddressEMP);
            this.Controls.Add(this.lbNameEMP);
            this.Controls.Add(this.lbPhoneEMP);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.txtGenderEMP);
            this.Controls.Add(this.txtSalaryEMP);
            this.Controls.Add(this.txtPositionEMP);
            this.Controls.Add(this.txtDateOfBirthEMP);
            this.Controls.Add(this.txtAddressEMP);
            this.Controls.Add(this.txtNameEMP);
            this.Controls.Add(this.txtPhoneEMP);
            this.Controls.Add(this.txtIDEmp);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDEmp;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.Button btnAddEMP;
        private System.Windows.Forms.DataGridView dgvEMPLOYEE;
        private System.Windows.Forms.TextBox txtPhoneEMP;
        private System.Windows.Forms.Label lbPhoneEMP;
        private System.Windows.Forms.Button btnReloadEMP;
        private System.Windows.Forms.TextBox txtNameEMP;
        private System.Windows.Forms.Label lbNameEMP;
        private System.Windows.Forms.Button btnChangedEMP;
        private System.Windows.Forms.TextBox txtAddressEMP;
        private System.Windows.Forms.Label lbAddressEMP;
        private System.Windows.Forms.Button btnExitEMP;
        private System.Windows.Forms.TextBox txtDateOfBirthEMP;
        private System.Windows.Forms.Label lbDateofBirthEMP;
        private System.Windows.Forms.Button btnDeleteEMP;
        private System.Windows.Forms.TextBox txtPositionEMP;
        private System.Windows.Forms.Label lbPositionEMP;
        private System.Windows.Forms.TextBox txtGenderEMP;
        private System.Windows.Forms.Label lbGenderEMP;
        private System.Windows.Forms.TextBox txtSalaryEMP;
        private System.Windows.Forms.Label lbSalaryEMP;
    }
}