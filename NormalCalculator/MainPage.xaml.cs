using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace NormalCalculator
{
    public sealed partial class MainPage : Page
    {
        byte deystvie;
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
                deystvie = 0;
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
            deystvie = 0;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (temp_n != 0)
                {
                    deystvie = 1;
                    temp_n += Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    deystvie = 1;
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
                    deystvie = 2;
                    temp_n -= Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    deystvie = 2;
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
                    deystvie = 3;
                    temp_n *= Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    deystvie = 3;
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
                    deystvie = 4;
                    temp_n /= Convert.ToDouble(TextPanelCalc.Text);
                    TextPanelCalc.Text = "";
                }
                else
                {
                    deystvie = 4;
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
                switch (deystvie)
                {
                    case 1:
                        {
                            double x = temp_n + Convert.ToDouble(TextPanelCalc.Text);
                            TextPanelCalc.Text = x.ToString();
                            deystvie = 0;
                            temp_n = 0;
                            break;
                        }
                    case 2:
                        {
                            double x = temp_n - Convert.ToDouble(TextPanelCalc.Text);
                            TextPanelCalc.Text = x.ToString();
                            deystvie = 0;
                            temp_n = 0;
                            break;
                        }
                    case 3:
                        {
                            double x = temp_n * Convert.ToDouble(TextPanelCalc.Text);
                            TextPanelCalc.Text = x.ToString();
                            deystvie = 0;
                            temp_n = 0;
                            break;
                        }
                    case 4:
                        {
                            double x = temp_n / Convert.ToDouble(TextPanelCalc.Text);
                            TextPanelCalc.Text = x.ToString();
                            deystvie = 0;
                            temp_n = 0;
                            break;
                        }
                    default:
                        break;
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
                deystvie = 0;
                TextPanelCalc.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(TextPanelCalc.Text)));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void NumPI_Click(object sender, RoutedEventArgs e)
        {
            deystvie = 0;
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
