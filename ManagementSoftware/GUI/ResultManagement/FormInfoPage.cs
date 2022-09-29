using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.GUI.Section;

namespace ManagementSoftware.GUI.ResultManagement
{
    public partial class FormInfoPage : Form
    {
        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);

        // Create instance (null)
        public ChangeData changeData;
        public FormInfoPage(string nameMachine, string time1, string time2, bool checkApSuat, bool checkTheTich, bool checkLuuLuong, 
            double apSuat1, double apSuat2, double theTich1, double theTich2, double luuLuong1, double luuLuong2, int page, int pageSize)
        {
            InitializeComponent();

            //set lebel
            labelNameMachine.Text = "- Loại máy: "+ nameMachine+".";

            //
            if (time1 != null && time2 != null)
            {
                string[] arr1 = time1.Split('-');
                string[] arr2 = time2.Split('-');
                string infoTuNgay = arr1[2] + "-" + arr1[1] + "-" + arr1[0];
                string infoToiNgay = (int.Parse(arr2[2]) - 1) + "-" + arr2[1] + "-" + arr2[0];
                labelTuNgay.Text = "- Từ ngày: " + infoTuNgay + ".";
                labelToiNgay.Text = "- Tới ngày: " + infoToiNgay + ".";
            }
            else
            {
                labelTuNgay.Text = "- Từ ngày: trống.";
                labelToiNgay.Text = "- Tới ngày: trống.";
            }

            if (checkApSuat == true)
            {
                labelApSuat.Text = $"- Áp suất: từ {apSuat1} đến {apSuat2}.";
            }
            if (checkTheTich == true)
            {
                labelTheTich.Text = $"- Thể tích: từ {theTich1} đến {theTich2}.";
            }
            if (checkLuuLuong == true)
            {
                labelLuuLuong.Text = $"- Lưu lượng: từ {luuLuong1} đến {luuLuong2}.";
            }



            labelBanGhiMoiTrang.Text = "- Tổng số trang: " + pageSize + ".";
            labelTongSoTrang.Text = "- Số dòng tối đa mỗi trang: " + Common.NumberRows + ".";
            labelPage.Text = "- Đang ở trang: " + page + ".";
        }

        private void ChangeNumElm()
        {
            if (!String.IsNullOrEmpty(textBoxNumElm.Texts) && textBoxNumElm.Texts != textBoxNumElm.PlaceholderText && int.Parse(textBoxNumElm.Texts) > 0)
            {
                Common.NumberRows = int.Parse(textBoxNumElm.Texts);
                changeData.Invoke("Cập nhật số dòng hiển thị trang lịch sử nạp là: " + textBoxNumElm.Texts +".", FormAlert.enmType.Success);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ nhập số.", "Cú pháp sai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxNumElm_KeyPress(object sender, KeyPressEventArgs e)
        {
            LW_PhanMemBaoGia.MyControls.TextBoxT textBoxT = sender as LW_PhanMemBaoGia.MyControls.TextBoxT;
            //textbox only number 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //giới hạn length cho text box là 3
            if (textBoxT.Texts.Length > 3)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
        }

        private void textBoxNumElm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeNumElm();
            }
        }

        private void buttonSaveSetting_Click(object sender, EventArgs e)
        {
            ChangeNumElm();
        }
    }
}
