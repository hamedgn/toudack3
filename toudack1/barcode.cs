using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using IronBarCode;
using Dynamsoft.UVC;
using Dynamsoft.Core;
using System.IO;
using System.Runtime.InteropServices;
using Dynamsoft.Common;
using Dynamsoft.Barcode;

namespace toudack1
{
    public partial class barcode : Form
    {
       
        
        private int m_iDesignWidth = 755;
        private int iControlWidth = 275;
        private int iControlHeight = 295;
        private CameraManager m_CameraManager = null;
        private ImageCore m_ImageCore = null;
        private string m_StrProductKey = "t0068UwAAAIcVCMR0LfYuOyMnEOjUBCwp0Ic58BqPnpK9L6GdbLRj1OctKZzfOueNck25ncqc/GjhaduvqDSm8J6/4t4LWlA=";

        private Camera m_CurrentCamera = null;

        public barcode()
        {
            InitializeComponent();
           
            
            m_CameraManager = new CameraManager(m_StrProductKey);
            m_ImageCore = new ImageCore();
            dsViewer1.Bind(m_ImageCore);
            this.Load += new EventHandler(barcode_Load);
            

        }

        void barcode_Load(object sender, EventArgs e)
        {
            try
            {
                m_iDesignWidth = this.Width;
                if (m_CameraManager.GetCameraNames() != null)
                {
                    foreach (string temp in m_CameraManager.GetCameraNames())
                    {
                        cbxSources.Items.Add(temp);
                    }

                    cbxSources.SelectedIndexChanged += cbxSources_SelectedIndexChanged;
                    if (cbxSources.Items.Count > 0)
                        cbxSources.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void create_qr_btn_Click(object sender, EventArgs e)
        {
           for(int i = 101; i < 141; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    var mybarcod = IronBarCode.QRCodeWriter.CreateQrCode(""+i+"0"+j+"", 500);

                    mybarcod.ChangeBarCodeColor(Color.Black).SaveAsPng("q"+i+"0"+j+".png");
                }
            }
            
            
        }

        private void create_barcod_btn_Click(object sender, EventArgs e)
        {
            for (int i = 101; i < 141; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                  //  var MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode("" + i + "0" + j + "", BarcodeEncoding.Code128);
                  //   MyBarCode.SaveAsImage("b" + i + "0" + j + ".png");
                }
            }

        }

        private void read_qr_btn_Click(object sender, EventArgs e)
        {   

            if (m_CurrentCamera != null)
            {
                Bitmap tempBmp = m_CurrentCamera.GrabImage();
                m_ImageCore.IO.LoadImage(tempBmp);
                
            /*
            //BarcodeResult Result = IronBarCode.BarcodeReader.ReadASingleBarcode("aa.png", BarcodeEncoding.QRCode | BarcodeEncoding.Code128, BarcodeReader.BarcodeRotationCorrection.High, BarcodeReader.BarcodeImageCorrection.MediumCleanPixels);
            BarcodeResult r1 = IronBarCode.BarcodeReader.ReadASingleBarcode(tempBmp, BarcodeEncoding.All);
                if(r1 != null) { 
                MessageBox.Show(r1.Text);
                }
                */
            }
        }

        private void read_barcode_btn_Click(object sender, EventArgs e)
        {
           // BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode("GetStarted.png");
            
               // MessageBox.Show(Result.Text);
            
        }

        private void cbxSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_CurrentCamera != null)
            {
                m_CurrentCamera.OnFrameCaptrue -= m_CurrentCamera_OnFrameCaptrue;
                m_CurrentCamera.Close();
            }
            if (m_CameraManager != null)
            {
                m_CurrentCamera = m_CameraManager.SelectCamera((short)cbxSources.SelectedIndex);
                m_CurrentCamera.Open();

                m_CurrentCamera.OnFrameCaptrue += m_CurrentCamera_OnFrameCaptrue;
                ResizePictureBox();
            }
            if (m_CurrentCamera != null)
            {
                cbxResolution.Items.Clear();
                foreach (CamResolution camR in m_CurrentCamera.SupportedResolutions)
                {
                    cbxResolution.Items.Add(camR.ToString());
                }
                cbxResolution.SelectedIndexChanged += cbxResolution_SelectedIndexChanged;
                if (cbxResolution.Items.Count > 0)
                    cbxResolution.SelectedIndex = 0;
                ResizePictureBox();
            }
        }

        void m_CurrentCamera_OnFrameCaptrue(Bitmap bitmap)
        {
            SetPicture(bitmap);
        }

        private void SetPicture(Image img)
        {
            Bitmap temp = ((Bitmap)(img)).Clone(new Rectangle(0, 0, img.Width, img.Height), img.PixelFormat);
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.BeginInvoke(new MethodInvoker(
                delegate ()
                {
                    pictureBox1.Image = temp;
                }));
            }
            else
            {
                pictureBox1.Image = temp;
            }

        }

        private void ResizePictureBox()
        {
            if (m_CurrentCamera != null)
            {
                CamResolution camResolution = m_CurrentCamera.CurrentResolution;
                if (camResolution != null && camResolution.Width > 0 && camResolution.Height > 0)
                {
                    {
                        int iVideoWidth = iControlWidth;
                        int iVideoHeight = iControlWidth * camResolution.Height / camResolution.Width;
                        int iContentHeight = panel1.Height - panel1.Margin.Top - panel1.Margin.Bottom - panel1.Padding.Top - panel1.Padding.Bottom;
                        if (iVideoHeight < iContentHeight)
                        {
                            //pictureBox1.Location = new Point(0, (iContentHeight - iVideoHeight) / 2);
                            pictureBox1.Size = new Size(iVideoWidth, iVideoHeight);
                        }
                        else
                        {
                            pictureBox1.Size = new Size(iVideoWidth, iVideoHeight);
                            //pictureBox1.Location = new Point(0, 0);
                            pictureBox1.Size = new Size(dsViewer1.Width, dsViewer1.Height);
                        }
                    }
                }
            }
        }
        private void RotatePictureBox()
        {
            if (m_CurrentCamera != null)
            {
                CamResolution camResolution = m_CurrentCamera.CurrentResolution;
                if (camResolution != null && camResolution.Width > 0 && camResolution.Height > 0)
                {
                    if (camResolution.Width / camResolution.Height > iControlWidth / iControlHeight)
                    {
                        int iVideoHeight = iControlHeight;
                        int iVideoWidth = iControlHeight * camResolution.Height / camResolution.Width;
                        int iContentWidth = panel1.Width - panel1.Margin.Left - panel1.Margin.Right - panel1.Padding.Left - panel1.Padding.Right;
                        pictureBox1.Location = new Point((iContentWidth - iVideoWidth) / 2, 0);
                        pictureBox1.Size = new Size(iVideoWidth, iVideoHeight);
                    }
                    else
                    {
                        int iVideoWidth = iControlWidth;
                        int iVideoHeight = iControlWidth * camResolution.Width / camResolution.Height;
                        int iContentHeight = panel1.Height - panel1.Margin.Top - panel1.Margin.Bottom - panel1.Padding.Top - panel1.Padding.Bottom;
                        pictureBox1.Location = new Point(0, (iContentHeight - iVideoHeight) / 2);
                        pictureBox1.Size = new Size(iVideoWidth, iVideoHeight);
                    }
                }
            }
        }

        private void cbxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxResolution.Text != null)
            {
                string[] strWXH = cbxResolution.Text.Split(new char[] { ' ' });
                if (strWXH.Length == 3)
                {
                    try
                    {
                        m_CurrentCamera.CurrentResolution = new CamResolution(int.Parse(strWXH[0]), int.Parse(strWXH[2]));
                    }
                    catch { }
                }
                m_CurrentCamera.RotateVideo(Dynamsoft.UVC.Enums.EnumVideoRotateType.Rotate_0);
                ResizePictureBox();
            }
        }

        private void dsViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_CurrentCamera != null)
            {
                Bitmap tempBmp = m_CurrentCamera.GrabImage();
                m_ImageCore.IO.LoadImage(tempBmp);


                try
                {
                    BarcodeReader dbr = new BarcodeReader();
                    dbr.LicenseKeys = "t0068UwAAAIcVCMR0LfYuOyMnEOjUBCwp0Ic58BqPnpK9L6GdbLRj1OctKZzfOueNck25ncqc/GjhaduvqDSm8J6/4t4LWlA=";

                    TextResult[] aryResult = dbr.DecodeBitmap(tempBmp, ""); // leave the template name empty ("") will use  default settings for recognition
                    if (aryResult.Length == 0)
                    {
                        Console.WriteLine("No barcode found.");
                    }
                    else
                    {
                        for (var i = 0; i < aryResult.Length; i++)
                        {
                            // Console.WriteLine("Barcode: {0}", (i + 1));
                            // Console.WriteLine("BarcodeFormat: {0}", aryResult[i].BarcodeFormat.ToString());
                            //MessageBox.Show(aryResult[i].BarcodeText);
                            TextWriter txt = new StreamWriter("demo");
                            txt.Write(aryResult[i].BarcodeText);
                            txt.Close();
                            this.Hide();
                        }
                    }
                }
                catch (BarcodeReaderException exp)
                {
                    Console.WriteLine("Error: {0}, {1}", exp.Code.ToString(), exp.Message);
                }

                /*
                string[] datas = BarcodeScanner.Scan(tempBmp, BarcodeType.QRCode);

                // string[] barcodeValues = BarcodeReader.read(tempBmp, KeepDynamic.BarcodeReader.Type.QRCode);
                //BarcodeResult Result = IronBarCode.BarcodeReader.ReadASingleBarcode("aa.png", BarcodeEncoding.QRCode | BarcodeEncoding.Code128, BarcodeReader.BarcodeRotationCorrection.High, BarcodeReader.BarcodeImageCorrection.MediumCleanPixels);
                // BarcodeResult r1 = IronBarCode.BarcodeReader.ReadASingleBarcode(tempBmp, BarcodeEncoding.All);
                if (datas != null)
                {
                    MessageBox.Show(datas.ToString());

                    TextWriter txt = new StreamWriter("demo.txt");
                    txt.Write(datas.ToString());
                    txt.Close();
                    //Bank toMain = new Bank();
                    //toMain.Test = r1.Text;
                    //this.Close();
                    // toMain.Show();
                    // MessageBox.Show(bank.q);
                    //Application.Restart();
                    //if (toMain.ShowDialog() == DialogResult.Cancel)
                    //{
                    //    toMain.Close();
                    //}
                    //this.parent = bank;
                    //this.parent.Show();
                    Application.Exit();
                }
                */
                m_ImageCore.ImageBuffer.RemoveAllImages();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

        
   
}
