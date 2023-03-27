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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace ManagementSoftware.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //fullscreen
            this.WindowState = FormWindowState.Maximized;
            dateTimeNow = DateTime.Now;
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
            panelAleart.Controls.Add(frm);
        }





        private void ChangeForm(Form form, object sender)
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






        private void ChangeFormContent(Form form, object sender)
        {
            //focus button
            Button button = sender as Button;

            labelHeader.Text = button.Text;
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
            Dashboard form = new Dashboard();
            //ChangeFormContent(form, sender);
            ChangeForm(form, sender);
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            ResultHistory form = new ResultHistory();
            form.callAlert = new ResultHistory.CallAlert(Alert);
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

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Common.USERSESSION = null;

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

            this.Close();
            Application.ExitThread();
        }















        int TIME_INTERVAL_IN_MILLISECONDS = 500;


        System.Threading.Timer timer = null;

        DateTime dateTimeNow;
        void ChangeTime()
        {
            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(() => ChangeTime());
                return;
            }

            labelHeader.Text = "Xin chào, " + (Common.USERSESSION?.Username ?? "") + " (" + (DateTime.Now - dateTimeNow).ToString("hh\\:mm\\:ss") + ")";
        }

        private void CallBack(object obj)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();


            // update data
            // Long running operation
            ChangeTime();


            if (timer != null)
            {
                timer.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }






        private void Main_Load(object sender, EventArgs e)
        {
            Hello form = new Hello();
            form.TopLevel = false;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            this.Font = Common.FontForm;


            timer = new System.Threading.Timer(CallBack, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);
        }




        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                this.timer.Change(Timeout.Infinite, Timeout.Infinite);
                timer.Dispose();
                timer = null;
            }
            new MethodCommonGUI().CloseFormInPanel(panelContent);

        }
    }
}
