﻿using ManagementSoftware.BUS;
using ManagementSoftware.DAL;
using ManagementSoftware.GUI.WorkingListManagement;
using ManagementSoftware.Models;
using Syncfusion.Windows.Forms.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.ImportWareHouseManagement
{
    public partial class FormNhapKho : Form
    {
        Directive directive;
        public FormNhapKho(Directive d)
        {
            InitializeComponent();
            this.directive = d;

            labelHeader.Text = "Chỉ thị " + Common.DIRECTIVE + directive.DirectiveID;
            labelMaChiThi.Text = "Mã chỉ thị : " + Common.DIRECTIVE + directive.DirectiveID;
            labelMaSanPham.Text = "Thuộc mã sản phẩm : " + Common.PRODUCT + directive.Product.ProductID;
            labelNguoiVanHanh.Text = "Người thực hiện : " + BUSUser.GetUserFromUsername(directive.Worker)?.FullName + $"({directive.Worker})";
            labelSoLuongCanSX.Text = "Số lượng cần sản xuất : " + directive.SoLuongCanSanXuat;
            labelSoLuongDaSX.Text = "Số lượng đã sản xuất : " + directive.SoLuongDaSanXuat;
            labelBatDauNgay.Text = "Bắt đầu ngày : " + directive.BeginAt.ToString("dd/MM/yyyy");
            labelKetThucNgay.Text = "Kết thúc ngày : " + directive.EndAt.ToString("dd/MM/yyyy");
            labelSoLuongDaNhapKho.Text = "Số lượng đã nhập kho : " + BUSImportedWareHouse.GetImportedWareHouseOfDirective(directive.DirectiveID) + "/" + directive.SoLuongDaSanXuat;

            NgayNhap.Value = DateTime.Now;
            txtNguoiNhap.Text = Common.USERSESSION?.FullName ?? "";



            sfBarcode1.Symbology = BarcodeSymbolType.Code128B;
            sfBarcode1.TextGapHeight = 5;

        }

        private void LoadDGV()
        {

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID", SortMode = DataGridViewColumnSortMode.NotSortable });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Người nhập", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Ngày nhập", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Số lượng nhập", SortMode = DataGridViewColumnSortMode.NotSortable });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Mã barcode", SortMode = DataGridViewColumnSortMode.NotSortable });





            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ReadOnly = true;

            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;





        }

        List<ImportedWarehouse>? l = new List<ImportedWarehouse>();

        void LoadFormThongKe()
        {

            dataGridView1.Rows.Clear();

            List<string> strings = new List<string>() { "Tạo đơn mới" };
            l = new DALImportedWareHouse().GetAllImportedWareHousesFromIDDirective(directive.DirectiveID);
            if (l != null && l.Count > 0)
            {
                List<string> st = l.Select(a => Common.IMPORTED_WAREHOUSE + a.ImportedWarehouseID).ToList();
                strings.AddRange(st);


                int soluongMax = directive.SoLuongDaSanXuat - l.Sum(p => p.Amount);
                if (soluongMax <= 0)
                {
                    soluongMax = 0;
                    buttonConfirm.Enabled = false;
                }
                if (soluongMax > 0)
                {
                    buttonConfirm.Enabled = true;
                }
                labelSLNhap.Text = $"Số lượng nhập (tối đa thêm {soluongMax}) :";
                txtSoLuongNhap.MaxValue = soluongMax;

                foreach (var item in l)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells[0].Value = Common.IMPORTED_WAREHOUSE + item.ImportedWarehouseID;

                    row.Cells[1].Value = item.Importer;
                    row.Cells[2].Value = item.DateAdded.ToString($"dd/MM/yyyy", CultureInfo.InvariantCulture);
                    row.Cells[3].Value = item.Amount;
                    row.Cells[4].Value = item.BarCode;

                }

            }
            comboBoxDonNhapKho.DataSource = new List<string>() { "Tạo đơn mới" };
            comboBoxDonNhapKho.DataSource = strings;
            buttonDelete.Enabled = false;







        }

        private void FormNhapKho_Load(object sender, EventArgs e)
        {
            LoadDGV();
            LoadFormThongKe();
        }

        private void comboBoxDonNhapKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDonNhapKho.Text == "Tạo đơn mới")
            {
                buttonDelete.Enabled = false;
                sfBarcode1.Text = "";
                txtNguoiNhap.Text = Common.USERSESSION.FullName;
                txtSoLuongNhap.IntegerValue = directive.SoLuongDaSanXuat - l.Sum(a => a.Amount);
                NgayNhap.Value = DateTime.Now;
                buttonDelete.Enabled = false;
            }
            else
            {
                int id = int.Parse(comboBoxDonNhapKho.Text.Replace(Common.IMPORTED_WAREHOUSE, ""));
                if (l != null)
                {
                    var obj = l.FirstOrDefault(a => a.ImportedWarehouseID == id);
                    if (obj != null)
                    {
                        sfBarcode1.Text = obj.BarCode;
                        txtNguoiNhap.Text = obj.Importer;
                        int x = directive.SoLuongDaSanXuat - l.Sum(a => a.Amount);
                        txtSoLuongNhap.MaxValue = obj.Amount + x;

                        txtSoLuongNhap.IntegerValue = obj.Amount;

                        NgayNhap.Value = obj.DateAdded;
                        buttonDelete.Enabled = true;
                    }
                    else
                    {
                        sfBarcode1.Text = "";
                        txtNguoiNhap.Text = Common.USERSESSION.FullName;
                        txtSoLuongNhap.IntegerValue = directive.SoLuongDaSanXuat - l.Sum(a => a.Amount);
                        NgayNhap.Value = DateTime.Now;
                        buttonDelete.Enabled = false;
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxDonNhapKho.Text != "Tạo đơn mới")
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa đơn nhập kho này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(comboBoxDonNhapKho.Text.Replace(Common.IMPORTED_WAREHOUSE, ""));
                    DALImportedWareHouse.Delete(id);
                    LoadFormThongKe();
                }
            }

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                buttonConfirm.Enabled = false;
                string nguoiNhap = txtNguoiNhap.Text;
                DateTime? ngay = NgayNhap.Value;
                int sl = (int)txtSoLuongNhap.IntegerValue;
                if (comboBoxDonNhapKho.Text == "Tạo đơn mới")
                {
                    if (String.IsNullOrEmpty(nguoiNhap) == false && ngay != null && sl != 0)
                    {
                        ImportedWarehouse obj = new ImportedWarehouse();
                        obj.Importer = nguoiNhap;
                        obj.DateAdded = ngay.Value;
                        obj.Amount = sl;
                        obj.DirectiveID = directive.DirectiveID;
                        new DALImportedWareHouse().Add(obj, directive);
                    }
                    else
                    {
                        MessageBox.Show("Cần nhập đúng dữ liệu.", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    int id = int.Parse(comboBoxDonNhapKho.Text.Replace(Common.IMPORTED_WAREHOUSE, ""));
                    ImportedWarehouse importedWarehouse = new ImportedWarehouse();
                    importedWarehouse.Importer = nguoiNhap;
                    importedWarehouse.DateAdded = ngay.Value;
                    importedWarehouse.Amount = sl;
                    importedWarehouse.ImportedWarehouseID = id;
                    importedWarehouse.BarCode = sfBarcode1.Text;

                    DALImportedWareHouse.Update(importedWarehouse);
                }
                LoadFormThongKe();
                buttonConfirm.Enabled = true;
            }
            catch
            {

            }

        }
    }
}
