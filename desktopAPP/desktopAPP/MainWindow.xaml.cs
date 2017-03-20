using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace desktopAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_MyotherEvent;
        }

        private void button_MyotherEvent(object sender, RoutedEventArgs e)
        {
            Myotherlabel.Content = "Hello again";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Mylabel.Content = "Hello World";
        }
    }
}
