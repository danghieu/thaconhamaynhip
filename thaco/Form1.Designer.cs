namespace THACO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.TIMER1 = new System.Windows.Forms.Timer(this.components);
            this.TIMER2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TB_TIME = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BT_CONNECT = new System.Windows.Forms.Button();
            this.LISTCOM = new System.Windows.Forms.ComboBox();
            this.button_GetData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NSX = new System.Windows.Forms.TextBox();
            this.TB_LKT = new System.Windows.Forms.TextBox();
            this.TB_NSX2 = new System.Windows.Forms.TextBox();
            this.TB_TKHT = new System.Windows.Forms.TextBox();
            this.TB_TTHT = new System.Windows.Forms.TextBox();
            this.TB_TKHN = new System.Windows.Forms.TextBox();
            this.TB_TTHN = new System.Windows.Forms.TextBox();
            this.TB_KHT7 = new System.Windows.Forms.TextBox();
            this.TB_KHT6 = new System.Windows.Forms.TextBox();
            this.TB_KHT5 = new System.Windows.Forms.TextBox();
            this.TB_KHT4 = new System.Windows.Forms.TextBox();
            this.TB_KHT3 = new System.Windows.Forms.TextBox();
            this.TB_KHT2 = new System.Windows.Forms.TextBox();
            this.TB_KHT1 = new System.Windows.Forms.TextBox();
            this.TB_THT7 = new System.Windows.Forms.TextBox();
            this.TB_THT6 = new System.Windows.Forms.TextBox();
            this.TB_THT5 = new System.Windows.Forms.TextBox();
            this.TB_THT4 = new System.Windows.Forms.TextBox();
            this.TB_THT3 = new System.Windows.Forms.TextBox();
            this.TB_THT2 = new System.Windows.Forms.TextBox();
            this.TB_THT1 = new System.Windows.Forms.TextBox();
            this.TB_KHN7 = new System.Windows.Forms.TextBox();
            this.TB_KHN6 = new System.Windows.Forms.TextBox();
            this.TB_KHN5 = new System.Windows.Forms.TextBox();
            this.TB_KHN4 = new System.Windows.Forms.TextBox();
            this.TB_KHN3 = new System.Windows.Forms.TextBox();
            this.TB_KHN2 = new System.Windows.Forms.TextBox();
            this.TB_KHN1 = new System.Windows.Forms.TextBox();
            this.TB_THN7 = new System.Windows.Forms.TextBox();
            this.TB_THN6 = new System.Windows.Forms.TextBox();
            this.TB_THN5 = new System.Windows.Forms.TextBox();
            this.TB_THN4 = new System.Windows.Forms.TextBox();
            this.TB_THN3 = new System.Windows.Forms.TextBox();
            this.TB_THN2 = new System.Windows.Forms.TextBox();
            this.TB_THN1 = new System.Windows.Forms.TextBox();
            this.CB_SP7 = new System.Windows.Forms.ComboBox();
            this.CB_SP6 = new System.Windows.Forms.ComboBox();
            this.CB_SP5 = new System.Windows.Forms.ComboBox();
            this.CB_SP4 = new System.Windows.Forms.ComboBox();
            this.CB_SP3 = new System.Windows.Forms.ComboBox();
            this.CB_SP2 = new System.Windows.Forms.ComboBox();
            this.CB_SP1 = new System.Windows.Forms.ComboBox();
            this.TIMER3 = new System.Windows.Forms.Timer(this.components);
            this.TIMER4 = new System.Windows.Forms.Timer(this.components);
            this.TIMER5 = new System.Windows.Forms.Timer(this.components);
            this.TIMER6 = new System.Windows.Forms.Timer(this.components);
            this.TIMER7 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TIMER1
            // 
            this.TIMER1.Interval = 15000;
            this.TIMER1.Tick += new System.EventHandler(this.TIMER1_Tick);
            // 
            // TIMER2
            // 
            this.TIMER2.Interval = 10000;
            this.TIMER2.Tick += new System.EventHandler(this.TIMER2_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.TB_TIME);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.BT_CONNECT);
            this.tabPage1.Controls.Add(this.LISTCOM);
            this.tabPage1.Controls.Add(this.button_GetData);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TB_NSX);
            this.tabPage1.Controls.Add(this.TB_LKT);
            this.tabPage1.Controls.Add(this.TB_NSX2);
            this.tabPage1.Controls.Add(this.TB_TKHT);
            this.tabPage1.Controls.Add(this.TB_TTHT);
            this.tabPage1.Controls.Add(this.TB_TKHN);
            this.tabPage1.Controls.Add(this.TB_TTHN);
            this.tabPage1.Controls.Add(this.TB_KHT7);
            this.tabPage1.Controls.Add(this.TB_KHT6);
            this.tabPage1.Controls.Add(this.TB_KHT5);
            this.tabPage1.Controls.Add(this.TB_KHT4);
            this.tabPage1.Controls.Add(this.TB_KHT3);
            this.tabPage1.Controls.Add(this.TB_KHT2);
            this.tabPage1.Controls.Add(this.TB_KHT1);
            this.tabPage1.Controls.Add(this.TB_THT7);
            this.tabPage1.Controls.Add(this.TB_THT6);
            this.tabPage1.Controls.Add(this.TB_THT5);
            this.tabPage1.Controls.Add(this.TB_THT4);
            this.tabPage1.Controls.Add(this.TB_THT3);
            this.tabPage1.Controls.Add(this.TB_THT2);
            this.tabPage1.Controls.Add(this.TB_THT1);
            this.tabPage1.Controls.Add(this.TB_KHN7);
            this.tabPage1.Controls.Add(this.TB_KHN6);
            this.tabPage1.Controls.Add(this.TB_KHN5);
            this.tabPage1.Controls.Add(this.TB_KHN4);
            this.tabPage1.Controls.Add(this.TB_KHN3);
            this.tabPage1.Controls.Add(this.TB_KHN2);
            this.tabPage1.Controls.Add(this.TB_KHN1);
            this.tabPage1.Controls.Add(this.TB_THN7);
            this.tabPage1.Controls.Add(this.TB_THN6);
            this.tabPage1.Controls.Add(this.TB_THN5);
            this.tabPage1.Controls.Add(this.TB_THN4);
            this.tabPage1.Controls.Add(this.TB_THN3);
            this.tabPage1.Controls.Add(this.TB_THN2);
            this.tabPage1.Controls.Add(this.TB_THN1);
            this.tabPage1.Controls.Add(this.CB_SP7);
            this.tabPage1.Controls.Add(this.CB_SP6);
            this.tabPage1.Controls.Add(this.CB_SP5);
            this.tabPage1.Controls.Add(this.CB_SP4);
            this.tabPage1.Controls.Add(this.CB_SP3);
            this.tabPage1.Controls.Add(this.CB_SP2);
            this.tabPage1.Controls.Add(this.CB_SP1);
            this.tabPage1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Navy;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONTROL TAB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(369, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 19);
            this.checkBox1.TabIndex = 111;
            this.checkBox1.Text = "NHẬP TAY";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TB_TIME
            // 
            this.TB_TIME.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TIME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TB_TIME.Location = new System.Drawing.Point(475, 49);
            this.TB_TIME.Name = "TB_TIME";
            this.TB_TIME.ReadOnly = true;
            this.TB_TIME.Size = new System.Drawing.Size(100, 23);
            this.TB_TIME.TabIndex = 110;
            this.TB_TIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(8, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 32);
            this.label10.TabIndex = 109;
            this.label10.Text = "NHÀ MÁY NHÍP ÔTÔ";
            // 
            // BT_CONNECT
            // 
            this.BT_CONNECT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CONNECT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BT_CONNECT.Location = new System.Drawing.Point(369, 362);
            this.BT_CONNECT.Name = "BT_CONNECT";
            this.BT_CONNECT.Size = new System.Drawing.Size(206, 24);
            this.BT_CONNECT.TabIndex = 108;
            this.BT_CONNECT.Text = "KẾT NỐI";
            this.BT_CONNECT.UseVisualStyleBackColor = true;
            this.BT_CONNECT.Click += new System.EventHandler(this.BT_CONNECT_Click);
            // 
            // LISTCOM
            // 
            this.LISTCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTCOM.FormattingEnabled = true;
            this.LISTCOM.Location = new System.Drawing.Point(157, 362);
            this.LISTCOM.Name = "LISTCOM";
            this.LISTCOM.Size = new System.Drawing.Size(206, 24);
            this.LISTCOM.TabIndex = 107;
            // 
            // button_GetData
            // 
            this.button_GetData.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_GetData.Location = new System.Drawing.Point(369, 362);
            this.button_GetData.Name = "button_GetData";
            this.button_GetData.Size = new System.Drawing.Size(206, 23);
            this.button_GetData.TabIndex = 106;
            this.button_GetData.Text = "LẤY DỮ LIỆU";
            this.button_GetData.UseVisualStyleBackColor = true;
            this.button_GetData.Click += new System.EventHandler(this.button_GetData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(11, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 105;
            this.label9.Text = "TỔNG CỘNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(475, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "Kế hoạch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(366, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 103;
            this.label7.Text = "Thực hiện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(260, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 102;
            this.label6.Text = "Kế hoạch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(154, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 101;
            this.label5.Text = "Thực hiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(366, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "LUỸ KẾ THÁNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(154, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 99;
            this.label3.Text = "NGÀY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(155, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "BẢNG THEO DÕI KẾT QUẢ NGÀY SẢN XUẤT";
            // 
            // TB_NSX
            // 
            this.TB_NSX.ForeColor = System.Drawing.Color.Navy;
            this.TB_NSX.Location = new System.Drawing.Point(475, 12);
            this.TB_NSX.Name = "TB_NSX";
            this.TB_NSX.ReadOnly = true;
            this.TB_NSX.Size = new System.Drawing.Size(100, 23);
            this.TB_NSX.TabIndex = 96;
            this.TB_NSX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_LKT
            // 
            this.TB_LKT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LKT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TB_LKT.Location = new System.Drawing.Point(475, 87);
            this.TB_LKT.Name = "TB_LKT";
            this.TB_LKT.ReadOnly = true;
            this.TB_LKT.Size = new System.Drawing.Size(100, 23);
            this.TB_LKT.TabIndex = 95;
            this.TB_LKT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_NSX2
            // 
            this.TB_NSX2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NSX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TB_NSX2.Location = new System.Drawing.Point(263, 87);
            this.TB_NSX2.Name = "TB_NSX2";
            this.TB_NSX2.ReadOnly = true;
            this.TB_NSX2.Size = new System.Drawing.Size(100, 23);
            this.TB_NSX2.TabIndex = 94;
            this.TB_NSX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_TKHT
            // 
            this.TB_TKHT.Location = new System.Drawing.Point(475, 328);
            this.TB_TKHT.Name = "TB_TKHT";
            this.TB_TKHT.ReadOnly = true;
            this.TB_TKHT.Size = new System.Drawing.Size(100, 23);
            this.TB_TKHT.TabIndex = 93;
            this.TB_TKHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_TTHT
            // 
            this.TB_TTHT.Location = new System.Drawing.Point(369, 328);
            this.TB_TTHT.Name = "TB_TTHT";
            this.TB_TTHT.ReadOnly = true;
            this.TB_TTHT.Size = new System.Drawing.Size(100, 23);
            this.TB_TTHT.TabIndex = 92;
            this.TB_TTHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_TKHN
            // 
            this.TB_TKHN.Location = new System.Drawing.Point(263, 328);
            this.TB_TKHN.Name = "TB_TKHN";
            this.TB_TKHN.ReadOnly = true;
            this.TB_TKHN.Size = new System.Drawing.Size(100, 23);
            this.TB_TKHN.TabIndex = 91;
            this.TB_TKHN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_TTHN
            // 
            this.TB_TTHN.Location = new System.Drawing.Point(157, 328);
            this.TB_TTHN.Name = "TB_TTHN";
            this.TB_TTHN.ReadOnly = true;
            this.TB_TTHN.Size = new System.Drawing.Size(100, 23);
            this.TB_TTHN.TabIndex = 90;
            this.TB_TTHN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHT7
            // 
            this.TB_KHT7.Location = new System.Drawing.Point(475, 292);
            this.TB_KHT7.Name = "TB_KHT7";
            this.TB_KHT7.ReadOnly = true;
            this.TB_KHT7.Size = new System.Drawing.Size(100, 23);
            this.TB_KHT7.TabIndex = 89;
            this.TB_KHT7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHT6
            // 
            this.TB_KHT6.Location = new System.Drawing.Point(475, 265);
            this.TB_KHT6.Name = "TB_KHT6";
            this.TB_KHT6.ReadOnly = true;
            this.TB_KHT6.Size = new System.Drawing.Size(100, 23);
            this.TB_KHT6.TabIndex = 88;
            this.TB_KHT6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHT5
            // 
            this.TB_KHT5.Location = new System.Drawing.Point(475, 238);
            this.TB_KHT5.Name = "TB_KHT5";
            this.TB_KHT5.ReadOnly = true;
            this.TB_KHT5.Size = new System.Drawing.Size(100, 23);
            this.TB_KHT5.TabIndex = 87;
            this.TB_KHT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHT4
            // 
            this.TB_KHT4.Location = new System.Drawing.Point(475, 211);
            this.TB_KHT4.Name = "TB_KHT4";
            this.TB_KHT4.ReadOnly = true;
            this.TB_KHT4.Size = new System.Drawing.Size(100, 23);
            this.TB_KHT4.TabIndex = 86;
            this.TB_KHT4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHT3
            // 
            this.TB_KHT3.Location = new System.Drawing.Point(475, 184);
            this.TB_KHT3.Name = "TB_KHT3";
            this.TB_KHT3.ReadOnly = true;
            this.TB_KHT3.Size = new System.Drawing.Size(100, 23);
            this.TB_KHT3.TabIndex = 85;
            this.TB_KHT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHT2
            // 
            this.TB_KHT2.Location = new System.Drawing.Point(475, 157);
            this.TB_KHT2.Name = "TB_KHT2";
            this.TB_KHT2.ReadOnly = true;
            this.TB_KHT2.Size = new System.Drawing.Size(100, 23);
            this.TB_KHT2.TabIndex = 84;
            this.TB_KHT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHT1
            // 
            this.TB_KHT1.Location = new System.Drawing.Point(475, 130);
            this.TB_KHT1.Name = "TB_KHT1";
            this.TB_KHT1.ReadOnly = true;
            this.TB_KHT1.Size = new System.Drawing.Size(100, 23);
            this.TB_KHT1.TabIndex = 83;
            this.TB_KHT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THT7
            // 
            this.TB_THT7.Location = new System.Drawing.Point(369, 292);
            this.TB_THT7.Name = "TB_THT7";
            this.TB_THT7.ReadOnly = true;
            this.TB_THT7.Size = new System.Drawing.Size(100, 23);
            this.TB_THT7.TabIndex = 82;
            this.TB_THT7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THT6
            // 
            this.TB_THT6.Location = new System.Drawing.Point(369, 265);
            this.TB_THT6.Name = "TB_THT6";
            this.TB_THT6.ReadOnly = true;
            this.TB_THT6.Size = new System.Drawing.Size(100, 23);
            this.TB_THT6.TabIndex = 81;
            this.TB_THT6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THT5
            // 
            this.TB_THT5.Location = new System.Drawing.Point(369, 238);
            this.TB_THT5.Name = "TB_THT5";
            this.TB_THT5.ReadOnly = true;
            this.TB_THT5.Size = new System.Drawing.Size(100, 23);
            this.TB_THT5.TabIndex = 80;
            this.TB_THT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THT4
            // 
            this.TB_THT4.Location = new System.Drawing.Point(369, 211);
            this.TB_THT4.Name = "TB_THT4";
            this.TB_THT4.ReadOnly = true;
            this.TB_THT4.Size = new System.Drawing.Size(100, 23);
            this.TB_THT4.TabIndex = 79;
            this.TB_THT4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THT3
            // 
            this.TB_THT3.Location = new System.Drawing.Point(369, 184);
            this.TB_THT3.Name = "TB_THT3";
            this.TB_THT3.ReadOnly = true;
            this.TB_THT3.Size = new System.Drawing.Size(100, 23);
            this.TB_THT3.TabIndex = 78;
            this.TB_THT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THT2
            // 
            this.TB_THT2.Location = new System.Drawing.Point(369, 157);
            this.TB_THT2.Name = "TB_THT2";
            this.TB_THT2.ReadOnly = true;
            this.TB_THT2.Size = new System.Drawing.Size(100, 23);
            this.TB_THT2.TabIndex = 77;
            this.TB_THT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THT1
            // 
            this.TB_THT1.Location = new System.Drawing.Point(369, 130);
            this.TB_THT1.Name = "TB_THT1";
            this.TB_THT1.ReadOnly = true;
            this.TB_THT1.Size = new System.Drawing.Size(100, 23);
            this.TB_THT1.TabIndex = 76;
            this.TB_THT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHN7
            // 
            this.TB_KHN7.Location = new System.Drawing.Point(263, 292);
            this.TB_KHN7.Name = "TB_KHN7";
            this.TB_KHN7.ReadOnly = true;
            this.TB_KHN7.Size = new System.Drawing.Size(100, 23);
            this.TB_KHN7.TabIndex = 75;
            this.TB_KHN7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHN6
            // 
            this.TB_KHN6.Location = new System.Drawing.Point(263, 265);
            this.TB_KHN6.Name = "TB_KHN6";
            this.TB_KHN6.ReadOnly = true;
            this.TB_KHN6.Size = new System.Drawing.Size(100, 23);
            this.TB_KHN6.TabIndex = 74;
            this.TB_KHN6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHN5
            // 
            this.TB_KHN5.Location = new System.Drawing.Point(263, 238);
            this.TB_KHN5.Name = "TB_KHN5";
            this.TB_KHN5.ReadOnly = true;
            this.TB_KHN5.Size = new System.Drawing.Size(100, 23);
            this.TB_KHN5.TabIndex = 73;
            this.TB_KHN5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHN4
            // 
            this.TB_KHN4.Location = new System.Drawing.Point(263, 211);
            this.TB_KHN4.Name = "TB_KHN4";
            this.TB_KHN4.ReadOnly = true;
            this.TB_KHN4.Size = new System.Drawing.Size(100, 23);
            this.TB_KHN4.TabIndex = 72;
            this.TB_KHN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHN3
            // 
            this.TB_KHN3.Location = new System.Drawing.Point(263, 184);
            this.TB_KHN3.Name = "TB_KHN3";
            this.TB_KHN3.ReadOnly = true;
            this.TB_KHN3.Size = new System.Drawing.Size(100, 23);
            this.TB_KHN3.TabIndex = 71;
            this.TB_KHN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHN2
            // 
            this.TB_KHN2.Location = new System.Drawing.Point(263, 157);
            this.TB_KHN2.Name = "TB_KHN2";
            this.TB_KHN2.ReadOnly = true;
            this.TB_KHN2.Size = new System.Drawing.Size(100, 23);
            this.TB_KHN2.TabIndex = 70;
            this.TB_KHN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_KHN1
            // 
            this.TB_KHN1.Location = new System.Drawing.Point(263, 130);
            this.TB_KHN1.Name = "TB_KHN1";
            this.TB_KHN1.ReadOnly = true;
            this.TB_KHN1.Size = new System.Drawing.Size(100, 23);
            this.TB_KHN1.TabIndex = 69;
            this.TB_KHN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THN7
            // 
            this.TB_THN7.Location = new System.Drawing.Point(157, 292);
            this.TB_THN7.Name = "TB_THN7";
            this.TB_THN7.ReadOnly = true;
            this.TB_THN7.Size = new System.Drawing.Size(100, 23);
            this.TB_THN7.TabIndex = 68;
            this.TB_THN7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THN6
            // 
            this.TB_THN6.Location = new System.Drawing.Point(157, 265);
            this.TB_THN6.Name = "TB_THN6";
            this.TB_THN6.ReadOnly = true;
            this.TB_THN6.Size = new System.Drawing.Size(100, 23);
            this.TB_THN6.TabIndex = 67;
            this.TB_THN6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THN5
            // 
            this.TB_THN5.Location = new System.Drawing.Point(157, 238);
            this.TB_THN5.Name = "TB_THN5";
            this.TB_THN5.ReadOnly = true;
            this.TB_THN5.Size = new System.Drawing.Size(100, 23);
            this.TB_THN5.TabIndex = 66;
            this.TB_THN5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THN4
            // 
            this.TB_THN4.Location = new System.Drawing.Point(157, 211);
            this.TB_THN4.Name = "TB_THN4";
            this.TB_THN4.ReadOnly = true;
            this.TB_THN4.Size = new System.Drawing.Size(100, 23);
            this.TB_THN4.TabIndex = 65;
            this.TB_THN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THN3
            // 
            this.TB_THN3.Location = new System.Drawing.Point(157, 184);
            this.TB_THN3.Name = "TB_THN3";
            this.TB_THN3.ReadOnly = true;
            this.TB_THN3.Size = new System.Drawing.Size(100, 23);
            this.TB_THN3.TabIndex = 64;
            this.TB_THN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THN2
            // 
            this.TB_THN2.Location = new System.Drawing.Point(157, 157);
            this.TB_THN2.Name = "TB_THN2";
            this.TB_THN2.ReadOnly = true;
            this.TB_THN2.Size = new System.Drawing.Size(100, 23);
            this.TB_THN2.TabIndex = 63;
            this.TB_THN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_THN1
            // 
            this.TB_THN1.Location = new System.Drawing.Point(157, 130);
            this.TB_THN1.Name = "TB_THN1";
            this.TB_THN1.ReadOnly = true;
            this.TB_THN1.Size = new System.Drawing.Size(100, 23);
            this.TB_THN1.TabIndex = 62;
            this.TB_THN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CB_SP7
            // 
            this.CB_SP7.DisplayMember = "TenSanPham";
            this.CB_SP7.FormattingEnabled = true;
            this.CB_SP7.Location = new System.Drawing.Point(14, 292);
            this.CB_SP7.Name = "CB_SP7";
            this.CB_SP7.Size = new System.Drawing.Size(121, 23);
            this.CB_SP7.TabIndex = 61;
            this.CB_SP7.Tag = 6;
            this.CB_SP7.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP6
            // 
            this.CB_SP6.DisplayMember = "TenSanPham";
            this.CB_SP6.FormattingEnabled = true;
            this.CB_SP6.Location = new System.Drawing.Point(14, 265);
            this.CB_SP6.Name = "CB_SP6";
            this.CB_SP6.Size = new System.Drawing.Size(121, 23);
            this.CB_SP6.TabIndex = 60;
            this.CB_SP6.Tag = 5;
            this.CB_SP6.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP5
            // 
            this.CB_SP5.DisplayMember = "TenSanPham";
            this.CB_SP5.FormattingEnabled = true;
            this.CB_SP5.Location = new System.Drawing.Point(14, 238);
            this.CB_SP5.Name = "CB_SP5";
            this.CB_SP5.Size = new System.Drawing.Size(121, 23);
            this.CB_SP5.TabIndex = 59;
            this.CB_SP5.Tag = 4;
            this.CB_SP5.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP4
            // 
            this.CB_SP4.DisplayMember = "TenSanPham";
            this.CB_SP4.FormattingEnabled = true;
            this.CB_SP4.Location = new System.Drawing.Point(14, 211);
            this.CB_SP4.Name = "CB_SP4";
            this.CB_SP4.Size = new System.Drawing.Size(121, 23);
            this.CB_SP4.TabIndex = 58;
            this.CB_SP4.Tag = 3;
            this.CB_SP4.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP3
            // 
            this.CB_SP3.DisplayMember = "TenSanPham";
            this.CB_SP3.FormattingEnabled = true;
            this.CB_SP3.Location = new System.Drawing.Point(14, 184);
            this.CB_SP3.Name = "CB_SP3";
            this.CB_SP3.Size = new System.Drawing.Size(121, 23);
            this.CB_SP3.TabIndex = 57;
            this.CB_SP3.Tag = 2;
            this.CB_SP3.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP2
            // 
            this.CB_SP2.DisplayMember = "TenSanPham";
            this.CB_SP2.FormattingEnabled = true;
            this.CB_SP2.Location = new System.Drawing.Point(14, 157);
            this.CB_SP2.Name = "CB_SP2";
            this.CB_SP2.Size = new System.Drawing.Size(121, 23);
            this.CB_SP2.TabIndex = 56;
            this.CB_SP2.Tag = 1;
            this.CB_SP2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // CB_SP1
            // 
            this.CB_SP1.DisplayMember = "TenSanPham";
            this.CB_SP1.FormattingEnabled = true;
            this.CB_SP1.Location = new System.Drawing.Point(14, 130);
            this.CB_SP1.Name = "CB_SP1";
            this.CB_SP1.Size = new System.Drawing.Size(121, 23);
            this.CB_SP1.TabIndex = 55;
            this.CB_SP1.Tag = 0;
            this.CB_SP1.SelectedIndexChanged += new System.EventHandler(this.comboBoxSP_SelectedIndexChanged);
            // 
            // TIMER3
            // 
            this.TIMER3.Interval = 60000;
            this.TIMER3.Tick += new System.EventHandler(this.TIMER3_Tick);
            // 
            // TIMER4
            // 
            this.TIMER4.Interval = 3600000;
            this.TIMER4.Tick += new System.EventHandler(this.TIMER4_Tick);
            // 
            // TIMER5
            // 
            this.TIMER5.Interval = 3600000;
            this.TIMER5.Tick += new System.EventHandler(this.TIMER5_Tick);
            // 
            // TIMER6
            // 
            this.TIMER6.Interval = 3600000;
            this.TIMER6.Tick += new System.EventHandler(this.TIMER6_Tick);
            // 
            // TIMER7
            // 
            this.TIMER7.Interval = 3600000;
            this.TIMER7.Tick += new System.EventHandler(this.TIMER7_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 425);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THACO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Timer TIMER1;
        private System.Windows.Forms.Timer TIMER2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BT_CONNECT;
        private System.Windows.Forms.ComboBox LISTCOM;
        private System.Windows.Forms.Button button_GetData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NSX;
        private System.Windows.Forms.TextBox TB_LKT;
        private System.Windows.Forms.TextBox TB_NSX2;
        private System.Windows.Forms.TextBox TB_TKHT;
        private System.Windows.Forms.TextBox TB_TTHT;
        private System.Windows.Forms.TextBox TB_TKHN;
        private System.Windows.Forms.TextBox TB_TTHN;
        private System.Windows.Forms.TextBox TB_KHT7;
        private System.Windows.Forms.TextBox TB_KHT6;
        private System.Windows.Forms.TextBox TB_KHT5;
        private System.Windows.Forms.TextBox TB_KHT4;
        private System.Windows.Forms.TextBox TB_KHT3;
        private System.Windows.Forms.TextBox TB_KHT2;
        private System.Windows.Forms.TextBox TB_KHT1;
        private System.Windows.Forms.TextBox TB_THT7;
        private System.Windows.Forms.TextBox TB_THT6;
        private System.Windows.Forms.TextBox TB_THT5;
        private System.Windows.Forms.TextBox TB_THT4;
        private System.Windows.Forms.TextBox TB_THT3;
        private System.Windows.Forms.TextBox TB_THT2;
        private System.Windows.Forms.TextBox TB_THT1;
        private System.Windows.Forms.TextBox TB_KHN7;
        private System.Windows.Forms.TextBox TB_KHN6;
        private System.Windows.Forms.TextBox TB_KHN5;
        private System.Windows.Forms.TextBox TB_KHN4;
        private System.Windows.Forms.TextBox TB_KHN3;
        private System.Windows.Forms.TextBox TB_KHN2;
        private System.Windows.Forms.TextBox TB_KHN1;
        private System.Windows.Forms.TextBox TB_THN7;
        private System.Windows.Forms.TextBox TB_THN6;
        private System.Windows.Forms.TextBox TB_THN5;
        private System.Windows.Forms.TextBox TB_THN4;
        private System.Windows.Forms.TextBox TB_THN3;
        private System.Windows.Forms.TextBox TB_THN2;
        private System.Windows.Forms.TextBox TB_THN1;
        private System.Windows.Forms.ComboBox CB_SP7;
        private System.Windows.Forms.ComboBox CB_SP6;
        private System.Windows.Forms.ComboBox CB_SP5;
        private System.Windows.Forms.ComboBox CB_SP4;
        private System.Windows.Forms.ComboBox CB_SP3;
        private System.Windows.Forms.ComboBox CB_SP2;
        private System.Windows.Forms.ComboBox CB_SP1;
        private System.Windows.Forms.TextBox TB_TIME;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer TIMER3;
        private System.Windows.Forms.Timer TIMER4;
        private System.Windows.Forms.Timer TIMER5;
        private System.Windows.Forms.Timer TIMER6;
        private System.Windows.Forms.Timer TIMER7;
    }
}

