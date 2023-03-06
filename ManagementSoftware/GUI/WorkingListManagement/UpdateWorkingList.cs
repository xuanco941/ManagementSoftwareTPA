using Azure;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.WorkingListManagement
{
    public partial class UpdateWorkingList : Form
    {
        int id = 0;
        Directive? directive = null;
        public UpdateWorkingList(string idDirective)
        {
            InitializeComponent();
            id = int.Parse(idDirective.Replace(Common.DIRECTIVE, ""));
            labelCT.Text = labelCT.Text + " " + idDirective;

            comboBoxStatus.DataSource = new List<string>() { "Đã hoàn thành", "Chưa hoàn thành" };

            TenSP.Enabled = false;
            ApSuatNap.Enabled = false;
            TheTichBinh.Enabled = false;
            ChatLuongKhi.Enabled = false;
        }

        private void UpdateWorkingList_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                directive = new DALDirective().GetDirectiveFromID(id);
                if (directive != null)
                {
                    TenSP.Text = directive.Product.ProductName;
                    ApSuatNap.Text = directive.Product.ApSuatNap.ToString();
                    TheTichBinh.Text = directive.Product.TheTichBinh.ToString();
                    ChatLuongKhi.Text = directive.Product.ChatLuongKhi.ToString();
                    SLCanSX.Text = directive.SoLuongCanSanXuat.ToString();
                    SLDaSX.Text = directive.SoLuongDaSanXuat.ToString();
                    BeginAt.Value = directive.BeginAt;
                    EndAt.Value = directive.EndAt;

                    if (directive.Status == true)
                    {
                        comboBoxStatus.Text = "Đã hoàn thành";
                    }
                    else
                    {
                        comboBoxStatus.Text = "Chưa hoàn thành";
                    }

                }
            }
        }

        // Define delegate
        public delegate void ChangeData(string msg, FormAlert.enmType enmType);

        // Create instance (null)
        public ChangeData changeData;

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string slCanSX = SLCanSX.Text;
            string slDaSX = SLDaSX.Text;
            DateTime begin = BeginAt.Value;
            DateTime end = EndAt.Value;
            string stt = comboBoxStatus.Text;

            int SLCanSXInt;
            int SLDaSXInt;

            if (int.TryParse(slCanSX, out SLCanSXInt) == true && int.TryParse(slDaSX, out SLDaSXInt) == true && String.IsNullOrEmpty(stt) == false && directive != null)
            {
                directive.SoLuongCanSanXuat = SLCanSXInt;
                directive.SoLuongDaSanXuat = SLDaSXInt;
                directive.BeginAt = begin;
                directive.EndAt = end;

                if (comboBoxStatus.Text == "Đã hoàn thành")
                {
                    directive.Status = true;
                }
                else
                {
                    directive.Status = false;
                }

                if (DALDirective.Update(directive) > 0)
                {
                    SLCanSX.Text = directive.SoLuongCanSanXuat.ToString();
                    SLDaSX.Text = directive.SoLuongDaSanXuat.ToString();
                    BeginAt.Value = directive.BeginAt;
                    EndAt.Value = directive.EndAt;

                    if (directive.Status == true)
                    {
                        comboBoxStatus.Text = "Đã hoàn thành";
                    }
                    else
                    {
                        comboBoxStatus.Text = "Chưa hoàn thành";
                    }
                    changeData?.Invoke($"Cập nhật thành công.", FormAlert.enmType.Success);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật, lỗi.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể cập nhật, hãy điền thông tin chính xác.", "Lỗi Cú Pháp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
