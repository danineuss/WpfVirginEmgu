using System;
using System.Drawing;
using System.Windows.Media.Imaging;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI.GLView;

namespace WpfVirginEmgu.Model
{
    public class GrayscaleImage
    {
        public Image<Gray, Byte> Image { get; set; }

        public void LoadImage(string filePath)
        {
            Image = new Image<Gray, byte>(filePath);
        }

        public BitmapSource ConvertImage()
        {
            BitmapSource bitmapSource = BitMapConverter.ToBitmapSource(Image);
            return bitmapSource;
        }

        public Image<Bgr, Byte> ConvertToBgr()
        {
            return Image.Convert<Bgr, Byte>();
        }
    }
}
