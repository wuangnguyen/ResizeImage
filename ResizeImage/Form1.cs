using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResizeImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }
        private void ResizeImage(Bitmap image, int Width, int Height, int quality, string filePath)
        {
            int sourceWidth = image.Width;
            int sourceHeight = image.Height;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);

            if(nPercentH < nPercentW)
            {
                nPercent = nPercentW;
                destY = (int)((Height - (sourceHeight * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentH;
                destX = (int)((Width - (sourceWidth * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap newImage = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            newImage.SetResolution(72, 72);
            using(Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, new Rectangle(destX, destY, destWidth, destHeight), new Rectangle(0, 0, sourceWidth, sourceHeight), GraphicsUnit.Pixel);
            }
            ImageCodecInfo imageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            EncoderParameters encoderParameters = new EncoderParameters(1);

            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            image.Dispose();
            newImage.Save(filePath, imageCodecInfo, encoderParameters);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if(txtSource.Text != "" && txtDest.Text != "")
            {
                string[] files = Directory.GetFiles(txtSource.Text);
                foreach(string filename in files)
                {
                    try
                    {
                        Bitmap b = new Bitmap(filename);
                        if(b != null)
                        {
                            ResizeImage(b, Convert.ToInt32(txtW1.Text), Convert.ToInt32(txtH1.Text), 100, txtDest.Text + "/" + Path.GetFileName(filename));
                        }
                    }
                    catch
                    {
                    }
                }
                MessageBox.Show("Thành công");
            }
        }

        private void btnResizeFile_Click(object sender, EventArgs e)
        {
            if(txtSourceFile.Text != "" && txtDestFile.Text != "")
            {
                Bitmap b = new Bitmap(txtSourceFile.Text);
                if(b != null)
                {
                    ResizeImage(b, Convert.ToInt32(txtW2.Text), Convert.ToInt32(txtH2.Text), 80, txtDestFile.Text);
                    MessageBox.Show("Thành công");
                }
            }
        }
    }
}
