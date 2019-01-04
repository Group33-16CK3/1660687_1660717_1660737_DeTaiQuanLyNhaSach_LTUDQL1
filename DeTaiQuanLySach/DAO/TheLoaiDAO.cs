using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.DAO;
using quanlynhasach.DTO;
using System.Data;

namespace quanlynhasach.DAO
{
    class TheLoaiDAO
    {
        public static void Insert (TheLoaiDTO theLoai)
        {
            string sql= "insert into THELOAI(TenTheLoai) values('"+theLoai.TenTheLoai+"')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(TheLoaiDTO theLoai)
        {
            string sql = "Update  THELOAI set TenTheLoai ='" + theLoai.TenTheLoai+ "'where MaTheLoai="+theLoai.MaTheLoai+"" ;
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(TheLoaiDTO theLoai)
        {
            try
            {
                string sql = "delete from THELOAI where TenTheLoai= '"+ theLoai.TenTheLoai+"'";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static TheLoaiDTO GetByName(string Name)
        {
            string sql = "select * from THELOAI where TenTheLoai='" + Name + "'";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count== 0)
            {
                return null;
            }
            else
            {
                TheLoaiDTO theLoai = new TheLoaiDTO();
                theLoai.MaTheLoai = (int)dt.Rows[0].ItemArray[0];
                theLoai.TenTheLoai = dt.Rows[0].ItemArray[1].ToString();
                return theLoai;
            }

        }
        public static TheLoaiDTO GetByMa(int Ma)
        {
            string sql = "select * from THELOAI where MaTheLoai="+Ma+"";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TheLoaiDTO theLoai = new TheLoaiDTO();
                theLoai.MaTheLoai = (int)dt.Rows[0].ItemArray[0];
                theLoai.TenTheLoai = dt.Rows[0].ItemArray[1].ToString();
                return theLoai;
            }

        }
        public static DataTable GetAll()
        {
            string sql = "select * from THELOAI";
            return DataAccess.ExcuQuery(sql);            
        }
        
    }
   
}
