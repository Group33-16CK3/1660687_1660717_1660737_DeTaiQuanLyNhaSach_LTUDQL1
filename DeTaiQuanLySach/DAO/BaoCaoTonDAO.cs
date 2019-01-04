using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.DTO;
using quanlynhasach.DTO;
using System.Data;

namespace quanlynhasach.DAO
{
    class BaoCaoTonDAO
    {
        public static void Insert(BaoCaoTonDTO baoCao)
        {
            string sql = "insert into BAOCAOTON(MaSach,NgayPhatSinh,TonDau,PhatSinh,TonCuoi) values(" + baoCao.MaSach + ",'" + baoCao.NgayPhatSinh + "'," + baoCao.TonDau+ ",'"+baoCao.PhatSinh+"',"+baoCao.TonCuoi+")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static DataTable BaoCaoThang(int thang)
        {
            string sql = "select * from BAOCAOTON where Month(NgayPhatSinh) like '%" + thang + "%' ";
            return DataAccess.ExcuQuery(sql);
        } 
    }
}
