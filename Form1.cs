using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12_Listbox_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstNames.Items.Add(txtName.Text);
            txtName.Text = "";
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn tên trong danh sách", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                lstNames.Items[lstNames.SelectedIndex] = txtName.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstNames.Items.Add("TP HCM");
            lstNames.Items.Add("TP HCM");
            lstNames.Items.Add("TP HCM");
            lstNames.Items.Add("TP HCM");
            lstNames.Items.Add("TP HCM");
            lstNames.Items.Add("TP HCM");
            lstNames.Items.Add("TP HCM");
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex < 0)
            {
                return;
            }
            txtName.Text = lstNames.Items[lstNames.SelectedIndex].ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex > 0)
            {
                lstNames.Items.RemoveAt(lstNames.SelectedIndex);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Index sẽ lấy từ txtInder
            //Value sẽ lấy từ txtName
            //lstNames.Items.Insert(Convert.ToInt32(txtSelect.Text), txtName.Text);
            MessageBox.Show(lstNames.SelectedIndex.ToString());
            if (lstNames.SelectedIndex >= 0)
            {
                lstNames.Items.Insert(lstNames.SelectedIndex, txtName.Text);
            }

        }
    }
}
