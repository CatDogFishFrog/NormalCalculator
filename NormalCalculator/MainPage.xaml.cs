using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace NormalCalculator
{
    public sealed partial class MainPage : Page
    {
        bool plus = false;
        bool minus = false;
        bool gam = false;
        bool gay = false;
        double temp_n;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Num1_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "1";

        private void Num2_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "2";

        private void Num3_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "3";

        private void Num4_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "4";

        private void Num5_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "5";

        private void Num6_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "6";

        private void Num7_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "7";

        private void Num8_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "8";

        private void Num9_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "9";

        private void Zero_Click(object sender, RoutedEventArgs e) => TextPanelCalc.Text += "0";

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    TextPanelCalc.Text = Convert.ToString(-Convert.ToDouble(TextPanelCalc.Text));
            }
            catch (Exception)
            {
                return;
            }

            
        }

        private void Koma_Click(object sender, RoutedEventArgs e)
        {
            if (TextPanelCalc.Text.Contains(",")) { return; }
            else { TextPanelCalc.Text = (TextPanelCalc.Text + ","); }
        }

        private void VKvadrateLol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double g = Math.Pow(Convert.ToDouble(TextPanelCalc.Text), 2);
                minus = gam = gay = plus = false;
                if (g > 1.8e300 || g < -1.8e300)
                    TextPanelCalc.Text = "БЕСКОНЕЧНОСТЬ НЕ ПРЕДЕЛ!";
                else TextPanelCalc.Text = Convert.ToString(g);
            }
            catch (Exception)
            {
                return;
            }

                
        }

        private void CleanText_Click(object sender, RoutedEventArgs e)
        {
            TextPanelCalc.Text = "";
        }

        private void CleanEvr_Click(object sender, RoutedEventArgs e)
        {
            TextPanelCalc.Text = "";
            temp_n = 0;
            plus = minus = gam = gay = false;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (temp_n != 0)
                {
                    plus = true;
                    minus = gay = gam = false;
                    temp_n += Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    plus = true;
                    minus = gay = gam = false;
                    temp_n = Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (temp_n != 0)
                {
                    minus = true;
                    plus = gay = gam = false;
                    temp_n -= Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    minus = true;
                    plus = gay = gam = false;
                    temp_n = Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (temp_n != 0)
                {
                    minus = gay = plus = false;
                    gam = true;
                    temp_n *= Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    minus = gay = plus = false;
                    gam = true;
                    temp_n = Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Delenie_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (temp_n != 0)
                {
                    minus = gam = plus = false;
                    gay = true;
                    temp_n /= Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    minus = gam = plus = false;
                    gay = true;
                    temp_n = Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (plus)
                {
                    double x = temp_n + Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = x.ToString();
                    plus = false;
                    temp_n = 0;
                }
                if (minus)
                {
                    double x = temp_n - Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = x.ToString();
                    minus = false;
                    temp_n = 0;
                }
                if (gam)
                {
                    double x = temp_n * Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = x.ToString();
                    gam = false;
                    temp_n = 0;
                }
                if (gay)
                {
                    double x = temp_n / Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = x.ToString();
                    gay = false;
                    temp_n = 0;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void KorenKvadrat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                plus = minus = gam = gay = false;
                TextPanelCalc.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(TextPanelCalc.Text)));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void NumPI_Click(object sender, RoutedEventArgs e)
        {
            plus = minus = gam = gay = false;
            TextPanelCalc.Text = "3,1415926535897932384";
        }

        private void Sinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextPanelCalc.Text != "")
                {
                    TextPanelCalc.Text = Convert.ToString(Math.Round(Math.Sin(Convert.ToDouble(TextPanelCalc.Text) * Math.PI / 180), 3));
                }
                else return;
            }
            catch(Exception)
            {
                return;
            }
        }

        private void Cosinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextPanelCalc.Text != "")
                {
                    TextPanelCalc.Text = Convert.ToString(Math.Round(Math.Cos(Convert.ToDouble(TextPanelCalc.Text) * Math.PI / 180), 3));
                }
                else return;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Tangens_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextPanelCalc.Text != "")
                {
                    TextPanelCalc.Text = Convert.ToString(Math.Round(Math.Tan(Convert.ToDouble(TextPanelCalc.Text) * Math.PI / 180), 3));
                }
                else return;
            }
            catch (Exception)
            {
                return;
            }  
        }

        private void ArcSinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextPanelCalc.Text != "")
                {
                    TextPanelCalc.Text = Convert.ToString(Math.Round(Math.Asin(Convert.ToDouble(TextPanelCalc.Text) * Math.PI / 180), 3));
                }
                else return;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void ArcCosinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextPanelCalc.Text != "")
                {
                    TextPanelCalc.Text = Convert.ToString(Math.Round(Math.Acos(Convert.ToDouble(TextPanelCalc.Text) * Math.PI / 180), 3));
                }
                else return;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void ArcTangens_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextPanelCalc.Text != "")
                {
                    TextPanelCalc.Text = Convert.ToString(Math.Round(Math.Atan(Convert.ToDouble(TextPanelCalc.Text) * Math.PI / 180), 3));
                }
                else return;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
