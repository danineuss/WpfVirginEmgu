using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using WpfVirginEmgu.Model;
using WpfVirginEmgu.ViewModels;

namespace WpfVirginEmgu.ViewModel
{
    public class ImageViewModel : BaseViewModel
    {
        /// <summary>
        /// Contains the file path to the original image and the two image container classes.
        /// </summary>
        #region Private Properties

        private string ImageSource { get; set; }

        private ColorImage _bgrColorImage;

        private GrayscaleImage _grayColorImage;

        #endregion

        /// <summary>
        /// Contains the two BitmapSource images which can be bound to from the XAML.
        /// </summary>
        #region Public Properties

        public BitmapSource BgrImage { get; set; }

        public BitmapSource GrayImage { get; set; }

        #endregion

        #region Constructor

        public ImageViewModel()
        {
            _bgrColorImage = new ColorImage();
            _grayColorImage = new GrayscaleImage();
        }

        #endregion

        /// <summary>
        /// Relays the private function as an ICommand to the View.
        /// </summary>
        public ICommand LoadCommand => new RelayCommand(LoadImage, true);

        /// <summary>
        /// Creates a windows-style file dialog to find the image path and loads the two images.
        /// </summary>
        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImageSource = openFileDialog.FileName;

                _bgrColorImage.LoadImage(ImageSource);
                _grayColorImage.LoadImage(ImageSource);

                BgrImage = BitMapConverter.ToBitmapSource(_bgrColorImage.Image);
                GrayImage = BitMapConverter.ToBitmapSource(_grayColorImage.Image);
            }
        }
    }
}
