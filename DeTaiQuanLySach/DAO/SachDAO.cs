using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using quanlynhasach.DTO;
using quanlynhasach.DTO;

namespace quanlynhasach.DAO
{
    class SachDAO
    {
        static public DataTable SelectSachLikeName(SachDTO sach)
        {
            string sql = "select * from SACH where TenSach like '%" + sach.TenSach + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectSachLikeMaTheLoai(SachDTO sach)
        {
            string sql = "select * from SACH where MaTheLoai like '%" + sach.MaTheLoai + "%'";
            return DataAccess.ExcuQuery(sql);
        }
       
        static public DataTable SelectSachLikeTacGia(SachDTO sach)
        {
            string sql = "select * from SACH where TacGia like '%" + sach.TacGia + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectAll()
        {
            string sql = "select* from SACH";
            DataTable dt = DataAccess.ExcuQuery(sql);
            return dt;
        }
        static public void Insert(SachDTO sach)
        {
            string sql = "insert into SACH(TenSach,TacGia,MaTheLoai,GiaBan,SoLuongTon) values('" + sach.TenSach + "','" + sach.TacGia + "'," + sach.MaTheLoai + "," + sach.GiaBan + "," + sach.SoLuongTon + ")";
            DataAccess.ExcuNonQuery(sql);
           
        }
        public static bool Delete(SachDTO sach)
        {
            try
            {
                string sql = "delete from SACH where MaSach= " + sach.MaSach + "";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public void Update(SachDTO sach)
        {
            string sql = "update  SACH set TenSach=('" + sach.TenSach + "'),TacGia=('" + sach.TacGia + "'),MaTheLoai=(" + sach.MaTheLoai + "),GiaBan=(" + sach.GiaBan + "),SoLuongTon=("+ sach.SoLuongTon +") where MaSach = "+sach.MaSach+"";
            DataAccess.ExcuNonQuery(sql);
        }
        static public void UpdateSoLuongTon(SachDTO sach)
        {
            string sql = "update SACH set SoLuongTon=(" + sach.SoLuongTon + ") where MaSach = "+sach.MaSach+"";
            DataAccess.ExcuNonQuery(sql);
        }
        static public SachDTO SelectByName(string name)
        {
            string sql = "select * from SACH where TenSach='" + name + "'";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else 
            {
                SachDTO s = new SachDTO();
                s.TenSach = dt.Rows[0].ItemArray[0].ToString();
                return s;
            }
        }
        static public SachDTO SelectByMa(int ma)
        {
            string sql = "select * from SACH where MaSach=" + ma + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                SachDTO s = new SachDTO();
                s.MaSach = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                return s;
            }
        }
        public static DataTable GetSoLuongTonCondition(int SoLuongTon)
        {
            string sql = "select * from SACH where SoLuongTon < " + SoLuongTon;
            return DataAccess.ExcuQuery(sql);
        }

        internal static object SelectPNByName(object p)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        
    }
}
