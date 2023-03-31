using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware.GUI
{
    internal class MethodCommonGUI
    {
        public void CloseFormInPanel(Panel panel)
        {
            List<Form> oldForms = new List<Form>();
            foreach (Form oldForm in panel.Controls)
            {
                oldForms.Add(oldForm);
            }

            // Đóng/loại bỏ các FormItemPO cũ khỏi panelMain.Controls
            foreach (Form oldForm in oldForms)
            {
                oldForm.Close();
                oldForm.Dispose();
            }
        }



        public void ShowFormOnPanel(Panel panel, Form form)
        {
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        public void ShowFormOnTabPage(TabPage tabPage, Form form)
        {
            form.TopLevel = false;
            tabPage.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
