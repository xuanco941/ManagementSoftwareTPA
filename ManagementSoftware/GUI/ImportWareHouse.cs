using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using ManagementSoftware.DAL.DALPagination;
using ManagementSoftware.GUI.Section;
using ManagementSoftware.Models;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI
{
    public partial class ImportWareHouse : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;

        // ngày để query 
        private DateTime? timeStart = DateTime.Now.AddYears(-2).Date;
        private DateTime? timeEnd = DateTime.Now.Date;
        // trang hiện tại
        private int page = 1;

        string strSearch = "";

        // tổng số trang
        private int TotalPages = 0;
        //Data
        List<Directive> ListResults = new List<Directive>();



        public ImportWareHouse()
        {
            InitializeComponent();
        }


        private void LoadFormThongKe()
        {
            panel2.Enabled = false;

            new MethodCommonGUI().CloseFormInPanel(panelMain);

            PaginationDirectiveImportWareHouse pagination = new PaginationDirectiveImportWareHouse();
            pagination.Set(page, timeStart, timeEnd);
            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;



            for (int i = 0; i < ListResults.Count; i++)
            {
                FormChiThiNhapKho form = new FormChiThiNhapKho(ListResults[i]);
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }


            panel2.Enabled = true;
        }
        private void LoadFormThongKe2(string str)
        {
            panel2.Enabled = false;

            new MethodCommonGUI().CloseFormInPanel(panelMain);

            PaginationDirectiveImportWareHouse pagination = new PaginationDirectiveImportWareHouse();
            pagination.Set2(page, str);
            this.ListResults = pagination.ListResults;
            this.TotalPages = pagination.TotalPages;
            lbTotalPages.Text = this.TotalPages.ToString();

            buttonPreviousPage.Enabled = this.page > 1;
            buttonNextPage.Enabled = this.page < this.TotalPages;
            buttonPage.Text = this.page.ToString();

            pageNumberGoto.MinValue = 1;
            pageNumberGoto.MaxValue = this.TotalPages != 0 ? this.TotalPages : 1;



            for (int i = 0; i < ListResults.Count; i++)
            {
                FormChiThiNhapKho form = new FormChiThiNhapKho(ListResults[i]);
                form.TopLevel = false;
                panelMain.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Top;
                form.Show();
            }


            panel2.Enabled = true;
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

        private void buttonCustomLoc_Click(object sender, EventArgs e)
        {
            this.strSearch = textBoxSearch.Texts;
            if (strSearch != placeHolderText)
            {
                LoadFormThongKe2(strSearch);
            }
        }

        string placeHolderText = "";
        private void ImportWareHouse_Load(object sender, EventArgs e)
        {
            placeHolderText = textBoxSearch.PlaceholderText;
            LoadFormThongKe();
        }
    }





}
