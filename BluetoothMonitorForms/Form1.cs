namespace BluetoothMonitorForms
{
    public partial class Form1 : Form
    {
        DeviceBatteryInfo deviceInfo;

        public Form1()
        {
            InitializeComponent();

            //notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Hand;    // TODO get a real icon?
            notifyIcon1.Visible = true;

            //timer1 = new System.Windows.Forms.Timer { Interval = 5000 };    // poll every 5s
            timer1.Interval = 5000;
            timer1.Tick += Timer_Tick;

            timer1.Start();
            Visible = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RetrieveDeviceInfoB();
        }

        private void RetrieveDeviceInfoB()
        {
            deviceInfo = BluetoothUtils.GetStadiaBatteryLevel();
            lblBatteryLevel.Text = $"{deviceInfo.BatteryLevel}%";
            barBatteryLevel.Value = deviceInfo.BatteryLevel;
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}
