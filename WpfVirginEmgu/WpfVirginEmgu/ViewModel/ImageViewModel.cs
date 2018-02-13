using System;
using System.Windows.Input;
using System.Drawing;
using System.Windows.Media.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;
using Microsoft.Win32;
using WpfVirginEmgu.Model;
using WpfVirginEmgu.ViewModels;

namespace WpfVirginEmgu.ViewModel
{
    public class ImageViewModel : BaseViewModel
    {
        public string ImageSource { get; set; }

        public BitmapSource Image { get; set; }
        
        public ICommand LoadCommand => new RelayCommand(LoadImage, true);

        private void LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImageSource = openFileDialog.FileName;
                Image = BitMapConverter.ToBitmapSource(new Image<Bgr, Byte>(ImageSource));
            }
        }
    }
}
