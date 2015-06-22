using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YouTubePlayerOnTop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void myWindows_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.N) && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                Console.WriteLine("Racourrcie !!");

                //EnterURL eU = new EnterURL();
                //// Configure the dialog box
                //eU.Owner = this;
                //eU.ShowDialog();


            }
        }

        
    }
}
