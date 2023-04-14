﻿using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ManagementSoftware.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware
{
    public class ExportData
    {
        public void ExportResultToExcel(List<Result>? list)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel | *.xlsx | Excel 2010 | *.xls" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (var workBook = new XLWorkbook())
                            {

                                var ws = workBook.Worksheets.Add("THỐNG KÊ MẺ NẠP");

                                ws.Range(1, 1, 1, 6).Merge();
                                ws.Range(1, 1, 1, 6).Value = "THỐNG KÊ MẺ NẠP";
                                ws.Range(1, 1, 1, 6).Style.Font.Bold = true;
                                ws.Range(1, 1, 1, 6).Style.Font.FontSize = 24;
                                ws.Range(1, 1, 1, 6).Style.Fill.BackgroundColor = XLColor.Purple;
                                ws.Range(1, 1, 1, 6).Style.Font.FontColor = XLColor.White;

                                ws.Cell(2, 1).Value = "ID";
                                ws.Cell(2, 2).Value = "Loại khí";
                                ws.Cell(2, 3).Value = "Thời gian bắt đầu";
                                ws.Cell(2, 4).Value = "Thời gian kết thúc";
                                ws.Cell(2, 5).Value = "Người giám sát";
                                ws.Cell(2, 6).Value = "Trạng thái";

                                ws.Range(2, 1, 2, 6).Style.Font.Bold = true;
                                ws.Range(2, 1, 2, 6).Style.Font.FontSize = 20;
                                ws.Range(2, 1, 2, 6).Style.Fill.BackgroundColor = XLColor.Yellow;




                                for (int row = 0; row < list.Count; row++)
                                {
                                    ws.Cell(3 + row, 1).Value = Common.RESULT + list[row].ResultID;
                                    ws.Cell(3 + row, 2).Value = list[row].LoaiKhi;
                                    ws.Cell(3 + row, 3).Value = list[row].TimeStart.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                                    if (list[row].TimeStart < list[row].TimeEnd)
                                    {
                                        ws.Cell(3 + row, 4).Value = list[row].TimeEnd.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);
                                    }
                                    ws.Cell(3 + row, 5).Value = list[row].Username;
                                    ws.Cell(3 + row, 6).Value = list[row].Status == true ? "OK" : "NG"; ;

                                    if (row % 2 == 0)
                                    {
                                        ws.Range(3 + row, 1, 3 + row, 6).Style.Fill.BackgroundColor = XLColor.FromHtml("#dfe8f2");
                                    }
                                }
                                ws.Range(1, 1, 3 + list.Count, 6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Range(3, 1, 3 + list.Count, 6).Style.Font.FontSize = 18;

                                ws.Columns(1, 6).AdjustToContents();



                                string tenfile = ".xlsx";
                                workBook.SaveAs(sfd.FileName + DateTime.Now.ToString("dd_MM_yyyy_hhmmss") + tenfile);
                                MessageBox.Show("Xuất file excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            }

                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }






        public void ExportMachineOnAResultToExcel(List<Machine>? list, Result result)
        {
            if (list == null || list.Count <= 0 || result == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel | *.xlsx | Excel 2010 | *.xls" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (var workBook = new XLWorkbook())
                            {

                                var ws = workBook.Worksheets.Add($"THỐNG KÊ DỮ LIỆU MẺ NẠP {Common.RESULT + result.ResultID}");

                                //
                                ws.Range(1, 1, 1, 6).Merge();
                                ws.Range(1, 1, 1, 6).Value = "THÔNG TIN MẺ NẠP " + (Common.RESULT + result.ResultID) + "";
                                ws.Range(1, 1, 1, 6).Style.Font.Bold = true;
                                ws.Range(1, 1, 1, 6).Style.Font.FontSize = 24;
                                ws.Range(1, 1, 1, 6).Style.Fill.BackgroundColor = XLColor.Green;
                                ws.Range(1, 1, 1, 6).Style.Font.FontColor = XLColor.White;

                                ws.Range(2, 1, 2, 2).Merge();
                                ws.Range(2, 1, 2, 2).Value = "Áp suất tiêu chuẩn : " + (result.ApSuatTieuChuan ?? 0) + " Bar";
                                ws.Range(2, 3, 2, 4).Merge();
                                ws.Range(2, 3, 2, 4).Value = "Thể tích tiêu chuẩn : " + (result.TheTichTieuChuan ?? 0).ToString() + " L";
                                ws.Range(2, 5, 2, 6).Merge();
                                ws.Range(2, 5, 2, 6).Value = "Hệ số tiêu chuẩn : " + (result.HeSoTieuChuan ?? 0).ToString();


                                ws.Range(3, 3, 3, 6).Merge();
                                ws.Range(3, 3, 3, 6).Value = "Thời gian trích mẫu : " + result.ThoiGianTrichMau?.ToString("HH:mm:ss") ?? "00:00:00";

                                ws.Range(3, 1, 3, 3).Merge();
                                ws.Range(3, 1, 3, 3).Value = "Hệ số tiêu chuẩn : " + (result.HeSoTieuChuan ?? 0).ToString();
                                ws.Range(3, 3, 3, 6).Merge();
                                ws.Range(3, 3, 3, 6).Value = "Thời gian trích mẫu : " + result.ThoiGianTrichMau?.ToString("HH:mm:ss") ?? "00:00:00";




                                //





                                ws.Range(1, 1, 1, 6).Merge();
                                ws.Range(1, 1, 1, 6).Value = $"THỐNG KÊ DỮ LIỆU MẺ NẠP {Common.RESULT + result.ResultID}";
                                ws.Range(1, 1, 1, 6).Style.Font.Bold = true;
                                ws.Range(1, 1, 1, 6).Style.Font.FontSize = 24;
                                ws.Range(1, 1, 1, 6).Style.Fill.BackgroundColor = XLColor.Green;
                                ws.Range(1, 1, 1, 6).Style.Font.FontColor = XLColor.White;






                                ws.Cell(2, 1).Value = "Stt";
                                ws.Cell(2, 2).Value = "Tên giàn";
                                ws.Cell(2, 3).Value = "Áp suất tổng (bar)";
                                ws.Cell(2, 4).Value = "Áp suất (bar)";
                                ws.Cell(2, 5).Value = "Thể tích (l)";
                                ws.Cell(2, 6).Value = "Thời điểm";

                                ws.Range(2, 1, 2, 6).Style.Font.Bold = true;
                                ws.Range(2, 1, 2, 6).Style.Font.FontSize = 20;
                                ws.Range(2, 1, 2, 6).Style.Fill.BackgroundColor = XLColor.LightGreen;




                                for (int row = 0; row < list.Count; row++)
                                {
                                    ws.Cell(3 + row, 1).Value = row + 1;
                                    ws.Cell(3 + row, 2).Value = list[row].NameMachine;
                                    ws.Cell(3 + row, 3).Value = list[row].ApSuatTong;
                                    ws.Cell(3 + row, 4).Value = list[row].ApSuat;
                                    ws.Cell(3 + row, 5).Value = list[row].TheTich;
                                    ws.Cell(3 + row, 6).Value = list[row].CreateAt.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);

                                    if (row % 2 == 0)
                                    {
                                        ws.Range(3 + row, 1, 3 + row, 6).Style.Fill.BackgroundColor = XLColor.FromHtml("#dfe8f2");
                                    }
                                }


                                ws.Range(1, 1, 3 + list.Count, 6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Range(3, 1, 3 + list.Count, 6).Style.Font.FontSize = 18;

                                ws.Columns(1, 6).AdjustToContents();

                                string tenfile = ".xlsx";
                                workBook.SaveAs(sfd.FileName + DateTime.Now.ToString("dd_MM_yyyy_hhmmss") + tenfile);
                                MessageBox.Show("Xuất file excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            }

                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }







    }
}