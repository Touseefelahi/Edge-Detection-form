using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace WindowsFormsApplication1
{
    public partial class Edge_detection : Form
    {
        Mat image_in;
        Capture cam=new Capture();
        byte blur_size = 7, canny_th1 = 0,canny_th2=30,canny_apsize=3;
        float blur_x = 1f, blur_y = 1f;
        Mat gray;
        bool flag_edge = false,flag_inter=false;
        public int CvSize;
        private bool captureInProgress;
        private void ProcessFrame(object sender, EventArgs arg)
        {
            image_in= cam.QueryFrame();
            if (flag_edge)
            {
                CvInvoke.CvtColor(image_in, image_in, ColorConversion.Bgr2Gray);
                CvInvoke.GaussianBlur(image_in, image_in,new Size(blur_size, blur_size), blur_x, blur_y);
                if (flag_inter)
                {
                    gray = image_in.Clone();
                    CvInvoke.Imshow("Gray", gray);
                    gray.Dispose();
                }

                CvInvoke.Canny(image_in, image_in, canny_th1, canny_th2,canny_apsize);
               
            }

            if (imageBox1.Image != null)
            {
                imageBox1.Image.Dispose();
            }

            imageBox1.Image = image_in;
        }

        public Edge_detection()
        {
           
            InitializeComponent();
            trackBar_th1.Maximum = 255;
            trackBar_th2.Maximum = 255;
            trackBar_blur.Maximum = 21;
        
        }

   
        private void bt_start_Click(object sender, EventArgs e)
        {
            if (cam == null)
            {
                try
                {
                    cam = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                    Close();
                }
            }

            if (cam != null)
            {
                if (captureInProgress)
                {  
                    bt_start.Text = "Start!"; //
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    
                    bt_start.Text = "Stop";
                    Application.Idle += ProcessFrame;
                }
                captureInProgress = !captureInProgress;
            }

        }

        private void bt_edges_Click(object sender, EventArgs e)
        {
            flag_edge = !flag_edge;
            if(flag_edge)bt_edges.Text = "Edges off";
            else bt_edges.Text = "Edges on"; //
        }
     
        #region Track_bars
        private void trackBar_th1_Scroll(object sender, EventArgs e)
        {
            canny_th1 = (byte)trackBar_th1.Value;
            textBox_thlower.Text = Convert.ToString(canny_th1);
        }

     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            flag_inter = !flag_inter;
            if (!flag_inter)
            {
                CvInvoke.DestroyWindow("Gray");
            }
        }

        private void trackBar_th2_Scroll(object sender, EventArgs e)
        {
            canny_th2 = (byte)trackBar_th2.Value;
            textBox_thhigher.Text = Convert.ToString(canny_th2);
        }

        private void trackBar_can_apsize_Scroll(object sender, EventArgs e)
        {
            canny_apsize = (byte)trackBar_can_apsize.Value;
            if (canny_apsize % 2 == 0) canny_apsize += 1;
            textBox_canny_app.Text = Convert.ToString(canny_apsize);
        }

        private void trackBar_blur_Scroll(object sender, EventArgs e)
        {
            blur_size = (byte)trackBar_blur.Value;
            if (blur_size % 2 == 0) blur_size += 1;
            textBox_blursize.Text = Convert.ToString(blur_size);
        }

        private void trackBar_blurx_Scroll(object sender, EventArgs e)
        {
            blur_x = (float)(1+trackBar_blurx.Value/10.0);
            textBox_blurx.Text = Convert.ToString(blur_x);
        }

        private void trackBar_blury_Scroll(object sender, EventArgs e)
        {
            blur_y = (float)(1+trackBar_blury.Value/10.0);
            textBox_blury.Text = Convert.ToString(blur_y);
        }
        #endregion
    }
}
