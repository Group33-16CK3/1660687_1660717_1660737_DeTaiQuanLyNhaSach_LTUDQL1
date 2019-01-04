using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.DTO;
using quanlynhasach.DTO;
using System.Data;

namespace quanlynhasach.DAO
{
    class KhachHangDAO
    {
        static public DataTable SelectKhachHangLikeTen(KhachHangDTO khachHang)
        {
            string sql = "select * from KHACHHANG where HoTenKhachHang like '%" + khachHang.HoTenKhachHang + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeDiaChi(KhachHangDTO khachHang)
        {
            string sql = "select * from KHACHHANG where DiaChi like '%" + khachHang.DiaChi+ "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeDienThoai(KhachHangDTO khachHang)
        {
            string sql = "select * from KHACHHANG where DienThoai like '%" + khachHang.DienThoai + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeEmail(KhachHangDTO khachHang)
        {
            string sql = "select * from KHACHHANG where Email like '%" + khachHang.Email + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        public static DataTable GetAll()
        {
            string sql = "select * from KHACHHANG";
            return DataAccess.ExcuQuery(sql);
        }
        public static void Insert(KhachHangDTO khachHang)
        {
            string sql = "insert into KHACHHANG(HoTenKhachHang,DienThoai,DiaChi,Email) values('" + khachHang.HoTenKhachHang + "',"+khachHang.DienThoai+",'"+khachHang.DiaChi+"','"+khachHang.Email+"')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(KhachHangDTO khachHang)
        {
            string sql = "Update  KHACHHANG set HoTenKhachHang =('" + khachHang.HoTenKhachHang + "'),DienThoai=(" + khachHang.DienThoai + "), DiaChi=('" + khachHang.DiaChi + "'),Email=('" + khachHang.Email + "') where MaKhachHang=" + khachHang.MaKhachHang + "";
            

            DataAccess.ExcuNonQuery(sql);
        }
        public static void UpdateTienNo(KhachHangDTO khachHang)
        {
            string sql = "Update  KHACHHANG set TienNo=(" + khachHang.TienNo + ") where MaKhachHang=" + khachHang.MaKhachHang + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(KhachHangDTO khachHang)
        {
            try
            {
                string sql = "delete from KHACHHANG where MaKhachHang= "+ khachHang.MaKhachHang+"";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static KhachHangDTO GetByMa(int Ma)
        {
            string sql = "select * from KHACHHANG where MaKhachHang=" + Ma + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = (int)dt.Rows[0].ItemArray[0];
                kh.HoTenKhachHang = dt.Rows[0].ItemArray[1].ToString();
                kh.DienThoai = (int)dt.Rows[0].ItemArray[2];
                kh.DiaChi = dt.Rows[0].ItemArray[3].ToString();
                kh.Email = dt.Rows[0].ItemArray[4].ToString();
                return kh;
            }

        }
    }
}
