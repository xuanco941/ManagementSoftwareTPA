﻿using ManagementSoftware.BUS;
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

namespace ManagementSoftware.GUI
{
    public partial class FormPurchaseOrder : Form
    {
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        // trang hiện tại
        private int page = 1;
        // tổng số trang
        private int TotalPages = 1;

        string poID = "";

        // ngày để query 
        private DateTime? timeStart = DateTime.Now.AddYears(-2).Date;
        private DateTime? timeEnd = DateTime.Now.Date;

        //condition
        private bool? status = null;

        List<PurchaseOrder> ListResults = new List<PurchaseOrder>();

        public FormPurchaseOrder()
        {
            InitializeComponent();
            TimeStart.AllowNull = false;
            TimeEnd.AllowNull = false;

            TimeStart.Value = timeStart;
            TimeEnd.Value = timeEnd;
        }



        public void AlertActive(string msg, FormAlert.enmType type)
        {
            callAlert?.Invoke(msg, type);
            LoadFormThongKe();
        }

        public void AlertActive2(string msg, FormAlert.enmType type)
        {
            callAlert?.Invoke(msg, type);
        }

        private async void LoadFormThongKe()
        {
            panelBoxSearch.Enabled = false;

            new MethodCommonGUI().CloseFormInPanel(panelMain);


            PaginationPurchaseOrder pagination = new PaginationPurchaseOrder();
            pagination.Set(page, status, timeStart, timeEnd);
            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;


            foreach (var item in ListResults)
            {
                FormItemPO form = new FormItemPO(item);
                form.changeData = new FormItemPO.ChangeData(AlertActive2);
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }


            panelBoxSearch.Enabled = true;
        }


        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            if (this.page > 1)
            {
                this.page = this.page - 1;
                LoadFormThongKe();
            }
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (this.page < this.TotalPages)
            {
                this.page = this.page + 1;
                LoadFormThongKe();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            timeStart = TimeStart.Value;
            timeEnd = TimeEnd.Value;
            LoadFormThongKe();
        }

        private void buttonGoto_Click(object sender, EventArgs e)
        {
            this.page = int.Parse(pageNumberGoto.Text);
            LoadFormThongKe();
        }

        void CheckBtnStt()
        {
            if (this.status == false)
            {
                buttonAll.ForeColor = Color.Black;
                buttonDone.ForeColor = Color.Black;
                buttonNotDone.ForeColor = Color.White;
            }
            else if (this.status == true)
            {
                buttonAll.ForeColor = Color.Black;
                buttonDone.ForeColor = Color.White;
                buttonNotDone.ForeColor = Color.Black;
            }
            else
            {
                buttonAll.ForeColor = Color.White;
                buttonDone.ForeColor = Color.Black;
                buttonNotDone.ForeColor = Color.Black;
            }
        }

        private void buttonNotDone_Click(object sender, EventArgs e)
        {

            this.status = false;
            CheckBtnStt();
            LoadFormThongKe();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.status = true;
            CheckBtnStt();
            LoadFormThongKe();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            this.status = null;
            CheckBtnStt();
            LoadFormThongKe();
        }


        private void buttonLoc_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrEmpty(textBoxtSearch.Texts) == false || textBoxtSearch.Texts != textBoxtSearch.PlaceholderText)
            {
                poID = textBoxtSearch.Texts.Trim();
                status = null;
                timeStart = DateTime.Now.AddYears(-2).Date;
                timeEnd = DateTime.Now.Date;
                TimeStart.Value = timeStart;
                TimeEnd.Value = timeEnd;
                page = 1;
                TotalPages = 1;



                panelBoxSearch.Enabled = false;

                new MethodCommonGUI().CloseFormInPanel(panelMain);


                PaginationPurchaseOrder pagination = new PaginationPurchaseOrder();
                pagination.Set2(page, status, poID);
                this.ListResults = pagination.ListResults;
                this.TotalPages = pagination.TotalPages;
                lbTotalPages.Text = this.TotalPages.ToString();

                buttonPreviousPage.Enabled = this.page > 1;
                buttonNextPage.Enabled = this.page < this.TotalPages;
                buttonPage.Text = this.page.ToString();

                pageNumberGoto.MinValue = 1;
                pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;


                foreach (var item in ListResults)
                {
                    FormItemPO form = new FormItemPO(item);
                    form.changeData = new FormItemPO.ChangeData(AlertActive2);
                    form.TopLevel = false;
                    panelMain.Controls.Add(form);
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Top;
                    form.Show();
                }


                panelBoxSearch.Enabled = true;
            }
        }

        private void FormPurchaseOrder_Load(object sender, EventArgs e)
        {
            CheckBtnStt();
            LoadFormThongKe();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddPurchaseOrder form = new FormAddPurchaseOrder();
            form.changeData = new FormAddPurchaseOrder.ChangeData(AlertActive);
            form.ShowDialog();
        }
    }

}
