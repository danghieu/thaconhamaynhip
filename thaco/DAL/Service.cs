using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using System.ComponentModel;

namespace THACO.DAL
{
    public class Service
    {
        public List<SPKetQuaNgay> LayKetQuaNgay(DateTime datetime)
        {
            DataTable table = GetData(datetime);
            var List = new List<SPKetQuaNgay>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                var values = row.ItemArray;
                var KetQuaNgay = new SPKetQuaNgay()
                {
                    ID = changeInt(values[0].ToString()),
                    SanPhamID = changeInt(values[1].ToString()),
                    MaSanPham = values[2].ToString(),
                    TenSanPham = values[3].ToString(),
                    LoaiSPID = changeInt(values[4].ToString()),
                    MaLoaiSP = values[5].ToString(),
                    TenLoaiSP = values[6].ToString(),
                    KeHoachNgay = changeInt(values[7].ToString()),
                    ThucHienNgay = changeInt(values[8].ToString()),
                    ChenhLech = changeInt(values[9].ToString()),
                    KeHoachThang = changeInt(values[10].ToString()),
                    KetQuaThang = changeInt(values[11].ToString())
                };
                List.Add(KetQuaNgay);
            }
            return List;
        }

        public int changeInt(string s) {
            int a = 0;
            try
            {
                a = int.Parse(s);
            }
            catch {
                a = 0;
            }
            return a;

        }

        public DataTable GetData(DateTime datetime) {
            DataTable datatable;

            tdsx_nhipEntities te = new tdsx_nhipEntities();
            datatable = new DataTable();
            datatable = ToDataTable(te.KetQua_Ngay(datetime).ToList());
           
            return datatable;
            
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
