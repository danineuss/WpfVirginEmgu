using System.Windows;
using WpfVirginEmgu.ViewModel;

namespace WpfVirginEmgu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ImageViewModel();
        }
    }
}
