using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //tao 1 dong du lieu
            ListViewItem it = new ListViewItem( txtLastName.Text);
            //them cac cot con lai
            it.SubItems.Add( txtFirstName.Text);
            it.SubItems.Add(txtPhone.Text);
            // dua len listview
            lv_NhanVien.Items.Add(it);
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtPhone.Text = "";
        }

        private void lv_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            // lay du lieu tu dong hien thi len cac text box
         
            if (lv_NhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_NhanVien.SelectedItems[0];

                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    txtLastName.Text = selectedItem.SubItems[0].Text;
                    txtFirstName.Text = selectedItem.SubItems[1].Text;
                    txtPhone.Text = selectedItem.SubItems[2].Text;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lv_NhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_NhanVien.SelectedItems[0];
                selectedItem.SubItems[0].Text = txtLastName.Text;
                selectedItem.SubItems[1].Text = txtFirstName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;
                MessageBox.Show("Sua thanh cong!");
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtPhone.Text = "";
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv_NhanVien.SelectedItems.Count > 0)
            {
                lv_NhanVien.Items.Remove(lv_NhanVien.SelectedItems[0]);
                MessageBox.Show("Xóa thành công!");
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtPhone.Text = "";
            }
        }

        private void lv_NhanVien_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }
    }
}
