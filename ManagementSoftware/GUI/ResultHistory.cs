using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ManagementSoftware.GUI.Section;

namespace ManagementSoftware.GUI
{
    public partial class ResultHistory : Form
    {
        // Aleart
        public delegate void CallAlert(string msg, FormAlert.enmType type);
        public CallAlert callAlert;


        //var name query tất cả
        private const string allMachine = "Tất cả";


        //query 
        private string time1 = null;
        private string time2 = null;
        private string nameMachine = allMachine;

        private bool checkApSuat = false;
        private double apSuat1 = 0;
        private double apSuat2 = 0;

        private bool checkTheTich = false;
        private double theTich1 = 0;
        private double theTich2 = 0;

        private bool checkLuuLuong = false;
        private double luuLuong1 = 0;
        private double luuLuong2 = 0;

        // trang hiện tại
        private int page = 1;
        // tổng số trang
        private int pageSize = 1;


        public ResultHistory()
        {
            InitializeComponent();

            buttonExcel.ForeColor = Color.Black;
            buttonExcel.Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);

            buttonPrint.ForeColor = Color.Black;
            buttonPrint.Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);

            dataGridViewResult.RowTemplate.Height = 45;
        }

    }

    //METHOD




}
