/// Chapter No. 3		Exercise No. 1
/// File Name: MainWindow.cs
/// @author: Marcus Moore
/// Date:  September 27, 2021
///
/// Problem Statement: Using the user's weight in pounds and height in inches, calculate their BMI and
///                    output it in its respective color.
/// 
/// Overall Plan:
/// 1) Create two ints: wgt and hgt.
/// 2) Set wgt to the int parsed string passed into the Weight textbox.
/// 3) Do the same with hgt and the height textbox.
/// 4) Create a float called BMI and store wgt times 720.
/// 5) Divide BMI by the square root of hgt.
/// 6) Check if the BMI is safe and paint it green.
/// 7) Else if it is above average, paint it yellow.
/// 8) Else paint blue.
/// 9) Output it to the BMI label.

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

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int wgt, hgt;
            wgt = int.Parse(Weight.Text);
            hgt = int.Parse(Height.Text);
            int bmi_val = (wgt * 720) / (int)Math.Pow(hgt,2);

            BMI.Content = "Your BMI is: " + bmi_val.ToString();

            if (bmi_val < 27 && bmi_val > 14)
            {
                BMI.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if (bmi_val > 26)
            {
                BMI.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                BMI.Foreground = new SolidColorBrush(Colors.Blue);
            }
        }
    }
}
