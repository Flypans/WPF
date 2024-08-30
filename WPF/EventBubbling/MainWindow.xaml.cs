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

namespace EventBubbling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BubbleTextBox()
        {
            BubblingEvent.Text = string.Join("->", list);
            ListClear();
        }
        private void TunnelTextBox()
        {
            TunnelingEvent.Text = string.Join("->", list);
            ListClear();
        }
        private async void ListClear()
        {
            await Task.Delay(100);
            list.Clear();
        }
        private void btnBubble_Click(object sender, RoutedEventArgs e)
        {
            list.Add("Sky");
            BubbleTextBox();
        }
        private void Border_MoudeDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Black");
            BubbleTextBox();
        }
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Yello");
            BubbleTextBox();
        }
        private void btnTurnnel_Click(object sender, MouseButtonEventArgs e)
        {
            list.Add("Sky");
            TunnelTextBox();
        }
        private void Border_PreviewMoudeDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Black");
            TunnelTextBox();
        }
        private void Rectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            list.Add("Yello");
            TunnelTextBox();
        }
    }
}
