using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THACO.DAL
{
    public class SPKetQuaNgay
    {
        public int ID {get;set;}
        public int SanPhamID { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int LoaiSPID { get; set; }
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        public int KeHoachNgay { get; set; }
        public int ThucHienNgay { get; set; }
        public int ChenhLech { get; set; }
        public int KeHoachThang { get; set; }
        public int KetQuaThang { get; set; }
    }
}
