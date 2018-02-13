using System;
using System.Windows.Media.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WpfVirginEmgu.Model
{
    /// <summary>
    /// A basic image container class with gray scale images.
    /// </summary>
    public class GrayscaleImage
    {
        #region Public Properties

        public Image<Gray, Byte> Image { get; set; }

        #endregion

        #region Public Members

        /// <summary>
        /// Loads an Emgu Image from a file path.
        /// </summary>
        /// <param name="filePath">The full file path.</param>
        public void LoadImage(string filePath)
        {
            Image = new Image<Gray, byte>(filePath);
        }

        /// <summary>
        /// Converts the Image into a WPF-usable BitmapSource.
        /// </summary>
        /// <returns></returns>
        public BitmapSource ConvertImage()
        {
            BitmapSource bitmapSource = BitMapConverter.ToBitmapSource(Image);
            return bitmapSource;
        }
        #endregion
    }
}
