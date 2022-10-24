﻿using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.Section
{
    public partial class FormItemFormViewDetailPO : Form
    {
        public FormItemFormViewDetailPO(Product product)
        {
            InitializeComponent();
            labelProductName.Text = "Tên sản phẩm : " + product.ProductName;
            labelApSuatNap.Text = "Áp suất nạp : " + product.ApSuatNap;
            labelLoaiKhi.Text = "Loại khí : " + product.LoaiKhi;
            labelChatLuongKhi.Text = "Chất lượng khí : " + product.ChatLuongKhi + "%";
            labelSoLuongSx.Text = "Số lượng sản xuất : " + product.SoLuongSanXuat;
            labelTheTichBinh.Text = "Thể tích bình : " + product.TheTichBinh;

            labelNum.Text = Common.PRODUCT + product.ProductID;
        }
    }
}