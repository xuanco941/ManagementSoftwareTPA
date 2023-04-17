using ClosedXML.Excel;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using ManagementSoftware.Models;
using Org.BouncyCastle.Crypto.IO;
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
        public async void ExportResultToExcel(List<Result>? list)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx|Excel 2010|*.xls" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                using (var workBook = new XLWorkbook())
                                {

                                    var ws = workBook.Worksheets.Add("THỐNG KÊ MẺ NẠP");

                                    ws.Range(1, 1, 1, 6).Merge();
                                    ws.Range(1, 1, 1, 6).Value = "THỐNG KÊ MẺ NẠP";
                                    ws.Range(1, 1, 1, 6).Style.Font.Bold = true;
                                    ws.Range(1, 1, 1, 6).Style.Font.FontSize = 24;
                                    ws.Range(1, 1, 1, 6).Style.Fill.BackgroundColor = XLColor.DarkSlateBlue;
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


                                    workBook.SaveAs(sfd.FileName);
                                }
                            });
                            MessageBox.Show("Xuất file thống kê mẻ nạp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }






        public async void ExportMachineOnAResultToExcel(List<Machine>? list, Result result)
        {
            if (list == null || list.Count <= 0 || result == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx|Excel 2010|*.xls" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                using (var workBook = new XLWorkbook())
                                {

                                    var ws = workBook.Worksheets.Add($"THỐNG KÊ DỮ LIỆU MẺ NẠP {Common.RESULT + result.ResultID}");

                                    //
                                    ws.Range(1, 1, 1, 6).Merge();
                                    ws.Range(1, 1, 1, 6).Value = "THÔNG TIN MẺ NẠP " + (Common.RESULT + result.ResultID) + "";
                                    ws.Range(1, 1, 1, 6).Style.Font.Bold = true;
                                    ws.Range(1, 1, 1, 6).Style.Font.FontSize = 24;
                                    ws.Range(1, 1, 1, 6).Style.Fill.BackgroundColor = XLColor.DarkTan;
                                    ws.Range(1, 1, 1, 6).Style.Font.FontColor = XLColor.White;

                                    ws.Range(2, 1, 2, 2).Merge();
                                    ws.Range(2, 1, 2, 2).Value = "Người vận hành : " + result.Username;
                                    ws.Range(3, 1, 3, 2).Merge();
                                    ws.Range(3, 1, 3, 2).Value = "Loại khí : " + result.LoaiKhi;
                                    ws.Range(4, 1, 4, 2).Merge();
                                    ws.Range(4, 1, 4, 2).Value = "Số lượng bình nạp giàn 1 : " + (result.SoLuongBinhCanNapHe1 ?? 0).ToString();
                                    ws.Range(5, 1, 5, 2).Merge();
                                    ws.Range(5, 1, 5, 2).Value = "Số lượng bình nạp giàn 2 : " + (result.SoLuongBinhCanNapHe2 ?? 0).ToString();


                                    ws.Range(2, 3, 2, 4).Merge();
                                    ws.Range(2, 3, 2, 4).Value = "Thể tích cần nạp : " + (result.TheTichCanNap ?? 0).ToString() + " L";
                                    ws.Range(3, 3, 3, 4).Merge();
                                    ws.Range(3, 3, 3, 4).Value = "Áp suất tiêu chuẩn : " + (result.ApSuatTieuChuan ?? 0) + " Bar";
                                    ws.Range(4, 3, 4, 4).Merge();
                                    ws.Range(4, 3, 4, 4).Value = "Thể tích tiêu chuẩn : " + (result.TheTichTieuChuan ?? 0).ToString() + " L";
                                    ws.Range(5, 3, 5, 4).Merge();
                                    ws.Range(5, 3, 5, 4).Value = "Hệ số tiêu chuẩn : " + (result.HeSoTieuChuan ?? 0).ToString();


                                    ws.Range(2, 5, 2, 6).Merge();
                                    ws.Range(2, 5, 2, 6).Value = "Thời gian trích mẫu : " + result.ThoiGianTrichMau?.ToString("HH:mm:ss") ?? "00:00:00";
                                    ws.Range(3, 5, 3, 6).Merge();
                                    ws.Range(3, 5, 3, 6).Value = "Thời gian bắt đầu : " + result.TimeStart.ToString("HH:mm:ss dd/MM/yyyy");
                                    ws.Range(4, 5, 4, 6).Merge();
                                    ws.Range(4, 5, 4, 6).Value = result.TimeStart < result.TimeEnd ? "Thời gian kết thúc : " + result.TimeEnd.ToString("HH:mm:ss dd/MM/yyyy") : "Thời gian kết thúc : ";
                                    ws.Range(5, 5, 5, 6).Merge();
                                    ws.Range(5, 5, 5, 6).Value = result.Status == true ? "Trạng thái : OK" : "Trạng thái : NG";

                                    ws.Range(2, 1, 5, 6).Style.Font.FontSize = 20;
                                    //





                                    ws.Range(6, 1, 6, 6).Merge();
                                    ws.Range(6, 1, 6, 6).Value = $"THỐNG KÊ DỮ LIỆU MẺ NẠP {Common.RESULT + result.ResultID}";
                                    ws.Range(6, 1, 6, 6).Style.Font.Bold = true;
                                    ws.Range(6, 1, 6, 6).Style.Font.FontSize = 24;
                                    ws.Range(6, 1, 6, 6).Style.Fill.BackgroundColor = XLColor.Green;
                                    ws.Range(6, 1, 6, 6).Style.Font.FontColor = XLColor.White;






                                    ws.Cell(7, 1).Value = "Stt";
                                    ws.Cell(7, 2).Value = "Tên giàn";
                                    ws.Cell(7, 3).Value = "Áp suất tổng (bar)";
                                    ws.Cell(7, 4).Value = "Áp suất (bar)";
                                    ws.Cell(7, 5).Value = "Thể tích (l)";
                                    ws.Cell(7, 6).Value = "Thời điểm";

                                    ws.Range(7, 1, 7, 6).Style.Font.Bold = true;
                                    ws.Range(7, 1, 7, 6).Style.Font.FontSize = 20;
                                    ws.Range(7, 1, 7, 6).Style.Fill.BackgroundColor = XLColor.LightGreen;




                                    for (int row = 0; row < list.Count; row++)
                                    {
                                        ws.Cell(8 + row, 1).Value = row + 1;
                                        ws.Cell(8 + row, 2).Value = list[row].NameMachine;
                                        ws.Cell(8 + row, 3).Value = list[row].ApSuatTong;
                                        ws.Cell(8 + row, 4).Value = list[row].ApSuat;
                                        ws.Cell(8 + row, 5).Value = list[row].TheTich;
                                        ws.Cell(8 + row, 6).Value = list[row].CreateAt.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);

                                        if (row % 2 == 0)
                                        {
                                            ws.Range(8 + row, 1, 8 + row, 6).Style.Fill.BackgroundColor = XLColor.FromHtml("#dfe8f2");
                                        }
                                    }


                                    ws.Range(1, 1, 8 + list.Count, 8).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    ws.Range(8, 1, 8 + list.Count, 6).Style.Font.FontSize = 18;

                                    ws.Columns(1, 6).AdjustToContents();

                                    workBook.SaveAs(sfd.FileName);
                                }
                            });


                            MessageBox.Show($"Xuất file thống kê dữ liệu mẻ nạp {Common.RESULT + result.ResultID} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }














        public async void ExportManyMachineToExcel(List<Machine>? list)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string RID = string.Join(", ", list.Select(a => Common.RESULT + a.ResultID).Distinct());
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx|Excel 2010|*.xls" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                using (var workBook = new XLWorkbook())
                                {

                                    var ws = workBook.Worksheets.Add($"THỐNG KÊ DỮ LIỆU MẺ NẠP");

                                    //
                                    ws.Range(1, 1, 1, 6).Merge();
                                    ws.Range(1, 1, 1, 6).Value = $"THỐNG KÊ DỮ LIỆU MẺ NẠP {RID}";
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


                                    int idR = 0;

                                    int rowPlus = 0;

                                    for (int row = 0; row < list.Count; row++)
                                    {
                                        if (idR != list[row].ResultID)
                                        {
                                            ws.Cell(3 + row + rowPlus, 1).Value = "#" + Common.RESULT + list[row].ResultID;
                                            ws.Cell(3 + row + rowPlus, 1).Style.Font.FontColor = XLColor.White;
                                            ws.Cell(3 + row + rowPlus, 1).Style.Font.Bold = true;
                                            ws.Range(3 + row + rowPlus, 1, 3 + row + rowPlus, 6).Style.Fill.BackgroundColor = XLColor.Byzantium;
                                            rowPlus++;
                                            idR = list[row].ResultID;
                                        }

                                        ws.Cell(3 + row + rowPlus, 1).Value = row + 1;
                                        ws.Cell(3 + row + rowPlus, 2).Value = list[row].NameMachine;
                                        ws.Cell(3 + row + rowPlus, 3).Value = string.Format("{0:0.00}", list[row].ApSuatTong ?? 0);
                                        ws.Cell(3 + row + rowPlus, 4).Value = string.Format("{0:0.00}", list[row].ApSuat ?? 0);
                                        ws.Cell(3 + row + rowPlus, 5).Value = string.Format("{0:0.00}", list[row].TheTich ?? 0);
                                        ws.Cell(3 + row + rowPlus, 6).Value = list[row].CreateAt.ToString($"HH:mm:ss dd/MM/yyyy", CultureInfo.InvariantCulture);

                                        if (row % 2 == 0)
                                        {
                                            ws.Range(3 + row + rowPlus, 1, 3 + row + rowPlus, 6).Style.Fill.BackgroundColor = XLColor.FromHtml("#dfe8f2");
                                        }
                                    }


                                    ws.Range(1, 1, 3 + list.Count + rowPlus, 6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    ws.Range(3, 1, 3 + list.Count + rowPlus, 6).Style.Font.FontSize = 18;





                                    ws.Columns(1, 6).AdjustToContents();

                                    workBook.SaveAs(sfd.FileName);
                                }
                            });


                            MessageBox.Show($"Xuất file thống kê dữ liệu mẻ nạp {RID} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }































        //
        public async void ExportResultToPdf(List<Result>? list)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất pdf.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Files|*.pdf", Title = "Save a PDF File" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                PdfWriter writer = new PdfWriter(sfd.FileName);
                                PdfDocument pdfDoc = new PdfDocument(writer);

                                Document doc = new Document(pdfDoc);

                                PdfFont font = PdfFontFactory.CreateFont(@"arial-unicode-ms.ttf", PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED, true);
                                doc.SetFont(font);


                                doc.Add(new Paragraph("THỐNG KÊ MẺ NẠP").SetFontSize(20).SetBold().SetTextAlignment(TextAlignment.CENTER));



                                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 9, 14, 22, 22, 14, 9 }));

                                table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                                Cell cell1 = new Cell().Add(new Paragraph("ID"));
                                cell1.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell1.SetFontSize(13).SetBold();
                                Cell cell2 = new Cell().Add(new Paragraph("Loại khí"));
                                cell2.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell2.SetFontSize(13).SetBold();
                                Cell cell3 = new Cell().Add(new Paragraph("Thời gian bắt đầu"));
                                cell3.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell3.SetFontSize(13).SetBold();
                                Cell cell4 = new Cell().Add(new Paragraph("Thời gian kết thúc"));
                                cell4.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell4.SetFontSize(13).SetBold();
                                Cell cell5 = new Cell().Add(new Paragraph("Người giám sát"));
                                cell5.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell5.SetFontSize(13).SetBold();
                                Cell cell6 = new Cell().Add(new Paragraph("Trạng thái"));
                                cell6.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell6.SetFontSize(13).SetBold();

                                table.AddCell(cell1);
                                table.AddCell(cell2);
                                table.AddCell(cell3);
                                table.AddCell(cell4);
                                table.AddCell(cell5);
                                table.AddCell(cell6);


                                foreach (Result result in list)
                                {
                                    table.AddCell(new Cell().Add(new Paragraph($"{Common.RESULT + result.ResultID}").SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph($"{result.LoaiKhi}").SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph($"{result.TimeStart.ToString("HH:mm:ss dd/MM/yyyy")}").SetTextAlignment(TextAlignment.CENTER)));
                                    if (result.TimeEnd > result.TimeStart)
                                    {
                                        table.AddCell(new Cell().Add(new Paragraph($"{result.TimeEnd.ToString("HH:mm:ss dd/MM/yyyy")}").SetTextAlignment(TextAlignment.CENTER)));
                                    }
                                    else
                                    {
                                        table.AddCell("");
                                    }
                                    table.AddCell(new Cell().Add(new Paragraph($"{result.Username}").SetTextAlignment(TextAlignment.CENTER)));
                                    string stt = result.Status == true ? "OK" : "NG";
                                    table.AddCell(new Cell().Add(new Paragraph(stt).SetTextAlignment(TextAlignment.CENTER)));
                                }

                                doc.Add(table);


                                doc.Close();

                            });
                            MessageBox.Show($"Xuất file báo cáo thống kê mẻ nạp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);





                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }














        public async void ExportMachineOnAResultToPdf(List<Machine>? list, Result result)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất pdf.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Files|*.pdf", Title = "Save a PDF File" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                PdfWriter writer = new PdfWriter(sfd.FileName);
                                PdfDocument pdfDoc = new PdfDocument(writer);

                                Document doc = new Document(pdfDoc);

                                PdfFont font = PdfFontFactory.CreateFont(@"arial-unicode-ms.ttf", PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED, true);
                                doc.SetFont(font);


                                doc.Add(new Paragraph($"THỐNG KÊ DỮ LIỆU MẺ NẠP {Common.RESULT + result.ResultID}").SetFontSize(20).SetBold().SetTextAlignment(TextAlignment.CENTER));

                                UnitValue unitValue = new UnitValue(UnitValue.PERCENT, 100);

                                Table tableThongtin = new Table(UnitValue.CreatePercentArray(new float[] { 50, 50 })).SetBorder(Border.NO_BORDER);
                                tableThongtin.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                                tableThongtin.SetWidth(unitValue);
                                tableThongtin.SetMarginTop(12);
                                tableThongtin.SetMarginBottom(12);




                                Cell cellNguoiVanHanh = new Cell().Add(new Paragraph("Người vận hành : " + result.Username));
                                cellNguoiVanHanh.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellNguoiVanHanh);

                                Cell cellLoaiKhi = new Cell().Add(new Paragraph("Loại khí : " + result.LoaiKhi));
                                cellLoaiKhi.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellLoaiKhi);


                                Cell cellSoLuongGian1 = new Cell().Add(new Paragraph("Số lượng bình nạp giàn 1 : " + (result.SoLuongBinhCanNapHe1 ?? 0).ToString()));
                                cellSoLuongGian1.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellSoLuongGian1);

                                Cell cellSoLuongGian2 = new Cell().Add(new Paragraph("Số lượng bình nạp giàn 2 : " + (result.SoLuongBinhCanNapHe2 ?? 0).ToString()));
                                cellSoLuongGian2.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellSoLuongGian2);

                                Cell cellTheTichCanNap = new Cell().Add(new Paragraph("Thể tích cần nạp : " + (result.TheTichCanNap ?? 0).ToString() + " L"));
                                cellTheTichCanNap.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellTheTichCanNap);


                                Cell cellApSuatTieuChuan = new Cell().Add(new Paragraph("Áp suất tiêu chuẩn : " + (result.ApSuatTieuChuan ?? 0) + " Bar"));
                                cellApSuatTieuChuan.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellApSuatTieuChuan);

                                Cell cellTheTichTieuChuan = new Cell().Add(new Paragraph("Thể tích tiêu chuẩn : " + (result.TheTichTieuChuan ?? 0).ToString() + " L"));
                                cellTheTichTieuChuan.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellTheTichTieuChuan);

                                Cell cellHeSoTieuChuan = new Cell().Add(new Paragraph("Hệ số tiêu chuẩn : " + (result.HeSoTieuChuan ?? 0).ToString()));
                                cellHeSoTieuChuan.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellHeSoTieuChuan);

                                Cell cellThoiGianTrichMau = new Cell().Add(new Paragraph("Thời gian trích mẫu : " + result.ThoiGianTrichMau?.ToString("HH:mm:ss") ?? "00:00:00"));
                                cellThoiGianTrichMau.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellThoiGianTrichMau);

                                Cell cellTimeStart = new Cell().Add(new Paragraph("Thời gian bắt đầu : " + result.TimeStart.ToString("HH:mm:ss dd/MM/yyyy")));
                                cellTimeStart.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellTimeStart);

                                Cell cellTimeEnd = new Cell().Add(new Paragraph(result.TimeStart < result.TimeEnd ? "Thời gian kết thúc : " + result.TimeEnd.ToString("HH:mm:ss dd/MM/yyyy") : "Thời gian kết thúc : "));
                                cellTimeEnd.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellTimeEnd);

                                Cell cellStatus = new Cell().Add(new Paragraph(result.Status == true ? "Trạng thái : OK" : "Trạng thái : NG"));
                                cellStatus.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                tableThongtin.AddCell(cellStatus);

                                doc.Add(tableThongtin);





                                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 10, 17, 17, 17, 17, 22 }));

                                table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                                Cell cell1 = new Cell().Add(new Paragraph("Stt"));
                                cell1.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell1.SetFontSize(13).SetBold();
                                Cell cell2 = new Cell().Add(new Paragraph("Tên giàn"));
                                cell2.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell2.SetFontSize(13).SetBold();
                                Cell cell3 = new Cell().Add(new Paragraph("Áp suất tổng"));
                                cell3.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell3.SetFontSize(13).SetBold();
                                Cell cell4 = new Cell().Add(new Paragraph("Áp suất"));
                                cell4.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell4.SetFontSize(13).SetBold();
                                Cell cell5 = new Cell().Add(new Paragraph("Thể tích"));
                                cell5.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell5.SetFontSize(13).SetBold();
                                Cell cell6 = new Cell().Add(new Paragraph("Thời điểm"));
                                cell6.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell6.SetFontSize(13).SetBold();

                                table.AddCell(cell1);
                                table.AddCell(cell2);
                                table.AddCell(cell3);
                                table.AddCell(cell4);
                                table.AddCell(cell5);
                                table.AddCell(cell6);

                                int i = 1;
                                foreach (Machine machine in list)
                                {
                                    table.AddCell(new Cell().Add(new Paragraph($"{i}").SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph($"{machine.NameMachine}").SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(string.Format("{0:0.00}", machine.ApSuatTong ?? 0)).SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(string.Format("{0:0.00}", machine.ApSuat ?? 0)).SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(string.Format("{0:0.00}", machine.TheTich ?? 0)).SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(machine.CreateAt.ToString("HH:mm:ss dd/MM/yyyy")).SetTextAlignment(TextAlignment.CENTER)));

                                    i++;
                                }

                                doc.Add(table);

                                doc.Close();

                            });
                            MessageBox.Show($"Xuất file báo cáo thống kê mẻ nạp {Common.RESULT + result.ResultID} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);





                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }












        public async void ExportManyMachineToPdf(List<Machine>? list)
        {
            if (list == null || list.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu để xuất pdf.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string RID = string.Join(", ", list.Select(a => Common.RESULT + a.ResultID).Distinct());

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Files|*.pdf", Title = "Save a PDF File" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            await Task.Run(() =>
                            {
                                PdfWriter writer = new PdfWriter(sfd.FileName);
                                PdfDocument pdfDoc = new PdfDocument(writer);

                                Document doc = new Document(pdfDoc);

                                PdfFont font = PdfFontFactory.CreateFont(@"arial-unicode-ms.ttf", PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED, true);
                                doc.SetFont(font);


                                doc.Add(new Paragraph($"THỐNG KÊ DỮ LIỆU MẺ NẠP {RID}").SetFontSize(20).SetBold().SetTextAlignment(TextAlignment.CENTER));

                                UnitValue unitValue = new UnitValue(UnitValue.PERCENT, 100);

                                

                                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 10, 17, 17, 17, 17, 22 }));

                                table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                                Cell cell1 = new Cell().Add(new Paragraph("Stt"));
                                cell1.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell1.SetFontSize(13).SetBold();
                                Cell cell2 = new Cell().Add(new Paragraph("Tên giàn"));
                                cell2.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell2.SetFontSize(13).SetBold();
                                Cell cell3 = new Cell().Add(new Paragraph("Áp suất tổng"));
                                cell3.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell3.SetFontSize(13).SetBold();
                                Cell cell4 = new Cell().Add(new Paragraph("Áp suất"));
                                cell4.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell4.SetFontSize(13).SetBold();
                                Cell cell5 = new Cell().Add(new Paragraph("Thể tích"));
                                cell5.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell5.SetFontSize(13).SetBold();
                                Cell cell6 = new Cell().Add(new Paragraph("Thời điểm"));
                                cell6.SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                                cell6.SetFontSize(13).SetBold();

                                table.AddCell(cell1);
                                table.AddCell(cell2);
                                table.AddCell(cell3);
                                table.AddCell(cell4);
                                table.AddCell(cell5);
                                table.AddCell(cell6);

                                int i = 1;
                                int r = 0;
                                foreach (Machine machine in list)
                                {
                                    if(machine.ResultID != r)
                                    {
                                        table.AddCell(new Cell().Add(new Paragraph($"#{Common.RESULT + machine.ResultID}").SetTextAlignment(TextAlignment.CENTER)));
                                        table.AddCell(new Cell().Add(new Paragraph("")));
                                        table.AddCell(new Cell().Add(new Paragraph("")));
                                        table.AddCell(new Cell().Add(new Paragraph("")));
                                        table.AddCell(new Cell().Add(new Paragraph("")));
                                        table.AddCell(new Cell().Add(new Paragraph("")));
                                        i = 1;
                                        r = machine.ResultID;
                                        continue;
                                    }
                                    table.AddCell(new Cell().Add(new Paragraph($"{i}").SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph($"{machine.NameMachine}").SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(string.Format("{0:0.00}", machine.ApSuatTong ?? 0)).SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(string.Format("{0:0.00}", machine.ApSuat ?? 0)).SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(string.Format("{0:0.00}", machine.TheTich ?? 0)).SetTextAlignment(TextAlignment.CENTER)));
                                    table.AddCell(new Cell().Add(new Paragraph(machine.CreateAt.ToString("HH:mm:ss dd/MM/yyyy")).SetTextAlignment(TextAlignment.CENTER)));

                                    i++;
                                }

                                doc.Add(table);

                                doc.Close();

                            });
                            MessageBox.Show($"Xuất file báo cáo thống kê mẻ nạp {RID} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);





                        }
                        catch { MessageBox.Show("Không thể xuất file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }

















    }
}
