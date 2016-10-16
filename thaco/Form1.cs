using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using THACO.MODE;
using THACO.DAL;
using System.Configuration;
using System.Data.SqlClient;
namespace THACO
{
    public partial class Form1 : Form
    {
        Results results;
        int prevSelected = -1;
        bool autoupdate;
        //bool M12R, M34R, M56R, M7R;
        DateTime NSX = DateTime.Now;
        DateTime today = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkConnection();
            button_GetData.Visible = false;
            checkBox1.Visible = false;
            TB_NSX.Visible = false;
            CB_SP1.Enabled = false;
            CB_SP2.Enabled = false;
            CB_SP3.Enabled = false;
            CB_SP4.Enabled = false;
            CB_SP5.Enabled = false;
            CB_SP6.Enabled = false;
            CB_SP7.Enabled = false;

            string[] ports = SerialPort.GetPortNames();
            LISTCOM.Items.AddRange(ports);
            LISTCOM.Text = "COM3";
            COM.PortName = LISTCOM.Text;
            COM.Open();
            TIMER1.Enabled = true;
            TIMER2.Enabled = true;
            TIMER3.Enabled = true;
            //TIMER4.Enabled = true;
            BT_CONNECT.Text = "NGẮT KẾT NỐI";

            CB_SP1.Text = "                    "; CB_SP2.Text = "                    "; CB_SP3.Text = "                    "; CB_SP4.Text = "                    "; CB_SP5.Text = "                    "; CB_SP6.Text = "                    "; CB_SP7.Text = "                    ";
            TB_THN1.Text = "0"; TB_THN2.Text = "0"; TB_THN3.Text = "0"; TB_THN4.Text = "0"; TB_THN5.Text = "0"; TB_THN6.Text = "0"; TB_THN7.Text = "0"; TB_TTHN.Text = "0";
            TB_KHN1.Text = "0"; TB_KHN2.Text = "0"; TB_KHN3.Text = "0"; TB_KHN4.Text = "0"; TB_KHN5.Text = "0"; TB_KHN6.Text = "0"; TB_KHN7.Text = "0"; TB_TKHN.Text = "0";
            TB_THT1.Text = "0"; TB_THT2.Text = "0"; TB_THT3.Text = "0"; TB_THT4.Text = "0"; TB_THT5.Text = "0"; TB_THT6.Text = "0"; TB_THT7.Text = "0"; TB_TTHT.Text = "0";
            TB_KHT1.Text = "0"; TB_KHT2.Text = "0"; TB_KHT3.Text = "0"; TB_KHT4.Text = "0"; TB_KHT5.Text = "0"; TB_KHT6.Text = "0"; TB_KHT7.Text = "0"; TB_TKHT.Text = "0";
            DatNgay();
            results = new Results(NSX);
            results.updatevitri();
            updateData();
        }

        public void checkConnection() {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=nhip-bravo;initial catalog=tdsx_nhip;user id=tdsxadmin;password=123tdsxadmin;multipleactiveresultsets=True;App=EntityFramework";
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Can't connect to database! Please check connection again!", "Alert"
                             , MessageBoxButtons.OK, MessageBoxIcon.Question);
                Environment.Exit(0);
            }
        }

        private void button_GetData_Click(object sender, EventArgs e)
        {
            if (!TB_NSX.ReadOnly)
            {
                string NSXstring = TB_NSX.Text;
                try
                {
                    DateTime NSX = DateTime.Parse(NSXstring);
                }
                catch
                {
                    MessageBox.Show("NHẬP NGÀY KHÔNG HỢP LỆ (YYYY-MM-DD)");
                    CB_SP1.Text = "                    "; CB_SP2.Text = "                    "; CB_SP3.Text = "                    "; CB_SP4.Text = "                    "; CB_SP5.Text = "                    "; CB_SP6.Text = "                    "; CB_SP7.Text = "                    ";
                    TB_THN1.Text = "0"; TB_THN2.Text = "0"; TB_THN3.Text = "0"; TB_THN4.Text = "0"; TB_THN5.Text = "0"; TB_THN6.Text = "0"; TB_THN7.Text = "0"; TB_TTHN.Text = "0";
                    TB_KHN1.Text = "0"; TB_KHN2.Text = "0"; TB_KHN3.Text = "0"; TB_KHN4.Text = "0"; TB_KHN5.Text = "0"; TB_KHN6.Text = "0"; TB_KHN7.Text = "0"; TB_TKHN.Text = "0";
                    TB_THT1.Text = "0"; TB_THT2.Text = "0"; TB_THT3.Text = "0"; TB_THT4.Text = "0"; TB_THT5.Text = "0"; TB_THT6.Text = "0"; TB_THT7.Text = "0"; TB_TTHT.Text = "0";
                    TB_KHT1.Text = "0"; TB_KHT2.Text = "0"; TB_KHT3.Text = "0"; TB_KHT4.Text = "0"; TB_KHT5.Text = "0"; TB_KHT6.Text = "0"; TB_KHT7.Text = "0"; TB_TKHT.Text = "0";
                    return;
                }
            }

                try {
                    results = new Results(NSX);
                    //var list = results.KQN;
                    DatNgay();
                }
                catch {
                    MessageBox.Show("LỖI KẾT NỐI CSDL");
                    CB_SP1.Text = "                    "; CB_SP2.Text = "                    "; CB_SP3.Text = "                    "; CB_SP4.Text = "                    "; CB_SP5.Text = "                    "; CB_SP6.Text = "                    "; CB_SP7.Text = "                    ";
                    TB_THN1.Text = "0"; TB_THN2.Text = "0"; TB_THN3.Text = "0"; TB_THN4.Text = "0"; TB_THN5.Text = "0"; TB_THN6.Text = "0"; TB_THN7.Text = "0"; TB_TTHN.Text = "0";
                    TB_KHN1.Text = "0"; TB_KHN2.Text = "0"; TB_KHN3.Text = "0"; TB_KHN4.Text = "0"; TB_KHN5.Text = "0"; TB_KHN6.Text = "0"; TB_KHN7.Text = "0"; TB_TKHN.Text = "0";
                    TB_THT1.Text = "0"; TB_THT2.Text = "0"; TB_THT3.Text = "0"; TB_THT4.Text = "0"; TB_THT5.Text = "0"; TB_THT6.Text = "0"; TB_THT7.Text = "0"; TB_TTHT.Text = "0";
                    TB_KHT1.Text = "0"; TB_KHT2.Text = "0"; TB_KHT3.Text = "0"; TB_KHT4.Text = "0"; TB_KHT5.Text = "0"; TB_KHT6.Text = "0"; TB_KHT7.Text = "0"; TB_TKHT.Text = "0";
                    return;
                }
                
                updateData();
                //selected item
                CB_SP1.Enter += cbb_enter;
                CB_SP2.Enter += cbb_enter;
                CB_SP3.Enter += cbb_enter;
                CB_SP4.Enter += cbb_enter;
                CB_SP5.Enter += cbb_enter;
                CB_SP6.Enter += cbb_enter;
                CB_SP7.Enter += cbb_enter;

                //hien thi datagridview
                //Service s = new Service();
                //var list2 = s.LayKetQuaNgay(NSX);
                //dataGridView1.DataSource = new BindingSource(list2, "");
          //  }
         //   catch {
         //       MessageBox.Show("NHẬP NGÀY KHÔNG HỢP LỆ (YYYY-MM-DD)");
         //       CB_SP1.Text = "GET DATA"; CB_SP2.Text = "GET DATA"; CB_SP3.Text = "GET DATA"; CB_SP4.Text = "GET DATA"; CB_SP5.Text = "GET DATA"; CB_SP6.Text = "GET DATA"; CB_SP7.Text = "GET DATA";
         //       TB_THN1.Text = "0"; TB_THN2.Text = "0"; TB_THN3.Text = "0"; TB_THN4.Text = "0"; TB_THN5.Text = "0"; TB_THN6.Text = "0"; TB_THN7.Text = "0"; TB_TTHN.Text = "0";
         //       TB_KHN1.Text = "0"; TB_KHN2.Text = "0"; TB_KHN3.Text = "0"; TB_KHN4.Text = "0"; TB_KHN5.Text = "0"; TB_KHN6.Text = "0"; TB_KHN7.Text = "0"; TB_TKHN.Text = "0";
         //       TB_THT1.Text = "0"; TB_THT2.Text = "0"; TB_THT3.Text = "0"; TB_THT4.Text = "0"; TB_THT5.Text = "0"; TB_THT6.Text = "0"; TB_THT7.Text = "0"; TB_TTHT.Text = "0";
         //       TB_KHT1.Text = "0"; TB_KHT2.Text = "0"; TB_KHT3.Text = "0"; TB_KHT4.Text = "0"; TB_KHT5.Text = "0"; TB_KHT6.Text = "0"; TB_KHT7.Text = "0"; TB_TKHT.Text = "0";
         //       return;
         //   }
        }

        public void DatNgay() {
            string ngay = NSX.Day.ToString();
            string thang = NSX.Month.ToString();
            string nam = NSX.Year.ToString();
            TB_NSX2.Text = ngay + "/" + thang + "/" + nam;
            TB_LKT.Text = thang;
        }

        private void comboBoxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb = sender as ComboBox;

            if (cbb.SelectedIndex!=0&&results.cbbIndex(cbb.SelectedIndex)!=-1&&(int)cbb.Tag!=results.cbbIndex(cbb.SelectedIndex))
            {
                MessageBox.Show("ĐÃ CHỌN");
                cbb.SelectedIndex = 0;
                return;
            }
            ChangeDataSelected(cbb);
        }

        private void cbb_enter(object sender, EventArgs e)
        {
            var cbb=sender as ComboBox;
            prevSelected = cbb.SelectedIndex;
        }

        private void BT_CONNECT_Click(object sender, EventArgs e)
        {

        }

        private void TIMER1_Tick(object sender, EventArgs e)
        {
            /*
            if (M12R)
            {
                COM.Write(":?:aqwqx:?:b" + CB_SP3.Text + "w" + CB_SP4.Text + "x:?:c" + CB_SP5.Text + "w" + CB_SP6.Text + "x:?:d" + CB_SP7.Text + "w" +
                          ":?:y" + TB_THN1.Text + "A" + TB_THN2.Text + "B" + TB_THN3.Text + "C" + TB_THN4.Text + "D" + TB_THN5.Text + "E" + TB_THN6.Text + "F" + TB_THN7.Text + "G" + TB_TTHN.Text + "H" +
                                TB_TKHN.Text + "I" + TB_KHN7.Text + "J" + TB_KHN6.Text + "K" + TB_KHN5.Text + "L" + TB_KHN4.Text + "M" + TB_KHN3.Text + "N" + TB_KHN2.Text + "O" + TB_KHN1.Text + "P" +
                                TB_THT1.Text + "a" + TB_THT2.Text + "b" + TB_THT3.Text + "c" + TB_THT4.Text + "d" + TB_THT5.Text + "e" + TB_THT6.Text + "f" + TB_THT7.Text + "g" + TB_TTHT.Text + "h" +
                                TB_TKHT.Text + "i" + TB_KHT7.Text + "j" + TB_KHT6.Text + "k" + TB_KHT5.Text + "l" + TB_KHT4.Text + "m" + TB_KHT3.Text + "n" + TB_KHT2.Text + "o" + TB_KHT1.Text + "p" +
                                DateTime.Now.Month + "Q" + DateTime.Now.Second + "R" + DateTime.Now.Minute + "S" + DateTime.Now.Hour + "T" + DateTime.Now.Month + "U" + DateTime.Now.Day + "V");
                TIMER4.Enabled = false;
                TIMER5.Enabled = true;
                TIMER6.Enabled = false;
                TIMER7.Enabled = false;
                M12R = false;
            }
            else if (M34R)
            {
                COM.Write(":?:a" + CB_SP1.Text + "w" + CB_SP2.Text + "x:?:brwrx:?:c" + CB_SP5.Text + "w" + CB_SP6.Text + "x:?:d" + CB_SP7.Text + "w" +
                          ":?:y" + TB_THN1.Text + "A" + TB_THN2.Text + "B" + TB_THN3.Text + "C" + TB_THN4.Text + "D" + TB_THN5.Text + "E" + TB_THN6.Text + "F" + TB_THN7.Text + "G" + TB_TTHN.Text + "H" +
                                TB_TKHN.Text + "I" + TB_KHN7.Text + "J" + TB_KHN6.Text + "K" + TB_KHN5.Text + "L" + TB_KHN4.Text + "M" + TB_KHN3.Text + "N" + TB_KHN2.Text + "O" + TB_KHN1.Text + "P" +
                                TB_THT1.Text + "a" + TB_THT2.Text + "b" + TB_THT3.Text + "c" + TB_THT4.Text + "d" + TB_THT5.Text + "e" + TB_THT6.Text + "f" + TB_THT7.Text + "g" + TB_TTHT.Text + "h" +
                                TB_TKHT.Text + "i" + TB_KHT7.Text + "j" + TB_KHT6.Text + "k" + TB_KHT5.Text + "l" + TB_KHT4.Text + "m" + TB_KHT3.Text + "n" + TB_KHT2.Text + "o" + TB_KHT1.Text + "p" +
                                DateTime.Now.Month + "Q" + DateTime.Now.Second + "R" + DateTime.Now.Minute + "S" + DateTime.Now.Hour + "T" + DateTime.Now.Month + "U" + DateTime.Now.Day + "V");
                TIMER4.Enabled = false;
                TIMER5.Enabled = false;
                TIMER6.Enabled = true;
                TIMER7.Enabled = false;
                M34R = false;
            }
            else if (M56R)
            {
                COM.Write(":?:a" + CB_SP1.Text + "w" + CB_SP2.Text + "x:?:b" + CB_SP3.Text + "w" + CB_SP4.Text + "x:?:cswsx:?:d" + CB_SP7.Text + "w" +
                          ":?:y" + TB_THN1.Text + "A" + TB_THN2.Text + "B" + TB_THN3.Text + "C" + TB_THN4.Text + "D" + TB_THN5.Text + "E" + TB_THN6.Text + "F" + TB_THN7.Text + "G" + TB_TTHN.Text + "H" +
                                TB_TKHN.Text + "I" + TB_KHN7.Text + "J" + TB_KHN6.Text + "K" + TB_KHN5.Text + "L" + TB_KHN4.Text + "M" + TB_KHN3.Text + "N" + TB_KHN2.Text + "O" + TB_KHN1.Text + "P" +
                                TB_THT1.Text + "a" + TB_THT2.Text + "b" + TB_THT3.Text + "c" + TB_THT4.Text + "d" + TB_THT5.Text + "e" + TB_THT6.Text + "f" + TB_THT7.Text + "g" + TB_TTHT.Text + "h" +
                                TB_TKHT.Text + "i" + TB_KHT7.Text + "j" + TB_KHT6.Text + "k" + TB_KHT5.Text + "l" + TB_KHT4.Text + "m" + TB_KHT3.Text + "n" + TB_KHT2.Text + "o" + TB_KHT1.Text + "p" +
                                DateTime.Now.Month + "Q" + DateTime.Now.Second + "R" + DateTime.Now.Minute + "S" + DateTime.Now.Hour + "T" + DateTime.Now.Month + "U" + DateTime.Now.Day + "V");
                TIMER4.Enabled = false;
                TIMER5.Enabled = false;
                TIMER6.Enabled = false;
                TIMER7.Enabled = true;
                M56R = false;
            }
            else if (M7R)
            {
                COM.Write(":?:a" + CB_SP1.Text + "w" + CB_SP2.Text + "x:?:b" + CB_SP3.Text + "w" + CB_SP4.Text + "x:?:c" + CB_SP5.Text + "w" + CB_SP6.Text + "x:?:dtw" +
                          ":?:y" + TB_THN1.Text + "A" + TB_THN2.Text + "B" + TB_THN3.Text + "C" + TB_THN4.Text + "D" + TB_THN5.Text + "E" + TB_THN6.Text + "F" + TB_THN7.Text + "G" + TB_TTHN.Text + "H" +
                                TB_TKHN.Text + "I" + TB_KHN7.Text + "J" + TB_KHN6.Text + "K" + TB_KHN5.Text + "L" + TB_KHN4.Text + "M" + TB_KHN3.Text + "N" + TB_KHN2.Text + "O" + TB_KHN1.Text + "P" +
                                TB_THT1.Text + "a" + TB_THT2.Text + "b" + TB_THT3.Text + "c" + TB_THT4.Text + "d" + TB_THT5.Text + "e" + TB_THT6.Text + "f" + TB_THT7.Text + "g" + TB_TTHT.Text + "h" +
                                TB_TKHT.Text + "i" + TB_KHT7.Text + "j" + TB_KHT6.Text + "k" + TB_KHT5.Text + "l" + TB_KHT4.Text + "m" + TB_KHT3.Text + "n" + TB_KHT2.Text + "o" + TB_KHT1.Text + "p" +
                                DateTime.Now.Month + "Q" + DateTime.Now.Second + "R" + DateTime.Now.Minute + "S" + DateTime.Now.Hour + "T" + DateTime.Now.Month + "U" + DateTime.Now.Day + "V");
                TIMER4.Enabled = true;
                TIMER5.Enabled = false;
                TIMER6.Enabled = false;
                TIMER7.Enabled = false;
                M7R = false;
            }
            else
                */
            {
                
                TB_TIME.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;
                if (CB_SP1.Text == "                    ") { TB_THN1.Text = "0"; TB_KHN1.Text = "0"; TB_THT1.Text = "0"; TB_KHT1.Text = "0"; }
                if (CB_SP2.Text == "                    ") { TB_THN2.Text = "0"; TB_KHN2.Text = "0"; TB_THT2.Text = "0"; TB_KHT2.Text = "0"; }
                if (CB_SP3.Text == "                    ") { TB_THN3.Text = "0"; TB_KHN3.Text = "0"; TB_THT3.Text = "0"; TB_KHT3.Text = "0"; }
                if (CB_SP4.Text == "                    ") { TB_THN4.Text = "0"; TB_KHN4.Text = "0"; TB_THT4.Text = "0"; TB_KHT4.Text = "0"; }
                if (CB_SP5.Text == "                    ") { TB_THN5.Text = "0"; TB_KHN5.Text = "0"; TB_THT5.Text = "0"; TB_KHT5.Text = "0"; }
                if (CB_SP6.Text == "                    ") { TB_THN6.Text = "0"; TB_KHN6.Text = "0"; TB_THT6.Text = "0"; TB_KHT6.Text = "0"; }
                if (CB_SP7.Text == "                    ") { TB_THN7.Text = "0"; TB_KHN7.Text = "0"; TB_THT7.Text = "0"; TB_KHT7.Text = "0"; }

                COM.Write(":?:a" + CB_SP1.Text + ":??(" + CB_SP2.Text + ":??):?:b" + CB_SP3.Text + ":??(" + CB_SP4.Text + ":??):?:c" + CB_SP5.Text + ":??(" + CB_SP6.Text + ":??):?:d" + CB_SP7.Text + ":??(" +
                          ":?:e" + TB_THN1.Text + "?y:f" + TB_THN2.Text + "?y:g" + TB_THN3.Text + "?y:h" + TB_THN4.Text + "?y:i" + TB_THN5.Text + "?y:j" + TB_THN6.Text + "?y:k" + TB_THN7.Text + "?y:l" + TB_TTHN.Text + "?y:m" +
                                   TB_TKHN.Text + "?y:n" + TB_KHN7.Text + "?y:o" + TB_KHN6.Text + "?y:p" + TB_KHN5.Text + "?y:q" + TB_KHN4.Text + "?y:r" + TB_KHN3.Text + "?y:s" + TB_KHN2.Text + "?y:t" + TB_KHN1.Text + "?y:u" +
                                   TB_THT1.Text + "?z:f" + TB_THT2.Text + "?z:g" + TB_THT3.Text + "?z:h" + TB_THT4.Text + "?z:i" + TB_THT5.Text + "?z:j" + TB_THT6.Text + "?z:k" + TB_THT7.Text + "?z:l" + TB_TTHT.Text + "?z:m" +
                                   TB_TKHT.Text + "?z:n" + TB_KHT7.Text + "?z:o" + TB_KHT6.Text + "?z:p" + TB_KHT5.Text + "?z:q" + TB_KHT4.Text + "?z:r" + TB_KHT3.Text + "?z:s" + TB_KHT2.Text + "?z:t" + TB_KHT1.Text + "?z:u" +
                             DateTime.Now.Month + "?y:v0?y:w" + DateTime.Now.Minute + "?y:x" + DateTime.Now.Hour + "?z:v" + DateTime.Now.Month + "?z:w" + DateTime.Now.Day + "?z:x");
            }
        }

        private void TIMER2_Tick(object sender, EventArgs e)
        {
                checkConnection();
                try
                {
                    
                    if (today.Day != DateTime.Now.Day || today.Month != DateTime.Now.Month || today.Year != DateTime.Now.Year)
                    {
                        today = DateTime.Now;
                        NSX = today;
                        results = new Results(NSX);
                        results.updatevitri();
                        DatNgay();
                    }
                    var list = results.updateList(results.NgaySX);
                    if (list.Count < 8)
                    {
                        results.updatevitri();
                    } 
                    updateData();
                }
                catch
                {
                     return;
                }
        }

        public void updateData()
        {

            var list = results.updateList(results.NgaySX);
            autoupdate = true;     
            CB_SP1.DataSource = new BindingSource(list, "");       
            CB_SP2.DataSource = new BindingSource(list, "");
            CB_SP3.DataSource = new BindingSource(list, "");
            CB_SP4.DataSource = new BindingSource(list, "");
            CB_SP5.DataSource = new BindingSource(list, "");
            CB_SP6.DataSource = new BindingSource(list, "");
            CB_SP7.DataSource = new BindingSource(list, "");
            autoupdate = false;
            
            ChangeDataUpdated(CB_SP1);
            ChangeDataUpdated(CB_SP2);
            ChangeDataUpdated(CB_SP3);
            ChangeDataUpdated(CB_SP4);
            ChangeDataUpdated(CB_SP5);
            ChangeDataUpdated(CB_SP6);
            ChangeDataUpdated(CB_SP7);

            TB_TTHN.Text = results.TongThucHienNgay.ToString();
            TB_TKHN.Text = results.TongKeHoachNgay.ToString();
            TB_TTHT.Text = results.TongThucHienThang.ToString();
            TB_TKHT.Text = results.TongKeHoachThang.ToString();
        }

        public void ChangeDataUpdated(ComboBox cbb)
        {
            var cbbIndex = (int)cbb.Tag;
            cbb.SelectedIndex = results.ViTriSP(cbbIndex);
            ChangeData(cbb);
        }

        public void ChangeDataSelected(ComboBox cbb)
        {
            if (autoupdate) return;  
            var cbbIndex = (int)cbb.Tag;
            results.change(cbbIndex, cbb.SelectedIndex);
            ChangeData(cbb);
        }

        public void ChangeData(ComboBox cbb){
            var cbbIndex = (int)cbb.Tag;
            SPKetQuaNgay sp = cbb.SelectedItem as SPKetQuaNgay;
            # region swtich
            switch (cbbIndex)
            {
                case 0:
                    TB_THN1.Text = sp.ThucHienNgay.ToString();
                    TB_KHN1.Text = sp.KeHoachNgay.ToString();
                    TB_THT1.Text = sp.KetQuaThang.ToString();
                    TB_KHT1.Text = sp.KeHoachThang.ToString();
                    break;
                case 1:
                    TB_THN2.Text = sp.ThucHienNgay.ToString();
                    TB_KHN2.Text = sp.KeHoachNgay.ToString();
                    TB_THT2.Text = sp.KetQuaThang.ToString();
                    TB_KHT2.Text = sp.KeHoachThang.ToString();
                    break;
                case 2:
                    TB_THN3.Text = sp.ThucHienNgay.ToString();
                    TB_KHN3.Text = sp.KeHoachNgay.ToString();
                    TB_THT3.Text = sp.KetQuaThang.ToString();
                    TB_KHT3.Text = sp.KeHoachThang.ToString();
                    break;
                case 3:
                    TB_THN4.Text = sp.ThucHienNgay.ToString();
                    TB_KHN4.Text = sp.KeHoachNgay.ToString();
                    TB_THT4.Text = sp.KetQuaThang.ToString();
                    TB_KHT4.Text = sp.KeHoachThang.ToString();
                    break;
                case 4:
                    TB_THN5.Text = sp.ThucHienNgay.ToString();
                    TB_KHN5.Text = sp.KeHoachNgay.ToString();
                    TB_THT5.Text = sp.KetQuaThang.ToString();
                    TB_KHT5.Text = sp.KeHoachThang.ToString();
                    break;
                case 5:
                    TB_THN6.Text = sp.ThucHienNgay.ToString();
                    TB_KHN6.Text = sp.KeHoachNgay.ToString();
                    TB_THT6.Text = sp.KetQuaThang.ToString();
                    TB_KHT6.Text = sp.KeHoachThang.ToString();
                    break;
                case 6:
                    TB_THN7.Text = sp.ThucHienNgay.ToString();
                    TB_KHN7.Text = sp.KeHoachNgay.ToString();
                    TB_THT7.Text = sp.KetQuaThang.ToString();
                    TB_KHT7.Text = sp.KeHoachThang.ToString();
                    break;
                default: return;
            }
            #endregion swtich
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TB_NSX.ReadOnly = false;
        }

        private void TIMER3_Tick(object sender, EventArgs e)
        {
            var list = results.updateList(results.NgaySX);
            if (list.Count > 8)
            {
                results.xoayvitri();
            }
            updateData();
        }

        private void TIMER4_Tick(object sender, EventArgs e)
        {
            //M12R = true;
        }

        private void TIMER5_Tick(object sender, EventArgs e)
        {
            //M34R = true;
        }

        private void TIMER6_Tick(object sender, EventArgs e)
        {
            //M56R = true;
        }

        private void TIMER7_Tick(object sender, EventArgs e)
        {
            //M7R = true;
        }
    }
}
