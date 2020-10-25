using System;
using System.Windows.Forms;
using PQScan.BarcodeScanner;

namespace barCodeScanner
{
    public partial class cw_Form : Form
    {
        public cw_Form()
        {
            InitializeComponent();
        }

        private void cw_picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = ".";
            file.Filter = "所有文件(*.*)|*.*";
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                try
                {
                    this.cw_picBox.Load(file.FileName);
                    BarcodeResult[] results = BarCodeScanner.Scan(file.FileName);
                    if (results != null)
                    {
                        foreach (BarcodeResult result in results)
                        {
                            this.cw_txtBox.Clear();
                            this.cw_txtBox.AppendText("> 类型：" + result.BarType.ToString() + Environment.NewLine);
                            this.cw_txtBox.AppendText("> 内容：" + Environment.NewLine +  result.Data);
                        }
                    } else
                    {
                        this.cw_txtBox.Text = "> 所选图像未检测到二维码......";
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
