using Convenience_Store_Linq.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convenience_Store_Linq.DanhMuc
{
    public partial class FrmProduct : Form
    {
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLProduct dbMA = new BLProduct();
        public FrmProduct()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView
                dgvPRODUCT.DataSource = dbMA.TakeProduct();
                // Thay đổi độ rộng cột
                dgvPRODUCT.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtIDP.ResetText();
                this.txtIDT.ResetText();
                this.txtIDB.ResetText();
                this.txtName.ResetText();
                this.txtPrice.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnFix.Enabled = true;
                this.btnDelete.Enabled = true;

                //
                dgvPRODUCT_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table PRODUCT. Lỗi rồi!!!");
            }
        }
        private void dgvPRODUCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvPRODUCT.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtIDP.Text = dgvPRODUCT.Rows[r].Cells[0].Value.ToString();
            this.txtName.Text = dgvPRODUCT.Rows[r].Cells[1].Value.ToString();
            this.txtPrice.Text = dgvPRODUCT.Rows[r].Cells[2].Value.ToString();
            this.txtIDT.Text = dgvPRODUCT.Rows[r].Cells[3].Value.ToString();
            this.txtIDB.Text = dgvPRODUCT.Rows[r].Cells[4].Value.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtIDP.Enabled = true;

            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtIDP.ResetText();
            this.txtIDT.ResetText();
            this.txtIDB.ResetText();
            this.txtName.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtsID
            this.txtIDP.Focus();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvPRODUCT_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnFix.Enabled = false;
            this.btnDelete.Enabled = false;

            // Đưa con trỏ đến TextField txtIDP
            this.txtIDP.Enabled = false;
            this.txtIDB.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLProduct blSup = new BLProduct();
                    blSup.AddProduct(this.txtIDP.Text, this.txtName.Text, float.Parse(this.txtPrice.Text), this.txtIDT.Text, this.txtIDB.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLProduct blSup = new BLProduct();
                blSup.UpdateProduct(this.txtIDP.Text, this.txtName.Text, float.Parse(this.txtPrice.Text), this.txtIDT.Text, this.txtIDB.Text, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtIDP.ResetText();
            this.txtIDT.ResetText();
            this.txtIDB.ResetText();
            this.txtName.ResetText();
            this.txtPrice.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnFix.Enabled = true;
            this.btnDelete.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.panel.Enabled = false;
            dgvPRODUCT_CellClick(null, null);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvPRODUCT.CurrentCell.RowIndex;
                string strMA1 = dgvPRODUCT.Rows[r].Cells[0].Value.ToString();
                string strMA2 = dgvPRODUCT.Rows[r].Cells[3].Value.ToString();
                string strMA3 = dgvPRODUCT.Rows[r].Cells[4].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbMA.DeleteProduct(ref err, strMA1, strMA2, strMA3);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
            int foreignKeyColumnIndex1 = dgvPRODUCT.Columns["Stock"].Index;
            int foreignKeyColumnIndex2 = dgvPRODUCT.Columns["Type"].Index;
            dgvPRODUCT.Columns[foreignKeyColumnIndex1].Visible = false;
            dgvPRODUCT.Columns[foreignKeyColumnIndex2].Visible = false;
        }
    }
}
