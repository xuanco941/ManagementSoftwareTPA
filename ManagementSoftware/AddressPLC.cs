using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSoftware
{
    public class AddressPLC
    {
        //Hiển thị các trạng thái của máy 
        //Bắt đầu quá trình nạp khí hệ 1  (Bool)
        public const string DATA_PC_ST_Run_Nap_H1 = "DATA_PC.ST_Run_Nap_H1";
        //Bắt đầu quá trình nạp khí hệ 2  (Bool)
        public const string DATA_PC_ST_Run_Nap_H2 = "DATA_PC.ST_Run_Nap_H2";
        //Kết thúc 1 quá trình nạp khí ở hệ 1  (Bool)
        public const string DATA_PC_KetThuc_QT_NAP_H1 = "DATA_PC.KetThuc_QT_NAP_H1";
        //Kết thúc 1 quá trình nạp khí ở hệ 2  (Bool)
        public const string DATA_PC_KetThuc_QT_NAP_H2 = "DATA_PC.KetThuc_QT_NAP_H2";
        //Bắt đầu quá trình xả khí hệ 1  (Bool)
        public const string DATA_PC_ST_Xa_Khi_H1 = "DATA_PC.ST_Xa_Khi_H1";
        //Bắt đầu quá trình xả khí hệ 2  (Bool)
        public const string DATA_PC_ST_Xa_Khi_H2 = "DATA_PC.ST_Xa_Khi_H2";

        //Các giá trị  cài dặt

        //Cài đặt thể tích bình cần nạp   (Real)
        public const string DATA_SETUP_V_Nap = "DATA_SETUP.V_Nap";
        //Cài đặt thể tích tiêu chuẩn theo áp suất   (Real)
        public const string DATA_SETUP_V_Tieu_Chuan = "DATA_SETUP.V_Tieu_Chuan";
        //Cài đặt áp suất tiêu chuẩn theo thể tích   (Real)
        public const string DATA_SETUP_P_Tieu_Chuan = "DATA_SETUP.P_Tieu_Chuan";
        //Cài đặt hệ số biến đổi áp suất theo nhiệt độ   (Real)
        public const string DATA_SETUP_DATA_SetupHS_Nhiet_do = "DATA_SETUP.DATA_SetupHS_Nhiet_do";
        //Cài đặt thời gian trích mẫu    (DateTime)
        public const string DATA_SETUP_Time_trich_mau = "DATA_SETUP.Time_trich_mau";
        //Cài đặt số lượng bình cần nạp cho hệ 1   (UDint)
        public const string DATA_SETUP_SL_Binh_Nap_H1 = "DATA_SETUP.SL_Binh_Nap_H1";
        //Cài đặt số lượng bình cần nạp cho hệ 2  (UDint)
        public const string DATA_SETUP_SL_Binh_Nap_H2 = "DATA_SETUP.SL_Binh_Nap_H2";

        //Giá trị hiển thị

        //Hiển thị giá trị áp xuất hiện tại của đường ống hệ 1     (Real)
        public const string DATA_PC_GT_AS_ST_H1 = "DATA_PC.GT_AS_ST_H1";
        //Hiển thị giá trị áp xuất hiện tại của đường ống hệ 2   (Real)
        public const string DATA_PC_GT_AS_ST_H2 = "DATA_PC.GT_AS_ST_H2";
        //Hiển thị giá trị áp xuất hiện tại của đường ống tổng   (Real)
        public const string DATA_PC_GT_AS_Tong = "DATA_PC.GT_AS_Tong";
        //Hiển thị giá trị thể tích hiện tại của  hệ 1   (Real)
        public const string DATA_PC_GT_V_ST_H1 = "DATA_PC.GT_V_ST_H1";
        //Hiển thị giá trị thể tích hiện tại của  hệ 2   (Real)
        public const string DATA_PC_GT_V_ST_H2 = "DATA_PC.GT_V_ST_H2";
        //Hiển thị giá trị thể tích trích mẫu của  hệ 1   (Real)
        public const string DATA_PC_GT_V_TM_H1 = "DATA_PC.GT_V_TM_H1";
        //Hiển thị giá trị thể tích trích mẫu của  hệ 2   (Real)
        public const string DATA_PC_GT_V_TM_H2 = "DATA_PC.GT_V_TM_H2";

        //Trạng thái các tín hiệu vào, ra


        //Động cơ băng tải vào hệ 1 chạy  (Bool)
        public const string DATA_PC_Motor_BT1_Vao = "DATA_PC.Motor_BT1_Vao";
        //Động cơ băng tải nạp 1 hệ 1 chạy  (Bool)
        public const string DATA_PC_Motor_BT1_Nap1 = "DATA_PC.Motor_BT1_Nap1";
        //Động cơ băng tải nạp 2 hệ 1 chạy  (Bool)
        public const string DATA_PC_Motor_BT1_Nap2 = "DATA_PC.Motor_BT1_Nap2";
        //Động cơ băng tải ra hệ 1 chạy  (Bool)
        public const string DATA_PC_Motor_BT1_Ra = "DATA_PC.Motor_BT1_Ra";
        //Động cơ băng tải vao hệ 2 chạy  (Bool)
        public const string DATA_PC_Motor_BT2_Vao = "DATA_PC.Motor_BT2_Vao";
        //Động cơ băng tải nạp 1 hệ 2 chạy  (Bool)
        public const string DATA_PC_Motor_BT2_Nap1 = "DATA_PC.Motor_BT2_Nap1";
        //Động cơ băng tải nạp 2 hệ 2 chạy  (Bool)
        public const string DATA_PC_Motor_BT2_Nap2 = "DATA_PC.Motor_BT2_Nap2";
        //Động cơ băng tải ra hệ 2 chạy  (Bool)
        public const string DATA_PC_Motor_BT2_Ra = "DATA_PC.Motor_BT2_Ra";
        //Trạng thái hệ 1 đang chạy  (Bool)
        public const string DATA_PC_D_Run_1 = "DATA_PC.D_Run_1";
        //Trạng thái hệ 2 đang chạy  (Bool)
        public const string DATA_PC_D_Run_2 = "DATA_PC.D_Run_2";
        //Trạng thái hệ 1 dừng  (Bool)
        public const string DATA_PC_D_Stop_1 = "DATA_PC.D_Stop_1";
        //Trạng thái hệ 2 dừng  (Bool)
        public const string DATA_PC_D_Stop_2 = "DATA_PC.D_Stop_2";
        //Trạng thái hệ 1 lỗi  (Bool)
        public const string DATA_PC_D_ERROR_1 = "DATA_PC_D_ERROR_1";
        //Trạng thái hệ 2 lỗi  (Bool)
        public const string DATA_PC_D_ERROR_2 = "DATA_PC_D_ERROR_2";
        //Van cấp khí hệ 1 hoạt động  (Bool)
        public const string DATA_PC_Van_Cap_H1 = "DATA_PC.Van_Cap_H1";
        //Van xả khí hệ 1 hoạt động  (Bool)
        public const string DATA_PC_Van_Xa_H1 = "DATA_PC.Van_Xa_H1";
        //Van cấp khí hệ 2 hoạt động  (Bool)
        public const string DATA_PC_Van_Cap_H2 = "DATA_PC.Van_Cap_H2";
        //Van xả khí hệ 2 hoạt động  (Bool)
        public const string DATA_PC_Van_Xa_H2 = "DATA_PC.Van_Xa_H2";
        //Phát hiện palet có ở vị trí cấp hệ 1  (Bool)
        public const string DATA_PC_CB_PL_VT_Cap1 = "DATA_PC.CB_PL_VT_Cap1";
        //Phát hiện palet qua vị trí cấp hệ 1  (Bool)
        public const string DATA_PC_CB_PL_qua_Vtcap1 = "DATA_PC.CB_PL_qua_Vtcap1";
        //Phát hiện palet đến cuối băng tải vào hệ 1  (Bool)
        public const string DATA_PC_CB_PL_cuoi_Btvao1 = "DATA_PC.CB_PL_cuoi_Btvao1";
        //Điều khiển băng tải nạp 1 của hệ 1 chạy  (Bool)
        public const string DATA_PC_CB_RunBT_Nap1_1 = "DATA_PC.CB_RunBT_Nap1_1";
        //Điều khiển băng tải nạp 1 của hệ 1 dừng  (Bool)
        public const string DATA_PC_CB_StopBT_Nap1_1 = "DATA_PC.CB_StopBT_Nap1_1";
        //Điều khiển băng tải nạp 2 của hệ 1 dừng  (Bool)
        public const string DATA_PC_CB_RunBT_Nap1_2 = "DATA_PC.CB_RunBT_Nap1_2";
        //Điều khiển băng tải nạp 2 của hệ 1 dừng  (Bool)
        public const string DATA_PC_CB_StopBT_Nap1_2 = "DATA_PC.CB_StopBT_Nap1_2";
        //Phát hiện palet có ra hệ 1  (Bool)
        public const string DATA_PC_CB_co_PL_Ra1 = "DATA_PC.CB_co_PL_Ra1";
        //Phát hiện palet đến vị trí ra hệ 1  (Bool)
        public const string DATA_PC_CB_PL_den_VTRa1 = "DATA_PC.CB_PL_den_VTRa1";
        //Phát hiện palet ở vị trí lấy hệ 1  (Bool)
        public const string DATA_PC_CB_CB_PL_VT_Lay1 = "DATA_PC.CB_CB_PL_VT_Lay1";
        //Tín hiệu bắt đầu quá trình nạp khí hệ 1  (Bool)
        public const string DATA_PC_Run_Nap_H1 = "DATA_PC.Run_Nap_H1";
        //Phát hiện palet có ở vị trí cấp hệ 2  (Bool)
        public const string DATA_PC_CB_PL_VT_Cap2 = "DATA_PC.CB_PL_VT_Cap2";
        //Phát hiện palet qua vị trí cấp hệ 2  (Bool)
        public const string DATA_PC_CB_PL_qua_Vtcap2 = "DATA_PC.CB_PL_qua_Vtcap2";
        //Phát hiện palet đến cuối băng tải vào hệ 2  (Bool)
        public const string DATA_PC_CB_PL_cuoi_Btvao2 = "DATA_PC.CB_PL_cuoi_Btvao2";
        //Điều khiển băng tải nạp 1 của hệ 2 chạy  (Bool)
        public const string DATA_PC_CB_RunBT_Nap2_1 = "DATA_PC.CB_RunBT_Nap2_1";
        //Điều khiển băng tải nạp 1 của hệ 2 dừng  (Bool)
        public const string DATA_PC_CB_StopBT_Nap2_1 = "DATA_PC.CB_StopBT_Nap2_1";
        //Điều khiển băng tải nạp 2 của hệ 2 chạy  (Bool)
        public const string DATA_PC_CB_RunBT_Nap2_2 = "DATA_PC.CB_RunBT_Nap2_2";
        //Điều khiển băng tải nạp 2 của hệ 2 dừng  (Bool)
        public const string DATA_PC_CB_StopBT_Nap2_2 = "DATA_PC.CB_StopBT_Nap2_2";
        //Phát hiện palet có ra hệ 2  (Bool)
        public const string DATA_PC_CB_co_PL_Ra2 = "DATA_PC.CB_co_PL_Ra2";
        //Phát hiện palet đến vị trí ra hệ 2  (Bool)
        public const string DATA_PC_CB_PL_den_VTRa2 = "DATA_PC.CB_PL_den_VTRa2";
        //Phát hiện palet ở vị trí lấy hệ 2  (Bool)
        public const string DATA_PC_CB_CB_PL_VT_Lay2 = "DATA_PC.CB_CB_PL_VT_Lay2";
        //Tín hiệu bắt đầu quá trình nạp khí hệ 2  (Bool)
        public const string DATA_PC_Run_Nap_H2 = "DATA_PC.Run_Nap_H2";

        //Trạng thái lỗi

        //Cảnh báo lỗi động cơ ở hệ hóa hơi  (Bool)
        public const string DATA_PC_VFP_Trip = "DATA_PC.VFP_Trip";
        //Cảnh báo chưa mở hệ hóa hơi  (Bool)
        public const string DATA_PC_OFF_Hoa_Hoi = "DATA_PC.OFF_Hoa_Hoi";
        //Lỗi quá trình xả khí hệ 1  (Bool)
        public const string DATA_PC_Loi_TT_XA_KHI_H1 = "DATA_PC.Loi_TT_XA_KHI_H1";
        //Lỗi quá trình xả khí hệ 2  (Bool)
        public const string DATA_PC_Loi_TT_XA_KHI_H2 = "DATA_PC.Loi_TT_XA_KHI_H2";
        //Lỗi quá trình nạp khí hệ 1  (Bool)
        public const string DATA_PC_Loi_TT_NAP_KHI_H1 = "DATA_PC.Loi_TT_NAP_KHI_H1";
        //Lỗi quá trình nạp khí hệ 2  (Bool)
        public const string DATA_PC_Loi_TT_NAP_KHI_H2 = "DATA_PC.Loi_TT_NAP_KHI_H2";

        //Trạng thái đăng nhập lên PC

        //Tài khoản đăng nhập điều khiển hệ thống (String)
        public const string DATA_PC_Tai_Khoan = "DATA_PC.Tai_Khoan";
        //Mật khẩu đăng nhập điều khiển hệ thống (String)
        public const string DATA_PC_Mat_khau = "DATA_PC.Mat_khau";
        //Thông báo đã đăng nhập thành công  (Bool)
        public const string DATA_PC_Dang_nhap_thanh_cong = "DATA_PC.Dang_nhap_thanh_cong";
        //Trạng thái PLC đang hoạt động  (Bool)
        public const string DATA_PC_Always_True = "DATA_PC.Always_True";
        //Trạng thái PC hoạt động  (Bool)
        public const string DATA_PC_Trang_Thai_PC = "DATA_PC.Trang_Thai_PC";

    }
}
