using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WpfVirginEmgu.Model
{
    public class ImageContainer
    {
        private Image<Bgr, Byte> image;

        public Image<Bgr, Byte> Image
        {
            get => image;
            set => image = value;
        }

        public void LoadImage(string filePath)
        {

        }
    }
}
