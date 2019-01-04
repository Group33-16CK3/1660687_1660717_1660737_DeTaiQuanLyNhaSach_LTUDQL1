using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.DTO;
using quanlynhasach.DTO;
using System.Data;


namespace quanlynhasach.DAO
{
    class PhieuThuDAO
    {
        public static DataTable GetAll()
        {
            string sql = "select * from PHIEUTHU";
            return DataAccess.ExcuQuery(sql);
        }
        public static void Insert(PhieuThuDTO phieuThu)
        {
            string sql = "insert into PHIEUTHU(NgayThu,SoTienThu,MaKhachHang) values('" + phieuThu.NgayThu + "'," + phieuThu.SoTienThu + "," + phieuThu.MaKhachHang+ ")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(PhieuThuDTO  phieuThu)
        {
            string sql = "Update  PHIEUTHU set NgayThu =('" + phieuThu.NgayThu + "'),SoTienThu=(" + phieuThu.SoTienThu + ") where MaPhieuThu=" + phieuThu.MaPhieuThu + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(PhieuThuDTO phieuThu)
        {
            try
            {
                string sql = "delete from PHIEUTHU where MaPhieuThu= " + phieuThu.MaPhieuThu + "";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static PhieuThuDTO GetByMa(int ma)
        {
            string sql = "select * from PHIEUTHU where MaPhieuThu=" + ma + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                PhieuThuDTO phieuThu = new PhieuThuDTO();
                phieuThu.MaPhieuThu = (int)dt.Rows[0].ItemArray[0];
                //phieuThu.NgayThu = (DateTime)dt.Rows[0].ItemArray[1];
                //phieuThu.SoTienThu = (int)dt.Rows[0].ItemArray[2];
                //phieuThu.MaKhachHang = (int)dt.Rows[0].ItemArray[3];                
                return phieuThu;
            }

        }
        public static DataTable GetMaPhieuThuCondition(int MaPhieuThu)
        {
            string sql = "select * from PHIEUTHU,KHACHHANG where MaPhieuThu = " + MaPhieuThu;
            return DataAccess.ExcuQuery(sql);
        }
    }
}
