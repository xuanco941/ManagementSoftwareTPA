using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSoftware.GUI.Section;
using Syncfusion.XPS;


namespace ManagementSoftware.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //fullscreen
            this.WindowState = FormWindowState.Maximized;
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
            panelAleart.Controls.Add(frm);
        }


        public void SetLabelHeaderUserPLC()
        {
            //if (this.IsHandleCreated && this.InvokeRequired)
            //{
            //    this.BeginInvoke(() => SetLabelHeaderUserPLC());
            //    return;
            //}
            labelHeaderUserPLC.Text = "Tài khoản PLC: " + (Common.UserCurrent?.Username ?? "");
        }



        private void ChangeForm(Form form, object sender)
        {
            panelItemMenu.Enabled = false;
            //focus button
            Button button = sender as Button;

            foreach (Control control in panelItemMenu.Controls)
            {
                control.BackColor = Color.FromArgb(41, 44, 51);
                if (control.Text == button.Text)
                {
                    control.BackColor = Color.FromArgb(69, 73, 82);
                }
            }


            new MethodCommonGUI().CloseFormInPanel(panelContent);

            //set new content
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();

            panelItemMenu.Enabled = true;

        }






        private void ChangeFormContent(Form form, object sender)
        {
            //focus button
            Button button = sender as Button;

            foreach (Control control in panelItemMenu.Controls)
            {
                control.BackColor = Color.FromArgb(41, 44, 51);
                if (control.Text == button.Text)
                {
                    control.BackColor = Color.FromArgb(69, 73, 82);
                }
            }


            new MethodCommonGUI().CloseFormInPanel(panelContent);

            //set new content
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();

        }


        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard(plc);
            //ChangeFormContent(form, sender);
            ChangeForm(form, sender);
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            ResultHistory form = new ResultHistory();
            //ChangeFormContent(form, sender);
            ChangeForm(form, sender);
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.callAlert = new Employee.CallAlert(Alert);
            //ChangeFormContent(form, sender);
            ChangeForm(form, sender);
        }

        private void buttonActivity_Click(object sender, EventArgs e)
        {
            ActivityHistory form = new ActivityHistory();
            form.callAlert = new ActivityHistory.CallAlert(Alert);
            //ChangeFormContent(form, sender);
            ChangeForm(form, sender);
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help form = new Help();
            //ChangeFormContent(form, sender);
            ChangeForm(form, sender);
        }

        private void buttonUserWorking_Click(object sender, EventArgs e)
        {
            LichSuDangNhap form = new LichSuDangNhap();
            //ChangeFormContent(form, sender);
            ChangeForm(form, sender);
        }

        private async void buttonDangXuat_Click(object sender, EventArgs e)
        {


            List<Form> oldForms = new List<Form>();
            foreach (Form oldForm in panelContent.Controls)
            {
                oldForms.Add(oldForm);
            }

            // Đóng/loại bỏ các FormItemPO cũ khỏi panelMain.Controls
            foreach (Form oldForm in oldForms)
            {
                oldForm.Close();
                oldForm.Dispose();
            }


            await Task.Run(() => plc.WriteAVariableNumber(AddressPLC.DATA_PC_Trang_Thai_PC, false));

            Common.USERSESSION = null;

            Application.Restart();
        }
















        PLCBeckhOff plc = new PLCBeckhOff();




        private async void Main_Load(object sender, EventArgs e)
        {

            if (Common.USERSESSION != null && Common.USERSESSION.Group != null && Common.USERSESSION.Group.IsManagementUser == false)
            {
                buttonEmployee.Enabled = false;
            }

            Hello form = new Hello();
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Font = Common.FontForm;

            labelHeaderUserPC.Text = "Tài khoản PC: " + (Common.USERSESSION?.Username ?? "");
            labelHeaderUserPLC.Text = "Tài khoản PLC: " + (Common.UserCurrent?.Username ?? "");

            bool? con = await Task.Run(() => plc.Connect());
            if(con!=null && con == true)
            {
                await Task.Run(() => plc.WriteAVariableNumber(AddressPLC.DATA_PC_Trang_Thai_PC, true));
                Alert("Kết nối tới PLC thành công.", FormAlert.enmType.Success);
            }
            else
            {
                Alert("Kết nối tới PLC thất bại.", FormAlert.enmType.Error);
            }

        }



        private async void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            await Task.Run(() => plc.WriteAVariableNumber(AddressPLC.DATA_PC_Trang_Thai_PC, false));
            new MethodCommonGUI().CloseFormInPanel(panelContent);

            Common.USERSESSION = null;

            Application.ExitThread();


        }


    }
}
