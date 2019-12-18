

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
        
                //private object rasterbtn;

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
            if (material == "wood") {
{}
                else if (thickness == "1/4")
                {
{}
                    else if (process == "vector")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.wcutting14.speed, laser.wcutting14.power));
                    }

                }
            }

            if (material == "wood")
            {
                if (thickness == "1/8")
                {
                    if (process == "vector")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.wcutting18.speed, laser.wcutting18.power));
                    }

                }
            }

            if (material == "wood")
            {

                if (process == "raster")
                {
                    laser = new Watt40();
                    MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.wengraving.speed, laser.wengraving.power));
                }

            }

            if (material == "wood")
            {
                if (thickness == "1/8")
                {
                    if (process == "combined")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.wcombined18.speed, laser.wcombined18.power));
                    }

                }
            }

            if (material == "wood")
            {
                if (thickness == "1/4")
                {
                    if (process == "combined")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.wcombined14.speed, laser.wcombined14.power));
                    }

                }
            }


            //------------------------------------------------------------------------------
            if (material == "acrylic")
            {
                if (thickness == "1/8")
                {
                    if (process == "vector")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.acutting18.speed, laser.acutting18.power));
                    }

                }
            }

            if (material == "acrylic")
            {
                if (thickness == "1/8")
                {
                    if (process == "vector")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.acombined18.speed, laser.acombined18.power));
                    }

                }
            }

            if (material == "acrylic")
            {

                if (process == "raster")
                {
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.aengraving.speed, laser.aengraving.power));

                    }

                }
            } 

            if (material == "acrylic")
            {
                if (thickness == "1/8")
                {
                    if (process == "combined")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.acutting18.speed, laser.acutting18.power));
                    }

                }
            }

            if (material == "acrylic")
            {
                if (thickness == "1/8")
                {
                    if (process == "vector")
                    {
                        laser = new Watt40();
                        MessageBox.Show(String.Format("Your Settings are: {0} speed & {1} power", laser.acutting18.speed, laser.acutting18.power));
                    }

                }
            }
        }

            //----------------------------------------------------------------------------------



            

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