using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using quanlynhasach.DAO;
using quanlynhasach.DTO;

namespace quanlynhasach.DAO
{
    class ThamSoDAO
    {
        public static DataTable GetAll()
        {
            string sql = "select * from THAMSO";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectSoLuongTon(int maSach)
        {
            string sql = "select * from SACH where MaSach=" +masach + "";
            return DataAccess.ExcuQuery(sql);          
        }
        static public DataTable SelectTienNoKH(int makh)
        {
            string sql = "select * from KHACHHANG where MaKhachHang=" + makh + "";
            return DataAccess.ExcuQuery(sql);
        }
        static public void Update(ThamSoDTO thamSo)
        {
            string sql = "update THAMSO set SoLuongNhapItNhat=(" + thamSo.SoLuongNhapMin + "),LuongTonItNhat=(" + thamSo.LuongTonMin + "),NoKhongQua=(" + thamSo.NoMin + "),LuongTonSauKhiBan=(" + thamSo.TonSauKhiBan + "),DieuKienThu=(" + ts.DieuKienThu+ ") where MaThamSo = " + ts.MaThamSo + "";
            DataAccess.ExcuNonQuery(sql);
        }
    }
}
