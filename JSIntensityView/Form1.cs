namespace JSIntensityView
{
    using JoeScan.Pinchot;
    using JoeScan.Pinchot.Beta;
    using System.Drawing.Imaging;

    public partial class Form1 : Form
    {
        private Bitmap mImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            var profiles = RunScanning(uint.Parse(textBoxSerialNumber.Text), uint.Parse(textBoxScanPeriod.Text), 
                uint.Parse(textBoxLaserOn.Text), uint.Parse(textBoxProfileCount.Text));
            mImage = MakeIntensityImage(profiles);
            IntensityImage.Image = mImage;
        }

        private Bitmap MakeIntensityImage(List<IProfile> profiles)
        {
            int height = profiles.Count;
            int width = profiles[0].RawPoints.Length;
            byte[] data = new byte[width * height * 3];

            int o = 0;

            for (int i = 0; i < profiles.Count; i++)
            {
                var profile = profiles[i];
                for(int j = 0; j < profile.RawPoints.Length; j++)
                {
                    var value = (byte)profile.RawPoints[j].Brightness;

                    data[o++] = value;
                    data[o++] = value;
                    data[o++] = value;
                }
            }
            Bitmap outimage = null;
            unsafe
            {
                fixed (byte* ptr = data)
                {

                    using (Bitmap image = new Bitmap(width, height, width * 3,
                                PixelFormat.Format24bppRgb, new IntPtr(ptr)))
                    {

                        outimage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), PixelFormat.Format24bppRgb);
                    }
                }
            }
            return outimage;
        }

        private List<IProfile> RunScanning(uint serial, uint period, uint laserOn, uint profileCount)
        {
            ScanSystem ss = new ScanSystem(ScanSystemUnits.Inches);
            var sh = ss.CreateScanHead(serial, 0);
            ss.Connect(TimeSpan.FromSeconds(1));
            var configuration = new ScanHeadConfiguration();
            configuration.SetLaserOnTime(laserOn,laserOn,laserOn);
            BrightnessCorrection bc = sh.CreateBrightnessCorrection();
            bc.Offset = 0;
            for (int i = 0; i < bc.Count; i++)
            {
                bc[i] = 3.0f;
            }
            sh.SetBrightnessCorrection(Camera.CameraA, bc);
            sh.Configure(configuration);
            ss.AddPhase();
            ss.AddPhaseElement(0, Camera.CameraA);
            var minPeriod = ss.GetMinScanPeriod();
            period = Math.Max(minPeriod, period);
            ss.StartScanning(period, DataFormat.XYBrightnessFull);
            List<IProfile> profiles = new List<IProfile>();
            do 
            {
                var profile = sh.TakeNextProfile();
                profiles.Add(profile);
            } while (profiles.Count < profileCount);
            ss.StopScanning();
            ss.Disconnect();
            return profiles;

        }
    }
}
