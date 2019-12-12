

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

namespace WpfApplication2
{
    //class laser {

    //    class fortywatt {
            /// <summary>
            /// Interaction logic for MainWindow.xaml
            /// </summary>
            public partial class MainWindow : Window
            {
                public string material;
                public string process;
                public string thickness;
        public Laser laser;
                //private object woodbtn;
                //private object glassbtn;
                //private object rasterbtn;
                //private object metalbtn;
                //private object oneegthbtn;
                //private object onefrthbtn;
                //private object vectorbtn;
                //private object combbtn;
                //private object acrylicbtn;

#pragma warning disable CS0219
                public MainWindow()
                {
                    InitializeComponent();
                }


                private void radioButton_Checked(object sender, RoutedEventArgs e)
                {
                    if (woodbtn.IsChecked == true)
                    {
                        material = ("wood");
                        MessageBox.Show("wood!");
                    }
                }

                private void radioButton2_Checked(object sender, RoutedEventArgs e)
                {
                    if (glassbtn.IsChecked == true)
                    {
                        material = ("glass");
                    }
                }

                private void radioButton4_Checked(object sender, RoutedEventArgs e)
                {
                    if (rasterbtn.IsChecked == true)
                    {
                        process = ("raster");
                    }
                }

                private void textBox_TextChanged(object sender, TextChangedEventArgs e)
                {

                }

                private void button_Click(object sender, RoutedEventArgs e)
                {
                    if (material == "wood")
                    {
                        if (thickness == "1/8")
                        {
                            if (process == "raster")
                            {
                                laser = new Watt30();
                                MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.cutting14.speed, laser.cutting14.power));
                            }

                        }
            }
                }

                private void radioButton3_Checked(object sender, RoutedEventArgs e)
                {
                    if (metalbtn.IsChecked == true)
                    {
                        var material = ("metal");
                    }
                }

                private void radioButton1_Copy_Checked(object sender, RoutedEventArgs e)
                {
                    if (oneegthbtn.IsChecked == true)
                    {
                        thickness = ("1/8");
                    }
                }



                private void radioButton1_Copy1_Checked(object sender, RoutedEventArgs e)
                {
                    if (onefrthbtn.IsChecked == true)
                    {
                        var thickness = ("1/4");
                    }
                }

                private void radioButton6_Checked(object sender, RoutedEventArgs e)
                {
                    if (vectorbtn.IsChecked == true)
                    {
                        var process = ("vector");
                    }

                }

                private void radioButton5_Checked(object sender, RoutedEventArgs e)
                {
                    if (combbtn.IsChecked == true)
                    {
                        var process = ("combined");
                    }
                }

                private void radioButton1_Checked(object sender, RoutedEventArgs e)
                {
                    if (acrylicbtn.IsChecked == true)
                    {
                        var material = ("Acrylic");
                    }
                }
        //    }
        //}
        //class thirtywatt
        //{

        //}
    }
 }