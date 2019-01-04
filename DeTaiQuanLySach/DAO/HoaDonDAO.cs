using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.DTO;
using quanlynhasach.DTO;
using System.Data;

namespace quanlynhasach.DAO
{
    class HoaDonDAO
    {
        static public HoaDonDTO SelectSachLikeMaHoaDonMaSach(int mahoadon, int masach)
        {
            string sql = "select * from CHITIETHOADON where ((MaHoaDon = " + mahoadon + ")AND(MaSach like " + masach + ") )";
            
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                HoaDonDTO hoaDon = new HoaDonDTO();
                hd.MaSach = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                return hoaDon;
            }
        }
        public static DataTable SelectAll()
        {
            string sql = "select * from HOADON";
            return DataAccess.ExcuQuery(sql);
        }
        public static DataTable SelectallHoaDonChiTiet()
        {
            string sql = "select * from CHITIETHOADON";
            return DataAccess.ExcuQuery(sql);
        }
       
        public static void Insert(HoaDonDTO hd)
        {
            string sql = "insert into HOADON(NgayLapHoaDon,MaKhachHang) values('" + hd.NgayLapHoaDon + "'," + hd.MaKhachHang + ")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void InsertChitiet(HoaDonDTO hd)
        {
            string sql = "insert into CHITIETHOADON(MaHoaDon,MaSach,SoLuongMua) values(" + hd.MaHoaDon + "," + hd.MaSach + "," + hd.SoLuongMua + ")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(HoaDonDTO hd)
        {
            string sql = "Update  HOADON set NgayLapHoaDon =('" + hd.NgayLapHoaDon + "'),MaSach=(" + hd.MaSach + "), MaKhachHang=(" + hd.MaKhachHang + ") where MaHoaDon=" + hd.MaHoaDon + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(HoaDonDTO hd)
        {
            try
            {
                string sql = "delete from HOADON where MaHoaDon= " + hd.MaHoaDon + "";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
