using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using THACO.DAL;

namespace THACO.MODE
{
    class Results
    {
        public List<SPKetQuaNgay> KQN { get; set; }
        public List<SPKetQuaNgay> KQNOrigin { get; set; }
        public DateTime NgaySX { get; set; }
        int[] vitrisps;
        int socbbsp = 7; //Number of Combobox to show product
        int sosp=0;

        public int getSoSp
        {
            get
            {
                return sosp;
            }
        }
        public int TongThucHienNgay
        {
            get
            {
                int temp = 0;
                foreach (var i in KQN)
                {
                      temp += i.ThucHienNgay;
                    
                }
                return temp;
            }
        }
        public int TongKeHoachNgay
        {
            get
            {
                int temp = 0;
                foreach (var i in KQN)
                {

                  temp += i.KeHoachNgay;
                    
                }
                return temp;
            }
        }
        public int TongThucHienThang
        {
            get
            {
                int temp = 0;
                foreach (var i in KQN)
                {
                    
                        temp += i.KetQuaThang;
                    
                }
                return temp;
            }
        }
        public int TongKeHoachThang
        {
            get
            {
                int temp = 0;
                foreach (var i in KQN)
                {
                    
                        temp += i.KeHoachThang;
                    
                }
                return temp;
            }
        }
        public List<SPKetQuaNgay> SelectedSP
        {
            get
            {
                var selectedSP = new List<SPKetQuaNgay>();
                foreach (var i in vitrisps)
                {
                    if (i != 0)
                    {
                        selectedSP.Add(KQN.ElementAt(i));
                    }
                }
                return selectedSP;
            }
        }

        public Results(DateTime NSX)
        {
            List<SPKetQuaNgay> list = updateList(NSX);
            NgaySX = NSX;
            vitrisps = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        }

        public int ViTriSP(int combobox) {
            return vitrisps[combobox];
        }

        public void change(int vitricbb, int vitrisp)
        {
            vitrisps[vitricbb] = vitrisp;
        }

        public List<SPKetQuaNgay> updateList(DateTime NSX)
        {
            Service service = new Service();
            List<SPKetQuaNgay> list = service.LayKetQuaNgay(NSX);
            sosp = list.Count;
            var listOrigin = list;
            KQNOrigin = listOrigin;
            if (list.Count < socbbsp)
               list.Insert(0, new SPKetQuaNgay() { TenSanPham = "                    ", KeHoachNgay = 0, ThucHienNgay = 0, KeHoachThang = 0, KetQuaThang = 0  });
            if (list == null) throw new ArgumentNullException(); if (list == null) throw new ArgumentNullException();
            KQN = list;      
            return list;
        }

        public List<SPKetQuaNgay> getList(DateTime NSX)
        {
            Service service = new Service();
            List<SPKetQuaNgay> list = service.LayKetQuaNgay(NSX);
            //if (list == null) throw new ArgumentNullException();
            return list;
        }

        public bool isChange(List<SPKetQuaNgay> SPKQN)
        {
            if (SPKQN.Count != getSoSp)
                return true;
            int count = 0;
            if (SPKQN.Count < socbbsp) count = 1;


            for (int i = 0; i < SPKQN.Count - 1; i++) 
            {
                if (SPKQN.ElementAt(i).TenSanPham != KQNOrigin.ElementAt(i + count).TenSanPham)
                    return true;

                if (!SPKQN.ElementAt(i).ThucHienNgay.Equals(KQNOrigin.ElementAt(i + count).ThucHienNgay))
                    return true;

                if (!SPKQN.ElementAt(i).KeHoachNgay.Equals(KQNOrigin.ElementAt(i + count).KeHoachNgay))
                    return true;

                if (!SPKQN.ElementAt(i).KeHoachThang.Equals(KQNOrigin.ElementAt(i+count).KeHoachThang))
                    return true;

                if (!SPKQN.ElementAt(i).KetQuaThang.Equals(KQNOrigin.ElementAt(i+count).KetQuaThang))
                    return true;
            }
            return false;
        }

        public int cbbIndex(int p)
        {
            for (int i = 0; i < vitrisps.Length; i++)
            {
                if (p == vitrisps[i]) return i;
            }
            return -1;
        }

        public int[] updatevitri() {
            vitrisps = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            if (KQN != null) {
                int i;
                for(i = 1;i< KQN.Count; i++){
                   vitrisps[i-1] = i;
                   if (i == socbbsp) break;
                }  
            }
            return vitrisps;
        }

        public void xoayvitri() {
            for (int i = 0; i < socbbsp; i++) 
            {
                vitrisps[i] = (vitrisps[i] +1) % (KQN.Count); 
            }
        }
       

    }
}
