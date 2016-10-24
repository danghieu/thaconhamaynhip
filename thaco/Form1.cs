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
using System.IO;
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
        bool is_push = false;
        string filePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\connectionString.txt";
        TabPage removedTab = null;
        int soCbbSp = 7;//Number of Combobox to show product
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            if (!File.Exists(filePath)) using (File.Create(filePath)) {}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkConnectComPort();
            if (checkConnectDatabase())
            {
                if (removedTab != null)
                {
                    tabShowData.TabPages.Insert(0, removedTab);
                    removedTab = null;
                }
                tabShowData.SelectedTab = tabShowData.TabPages[0];
                txtConnectionString.Text = System.IO.File.ReadAllText(filePath).ToString();
                loadData();
            }
            else
            {
                if (removedTab == null)
                {
                    tabShowData.SelectedTab = tabShowData.TabPages[1];
                    removedTab = tabShowData.TabPages[0];
                    tabShowData.TabPages.Remove(tabShowData.TabPages[0]);
                }
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
                radioButton1.Checked = true;
        }

        public void checkConnectComPort()
        {
            if (!COM.IsOpen)
            {
                string[] ports = SerialPort.GetPortNames();
                LISTCOM.Items.AddRange(ports);
                LISTCOM.Text = "COM3";
                COM.PortName = LISTCOM.Text;
                try
                {
                  // COM.Open();
                }
                catch
                {
                    MessageBox.Show("Can't connect to COM port! Please check connection again!", "Alert"
                                     , MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Environment.Exit(0);
                }
            }            
        }

        public void loadData()
        {
            button_GetData.Visible = false;
            CB_SP1.Enabled = false;
            CB_SP2.Enabled = false;
            CB_SP3.Enabled = false;
            CB_SP4.Enabled = false;
            CB_SP5.Enabled = false;
            CB_SP6.Enabled = false;
            CB_SP7.Enabled = false;
            TIMER1.Enabled = true;
            TIMER2.Enabled = true;
            TIMER3.Enabled = true;
            TIMER4.Enabled = true;
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
            is_push = true;
            setStatus(true,"OK!");
        }
        public bool checkConnectDatabase()
        {
            // Set connectionString
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["tdsx_nhipEntities"].ConnectionString = GetConnectionString();
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = System.IO.File.ReadAllText(filePath);
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Can't connect to database! Please check connection again!", "Alert"
                                 , MessageBoxButtons.OK, MessageBoxIcon.Question);
                System.IO.File.WriteAllText(filePath, string.Empty);
                conn.Close();
                //Environment.Exit(0);
                return false;
            }
            return true;
        }

        private string GetConnectionString()
        {
            string connectionString = "metadata=res://*/DAL.THACOModel2.csdl|res://*/DAL.THACOModel2.ssdl|res://*/DAL.THACOModel2.msl;provider=System.Data.SqlClient;provider connection string=";
            connectionString += "\"" + System.IO.File.ReadAllText(filePath) + "\"";
            return connectionString;
        }

        private void button_GetData_Click(object sender, EventArgs e)
        {
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
        }

        public void DatNgay() {
            string ngay = NSX.Day.ToString();
            string thang = NSX.Month.ToString();
            string nam = NSX.Year.ToString();
            TB_NSX2.Text = ngay + "/" + thang + "/" + nam;
            //TB_NSX2.Text = NSX.ToString();
            TB_LKT.Text = thang;
        }

        private void comboBoxSP_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (is_push)
            {

                //TB_TIME.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;
                //if (CB_SP1.Text == "                    ") { TB_THN1.Text = "0"; TB_KHN1.Text = "0"; TB_THT1.Text = "0"; TB_KHT1.Text = "0"; }
                //if (CB_SP2.Text == "                    ") { TB_THN2.Text = "0"; TB_KHN2.Text = "0"; TB_THT2.Text = "0"; TB_KHT2.Text = "0"; }
                //if (CB_SP3.Text == "                    ") { TB_THN3.Text = "0"; TB_KHN3.Text = "0"; TB_THT3.Text = "0"; TB_KHT3.Text = "0"; }
                //if (CB_SP4.Text == "                    ") { TB_THN4.Text = "0"; TB_KHN4.Text = "0"; TB_THT4.Text = "0"; TB_KHT4.Text = "0"; }
                //if (CB_SP5.Text == "                    ") { TB_THN5.Text = "0"; TB_KHN5.Text = "0"; TB_THT5.Text = "0"; TB_KHT5.Text = "0"; }
                //if (CB_SP6.Text == "                    ") { TB_THN6.Text = "0"; TB_KHN6.Text = "0"; TB_THT6.Text = "0"; TB_KHT6.Text = "0"; }
                //if (CB_SP7.Text == "                    ") { TB_THN7.Text = "0"; TB_KHN7.Text = "0"; TB_THT7.Text = "0"; TB_KHT7.Text = "0"; }

                //COM.Write(":?:a" + CB_SP1.Text + ":??(" + CB_SP2.Text + ":??):?:b" + CB_SP3.Text + ":??(" + CB_SP4.Text + ":??):?:c" + CB_SP5.Text + ":??(" + CB_SP6.Text + ":??):?:d" + CB_SP7.Text + ":??(" +
                //          ":?:e" + TB_THN1.Text + "?y:f" + TB_THN2.Text + "?y:g" + TB_THN3.Text + "?y:h" + TB_THN4.Text + "?y:i" + TB_THN5.Text + "?y:j" + TB_THN6.Text + "?y:k" + TB_THN7.Text + "?y:l" + TB_TTHN.Text + "?y:m" +
                //                   TB_TKHN.Text + "?y:n" + TB_KHN7.Text + "?y:o" + TB_KHN6.Text + "?y:p" + TB_KHN5.Text + "?y:q" + TB_KHN4.Text + "?y:r" + TB_KHN3.Text + "?y:s" + TB_KHN2.Text + "?y:t" + TB_KHN1.Text + "?y:u" +
                //                   TB_THT1.Text + "?z:f" + TB_THT2.Text + "?z:g" + TB_THT3.Text + "?z:h" + TB_THT4.Text + "?z:i" + TB_THT5.Text + "?z:j" + TB_THT6.Text + "?z:k" + TB_THT7.Text + "?z:l" + TB_TTHT.Text + "?z:m" +
                //                   TB_TKHT.Text + "?z:n" + TB_KHT7.Text + "?z:o" + TB_KHT6.Text + "?z:p" + TB_KHT5.Text + "?z:q" + TB_KHT4.Text + "?z:r" + TB_KHT3.Text + "?z:s" + TB_KHT2.Text + "?z:t" + TB_KHT1.Text + "?z:u" +
                //             DateTime.Now.Month + "?y:v0?y:w" + DateTime.Now.Minute + "?y:x" + DateTime.Now.Hour + "?z:v" + DateTime.Now.Month + "?z:w" + DateTime.Now.Day + "?z:x");
                is_push = false;
                
            }
            
        }

        private void TIMER2_Tick(object sender, EventArgs e)
        {
               // checkConnectDatabase();
                try
                {
                    
                    if (today.Day != DateTime.Now.Day || today.Month != DateTime.Now.Month || today.Year != DateTime.Now.Year)
                    {
                        today = DateTime.Now;
                        NSX = today;
                        results = new Results(NSX);
                        results.updatevitri();
                        updateData();
                        DatNgay();
                    }

                    List<SPKetQuaNgay> list = results.getList(results.NgaySX);
                    if (results.isChange(list))
                    {
                        list = results.updateList(results.NgaySX);
                        if (results.getSoSp <= soCbbSp)
                        {
                            results.updatevitri();
                        }
                        updateData();
                        is_push = true;
                       
                    }
                    setStatus(true, "OK");
                    
                        
                }
                catch
                {
                    setStatus(false, "KHÔNG THÊ KÊT NỐI DATABASE");
                    return;
                }
        }

        public void updateData()
        {

            var list = results.KQN;
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

        private void TIMER3_Tick(object sender, EventArgs e)
        {
            //var list = results.updateList(results.NgaySX);
            if (results.getSoSp > soCbbSp)
            {
                results.xoayvitri();
                updateData();
                is_push = true;
            }
        }

        public void setStatus(bool status,string title)
        {
            if (status)
            {
                LB_DBStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LB_DBStatus.ForeColor = System.Drawing.Color.Red;
            }
            LB_DBStatus.Text = title;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;
            if (radioButton1.Checked)
            {
                connectionString = txtConnectionString.Text;
            }
            else
            {
                connectionString += "Data Source=" + txtServerName.Text + ";";
                connectionString += "Initial Catalog=" + txtDatabaseName.Text + ";";
                connectionString += "User ID=" + txtServerName.Text + ";Password=" + txtDatabaseName.Text + ";";
                connectionString += "Integrated Security=True";
            }
            System.IO.File.WriteAllText(filePath, connectionString);
            this.Form1_Load(this, null);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lblServerName.Hide();
                txtServerName.Hide();
                lblDatabaseName.Hide();
                txtDatabaseName.Hide();
                lblUserName.Hide();
                txtUserName.Hide();
                lblPassword.Hide();
                txtPassword.Hide();
                lblConnectionString.Show();
                txtConnectionString.Show();
            }
            else
            {
                lblConnectionString.Hide();
                txtConnectionString.Hide();
                lblServerName.Show();
                txtServerName.Show();
                lblDatabaseName.Show();
                txtDatabaseName.Show();
                lblUserName.Show();
                txtUserName.Show();
                lblPassword.Show();
                txtPassword.Show();
            }
        }

    }
}
