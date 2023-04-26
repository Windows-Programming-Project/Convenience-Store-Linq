namespace Convenience_Store_Linq.DanhMuc
{
    partial class FrmDetail
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
            this.txtdPrice = new System.Windows.Forms.TextBox();
            this.txtdAmount = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.txtIDI = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvDETAIL = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDETAIL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtdPrice);
            this.panel.Controls.Add(this.txtdAmount);
            this.panel.Controls.Add(this.lb5);
            this.panel.Controls.Add(this.lb4);
            this.panel.Controls.Add(this.txtIDI);
            this.panel.Controls.Add(this.txtIDP);
            this.panel.Controls.Add(this.lb1);
            this.panel.Controls.Add(this.lb2);
            this.panel.Location = new System.Drawing.Point(78, 39);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(587, 140);
            this.panel.TabIndex = 84;
            // 
            // txtdPrice
            // 
            this.txtdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdPrice.Location = new System.Drawing.Point(429, 87);
            this.txtdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtdPrice.Name = "txtdPrice";
            this.txtdPrice.Size = new System.Drawing.Size(125, 26);
            this.txtdPrice.TabIndex = 9;
            // 
            // txtdAmount
            // 
            this.txtdAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdAmount.Location = new System.Drawing.Point(429, 34);
            this.txtdAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtdAmount.Name = "txtdAmount";
            this.txtdAmount.Size = new System.Drawing.Size(125, 26);
            this.txtdAmount.TabIndex = 8;
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
            this.lb4.Size = new System.Drawing.Size(78, 20);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Amount:";
            // 
            // txtIDI
            // 
            this.txtIDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDI.Location = new System.Drawing.Point(186, 31);
            this.txtIDI.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDI.Name = "txtIDI";
            this.txtIDI.Size = new System.Drawing.Size(125, 26);
            this.txtIDI.TabIndex = 2;
            // 
            // txtIDP
            // 
            this.txtIDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDP.Location = new System.Drawing.Point(186, 87);
            this.txtIDP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(125, 26);
            this.txtIDP.TabIndex = 3;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(51, 34);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(99, 20);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "ID Invoice:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(51, 87);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(105, 20);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "ID Product:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(713, 39);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 70);
            this.btnBack.TabIndex = 83;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(695, 458);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(551, 458);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 28);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(397, 458);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 28);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(242, 458);
            this.btnFix.Margin = new System.Windows.Forms.Padding(4);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(93, 28);
            this.btnFix.TabIndex = 79;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(102, 458);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(713, 117);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 69);
            this.btnReload.TabIndex = 77;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvDETAIL
            // 
            this.dgvDETAIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDETAIL.Location = new System.Drawing.Point(78, 204);
            this.dgvDETAIL.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDETAIL.Name = "dgvDETAIL";
            this.dgvDETAIL.RowHeadersWidth = 51;
            this.dgvDETAIL.Size = new System.Drawing.Size(728, 228);
            this.dgvDETAIL.TabIndex = 76;
            this.dgvDETAIL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDETAIL_CellClick);
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 524);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvDETAIL);
            this.Name = "FrmDetail";
            this.Text = "FrmDetail";
            this.Load += new System.EventHandler(this.FrmDetail_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDETAIL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtdPrice;
        private System.Windows.Forms.TextBox txtdAmount;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txtIDI;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvDETAIL;
    }
}