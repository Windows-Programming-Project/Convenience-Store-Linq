namespace Convenience_Store_Linq.DanhMuc
{
    partial class FrmProduct
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
            this.panel = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.txtIDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtIDT = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvPRODUCT = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtPrice);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.lb5);
            this.panel.Controls.Add(this.lb4);
            this.panel.Controls.Add(this.txtIDB);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txtIDP);
            this.panel.Controls.Add(this.txtIDT);
            this.panel.Controls.Add(this.lb1);
            this.panel.Controls.Add(this.lb2);
            this.panel.Location = new System.Drawing.Point(89, 7);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(654, 191);
            this.panel.TabIndex = 84;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(476, 84);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 26);
            this.txtPrice.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(476, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 26);
            this.txtName.TabIndex = 8;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(334, 90);
            this.lb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(59, 20);
            this.lb5.TabIndex = 7;
            this.lb5.Text = "Price:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(334, 37);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(134, 20);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Product Name:";
            // 
            // txtIDB
            // 
            this.txtIDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDB.Location = new System.Drawing.Point(186, 139);
            this.txtIDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDB.Name = "txtIDB";
            this.txtIDB.Size = new System.Drawing.Size(125, 26);
            this.txtIDB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Batch:";
            // 
            // txtIDP
            // 
            this.txtIDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDP.Location = new System.Drawing.Point(186, 31);
            this.txtIDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(125, 26);
            this.txtIDP.TabIndex = 2;
            // 
            // txtIDT
            // 
            this.txtIDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDT.Location = new System.Drawing.Point(186, 87);
            this.txtIDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDT.Name = "txtIDT";
            this.txtIDT.Size = new System.Drawing.Size(125, 26);
            this.txtIDT.TabIndex = 3;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(51, 34);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(105, 20);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "ID Product:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(51, 87);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(80, 20);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "ID Type:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(764, 28);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 70);
            this.btnBack.TabIndex = 83;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(724, 477);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(582, 477);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 28);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(427, 477);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 28);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(284, 477);
            this.btnFix.Margin = new System.Windows.Forms.Padding(4);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(93, 28);
            this.btnFix.TabIndex = 79;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(136, 477);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(764, 129);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 69);
            this.btnReload.TabIndex = 77;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // dgvPRODUCT
            // 
            this.dgvPRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCT.Location = new System.Drawing.Point(89, 221);
            this.dgvPRODUCT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPRODUCT.Name = "dgvPRODUCT";
            this.dgvPRODUCT.RowHeadersWidth = 51;
            this.dgvPRODUCT.Size = new System.Drawing.Size(777, 228);
            this.dgvPRODUCT.TabIndex = 76;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 513);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvPRODUCT);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txtIDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.TextBox txtIDT;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvPRODUCT;
    }
}