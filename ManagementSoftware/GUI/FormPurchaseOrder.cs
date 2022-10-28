using ManagementSoftware.BUS;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.GUI.PurchaseOrderManagement;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ManagementSoftware.GUI.Section.FormAlert;

namespace ManagementSoftware.GUI
{
    public partial class FormPurchaseOrder : Form
    {
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        public delegate void ChangeFormMain(Form form, string header);
        public ChangeFormMain changeFormMain;

        // trang hiện tại
        private int page = 1;
        // tổng số trang
        private int TotalPages = 1;

        //condition
        private bool? status = null;


        private void LoadForm(string? poID)
        {

            PaginationPurchaseOrder pagination = BUSPurchaseOrder.GetData(this.page, this.status, poID);
            List<PurchaseOrder>? list = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            if (list != null)
            {
                if (this.TotalPages == 0)
                {
                    buttonPage1.Enabled = false;
                    buttonPage2.Enabled = false;
                    buttonPage3.Enabled = false;
                    buttonPageNext.Enabled = false;
                }
                else if (this.TotalPages == 1)
                {
                    buttonPage1.Enabled = true;
                    buttonPage2.Enabled = false;
                    buttonPage3.Enabled = false;
                    buttonPageNext.Enabled = false;
                }
                else if (this.TotalPages == 2)
                {
                    buttonPage1.Enabled = true;
                    buttonPage2.Enabled = true;
                    buttonPage3.Enabled = false;
                    buttonPageNext.Enabled = false;
                }
                else if (this.TotalPages == 3)
                {
                    buttonPage1.Enabled = true;
                    buttonPage2.Enabled = true;
                    buttonPage3.Enabled = true;
                    buttonPageNext.Enabled = false;
                }
                else
                {
                    buttonPage1.Enabled = true;
                    buttonPage2.Enabled = true;
                    buttonPage3.Enabled = true;
                    buttonPageNext.Enabled = true;
                }

                panelMain.Controls.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    FormItemPO form = new FormItemPO(list[i]);
                    form.changeData = new FormItemPO.ChangeData(AlertActive2);
                    form.changeFormMain = new FormItemPO.ChangeFormMain(ChangeForm);
                    form.TopLevel = false;
                    panelMain.Controls.Add(form);
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Top;
                    form.Show();
                }
            }
        }

        void ChangeForm(Form form, string header)
        {
            this.Close();   
            this.changeFormMain?.Invoke(form,header);
        }


        public FormPurchaseOrder()
        {
            InitializeComponent();
            LoadForm(null);
        }

        public void AlertActive2(string msg, FormAlert.enmType type)
        {
            callAlert?.Invoke(msg, type);
            LoadForm(null);
        }

        public void AlertActive(string msg, FormAlert.enmType type)
        {
            callAlert?.Invoke(msg, type);
            //load lai data
            this.page = 1;
            this.status = null;
            this.TotalPages = 1;
            buttonPage1.Text = 1.ToString();
            buttonPage2.Text = 2.ToString();
            buttonPage3.Text = 3.ToString();
            LoadForm(null);
        }


        private void addPO_Click(object sender, EventArgs e)
        {
            FormAddPurchaseOrder form = new FormAddPurchaseOrder();
            form.changeData = new FormAddPurchaseOrder.ChangeData(AlertActive);
            form.ShowDialog();
        }

        private void buttonNotDone_Click(object sender, EventArgs e)
        {
            this.page = 1;
            this.status = false;
            this.TotalPages = 1;
            buttonPage1.Text = 1.ToString();
            buttonPage2.Text = 2.ToString();
            buttonPage3.Text = 3.ToString();
            LoadForm(null);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.page = 1;
            this.status = true;
            this.TotalPages = 1;
            buttonPage1.Text = 1.ToString();
            buttonPage2.Text = 2.ToString();
            buttonPage3.Text = 3.ToString();
            LoadForm(null);
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            this.page = 1;
            this.status = null;
            this.TotalPages = 1;
            buttonPage1.Text = 1.ToString();
            buttonPage2.Text = 2.ToString();
            buttonPage3.Text = 3.ToString();
            LoadForm(null);
        }

        private void buttonPage1_Click(object sender, EventArgs e)
        {
            // select button trang
            Button button = sender as Button;

            if (this.page > this.TotalPages)
            {
                this.page = this.TotalPages;
            }
            else
            {
                this.page = int.Parse(button.Text);
                if (this.page <= 2)
                {
                    buttonPage1.Text = 1.ToString();
                    buttonPage2.Text = 2.ToString();
                    buttonPage3.Text = 3.ToString();
                }
                else
                {
                    buttonPage1.Text = (page - 1).ToString();
                    buttonPage2.Text = page.ToString();
                    buttonPage3.Text = (page + 1).ToString();
                    //nếu tràng hiện tại là trang cuối cùng thì đặt các nút là các những trang cuối
                    if (this.page == this.TotalPages)
                    {
                        buttonPage1.Text = (page - 2).ToString();
                        buttonPage2.Text = (page - 1).ToString();
                        buttonPage3.Text = page.ToString();
                    }
                }
            }
            LoadForm(null);

        }

        private void buttonPageNext_Click(object sender, EventArgs e)
        {
            if (this.page == this.TotalPages)
            {
                callAlert?.Invoke("Bạn đang ở trang cuối cùng.", FormAlert.enmType.Info);
            }
            else
            {
                // bấm next sẽ là trang số ở button3 + 1
                int numPageButton3 = int.Parse(buttonPage3.Text);
                if (numPageButton3 < this.TotalPages)
                {
                    if (this.page == 1)
                    {
                        this.page = 3;
                        buttonPage1.Text = 2.ToString();
                        buttonPage2.Text = 3.ToString();
                        buttonPage3.Text = 4.ToString();
                    }
                    else
                    {
                        this.page = numPageButton3 + 1;
                        //set lại button 1,2,3 
                        if (this.page == this.TotalPages)
                        {
                            buttonPage1.Text = (this.page - 2).ToString();
                            buttonPage2.Text = (this.page - 1).ToString();
                            buttonPage3.Text = (this.page).ToString();
                        }
                        if (this.page + 1 <= this.TotalPages)
                        {
                            buttonPage1.Text = (this.page - 1).ToString();
                            buttonPage2.Text = (this.page).ToString();
                            buttonPage3.Text = (this.page + 1).ToString();
                        }
                        if (this.page + 2 <= this.TotalPages)
                        {
                            buttonPage1.Text = (this.page).ToString();
                            buttonPage2.Text = (this.page + 1).ToString();
                            buttonPage3.Text = (this.page + 2).ToString();
                        }
                    }


                }
                else
                {
                    this.page = this.TotalPages;
                }
                LoadForm(null);
            }
        }

        private void buttonCustom3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSearchPO.Texts) == true || textBoxSearchPO.Texts == textBoxSearchPO.PlaceholderText)
            {
                LoadForm(null);
            }
            else
            {
                LoadForm(textBoxSearchPO.Texts);
            }
        }
    }
}
