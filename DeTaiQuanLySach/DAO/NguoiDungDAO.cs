using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.DTO;
using quanlynhasach.DTO;
using System.Data;

namespace quanlynhasach.DAO
{
    class NguoiDungDAO
    {
        public static bool CheckUser(NguoiDungDTO user)
        {
            string sql = "select * from NGUOIDUNG where TenNguoiDung='" + user.TenNguoiDung + "' and MatKhauNguoiDung='" + user.MatKhau + "' and PhanQuyen='" + user.PhanQuyen + "'";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static DataTable LayDanhSachNguoiDung()
        {
            string sql = "select * from NGUOIDUNG";
            return DataAccess.ExcuQuery(sql);
        }
    }
}
