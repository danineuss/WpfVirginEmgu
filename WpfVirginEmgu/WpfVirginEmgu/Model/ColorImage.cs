﻿using System;
using System.Windows.Media.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WpfVirginEmgu.Model
{
    /// <summary>
    /// A basic image container class with BGR images.
    /// </summary>
    public class ColorImage
    {
        #region Public Properties

        public Image<Bgr, Byte> Image { get; set; }

        #endregion

        #region Public Members

        /// <summary>
        /// Loads an image from a file path.
        /// </summary>
        /// <param name="filePath">The entire file path.</param>
        public void LoadImage(string filePath)
        {
            Image = new Image<Bgr, byte>(filePath);
        }

        /// <summary>
        /// Converts the image into a WPF-usable BitmapSource.
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
