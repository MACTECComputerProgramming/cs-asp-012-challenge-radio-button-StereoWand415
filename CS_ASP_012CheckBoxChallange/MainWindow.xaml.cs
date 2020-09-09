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

namespace CS_ASP_012CheckBoxChallange
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myPencil.Opacity = 0;
            myPad.Opacity = 0;
            myPen.Opacity = 0;
            myPhone.Opacity = 0;


            if (PencilradioButton.IsChecked == true)
            {
                Pickedlabel1.Content = " Pencil, Very reliable! ";

                myPencil.Opacity = 100;
            }
            else if (PenradioButton.IsChecked == true)
            {
                Pickedlabel1.Content = " Pen, nice choice! ";

                myPen.Opacity = 100;


            }
            else if (PadradioButton.IsChecked == true)
            {
                Pickedlabel1.Content = " Pad, Welcome to 2020! ";

                myPad.Opacity = 100;
            }
            else if (PhoneradioButton.IsChecked == true)
            {
                Pickedlabel1.Content = " Phone, must be from the future ";

                myPhone.Opacity = 100;
            }
            else
            {
                Pickedlabel1.Content = " Must pick one! ";

                
            }
            
                    
            



        }

    }
}

