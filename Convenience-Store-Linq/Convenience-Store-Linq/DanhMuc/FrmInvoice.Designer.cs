namespace Convenience_Store_Linq.DanhMuc
{
    partial class FrmInvoice
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
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDI = new System.Windows.Forms.TextBox();
            this.txtIDE = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvINVOICE = new System.Windows.Forms.DataGridView();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.txtiDate = new System.Windows.Forms.TextBox();
            this.txtiTotal = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINVOICE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtiTotal);
            this.panel.Controls.Add(this.txtiDate);
            this.panel.Controls.Add(this.lb5);
            this.panel.Controls.Add(this.lb4);
            this.panel.Controls.Add(this.txtIDC);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txtIDI);
            this.panel.Controls.Add(this.txtIDE);
            this.panel.Controls.Add(this.lb1);
            this.panel.Controls.Add(this.lb2);
            this.panel.Location = new System.Drawing.Point(124, 55);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(647, 202);
            this.panel.TabIndex = 66;
            // 
            // txtIDC
            // 
            this.txtIDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDC.Location = new System.Drawing.Point(186, 139);
            this.txtIDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(125, 26);
            this.txtIDC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Customer:";
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
            // txtIDE
            // 
            this.txtIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDE.Location = new System.Drawing.Point(186, 87);
            this.txtIDE.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDE.Name = "txtIDE";
            this.txtIDE.Size = new System.Drawing.Size(125, 26);
            this.txtIDE.TabIndex = 3;
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
            this.lb2.Size = new System.Drawing.Size(121, 20);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "ID Employee:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(808, 65);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 70);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(759, 524);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(618, 524);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 28);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(475, 524);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 28);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFix
            // 
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(342, 524);
            this.btnFix.Margin = new System.Windows.Forms.Padding(4);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(93, 28);
            this.btnFix.TabIndex = 61;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(210, 524);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(808, 155);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 69);
            this.btnReload.TabIndex = 59;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvINVOICE
            // 
            this.dgvINVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINVOICE.Location = new System.Drawing.Point(124, 276);
            this.dgvINVOICE.Margin = new System.Windows.Forms.Padding(4);
            this.dgvINVOICE.Name = "dgvINVOICE";
            this.dgvINVOICE.RowHeadersWidth = 51;
            this.dgvINVOICE.Size = new System.Drawing.Size(777, 228);
            this.dgvINVOICE.TabIndex = 58;
            this.dgvINVOICE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvINVOICE_CellClick);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(334, 37);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(55, 20);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Date:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(334, 90);
            this.lb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(92, 20);
            this.lb5.TabIndex = 7;
            this.lb5.Text = "Total pay:";
            // 
            // txtiDate
            // 
            this.txtiDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiDate.Location = new System.Drawing.Point(429, 34);
            this.txtiDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtiDate.Name = "txtiDate";
            this.txtiDate.Size = new System.Drawing.Size(125, 26);
            this.txtiDate.TabIndex = 8;
            // 
            // txtiTotal
            // 
            this.txtiTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiTotal.Location = new System.Drawing.Point(429, 87);
            this.txtiTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtiTotal.Name = "txtiTotal";
            this.txtiTotal.Size = new System.Drawing.Size(125, 26);
            this.txtiTotal.TabIndex = 9;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 577);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvINVOICE);
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINVOICE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDI;
        private System.Windows.Forms.TextBox txtIDE;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvINVOICE;
        private System.Windows.Forms.TextBox txtiTotal;
        private System.Windows.Forms.TextBox txtiDate;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
    }
}