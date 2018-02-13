using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using WpfVirginEmgu.Model;
using WpfVirginEmgu.ViewModels;

namespace WpfVirginEmgu.ViewModel
{
    public class ImageViewModel : BaseViewModel
    {
        #region Private Members

        private string ImageSource { get; set; }

        private ColorImage _bgrColorImage;

        private GrayscaleImage _grayColorImage;

        #endregion

        #region Public Members

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

        public ICommand LoadCommand => new RelayCommand(LoadImage, true);

        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImageSource = openFileDialog.FileName;

                _bgrColorImage.LoadImage(ImageSource);
                _grayColorImage.Image = _bgrColorImage.ConvertToGrayscale();

                BgrImage = BitMapConverter.ToBitmapSource(_bgrColorImage.Image);
                GrayImage = BitMapConverter.ToBitmapSource(_grayColorImage.Image);
            }
        }
    }
}
