using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.DTO;
using quanlynhasach.DTO;
using System.Data;

namespace quanlynhasach.DAO
{
    class PhieuNhapDAO
    {
        static public DataTable SelectPhieuNhapAll()
        {
            string sql = "select* from PHIEUNHAP";
            DataTable dt = DataAccess.ExcuQuery(sql);
            return dt;
        }
        static public DataTable SelectChiTietPhieuNhapAll()
        {
            string sql = "select * from CHITIETPHIEU";
            DataTable dt = DataAccess.ExcuQuery(sql);
            return dt;
        }
        static public void InsertChiTietPhieu(PhieuNhapDTO phieuNhap)
        {
            string sql = "insert into CHITIETPHIEU(MaPhieuNhap,MaSach,SoLuongNhap) values(" + phieuNhap.MaPhieuNhap + "," + phieuNhap.MaSach + "," + phieuNhap.SoLuong + ")";
            DataAccess.ExcuNonQuery(sql);
        }
        static public void InsertPhieuNhap(PhieuNhapDTO phieuNhap)
        {
            string sql = "insert into PHIEUNHAP(NgayNhap) values('" + phieuNhap.NgayNhap + "')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static PhieuNhapDTO GetByName(int maphieunhap, int masach)
        {
            string sql = "select * from CHITIETPHIEU where ((MaPhieuNhap=" + maphieunhap + ")AND(MaSach = "+masach+"))";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                PhieuNhapDTO phieuNhap = new PhieuNhapDTO();
                phieuNhap.MaPhieuNhap = (int)dt.Rows[0].ItemArray[0];                
                return phieuNhap;
            }

        }
        
    }
}
