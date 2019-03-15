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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            rotate.RenderTransform = rt;
            rotate.RenderTransformOrigin = new Point(0.5, 0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);


        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "0";
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + ".";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = "";
        }

        private void un_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "1";
        }

        private void deux_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "2";
        }

        private void trois_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "3";
        }

        private void quatre_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "4";
        }

        private void cinq_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "5";
        }

        private void size_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "6";
        }

        private void sept_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "7";
        }

        private void huit_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "8";
        }

        private void neuf_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "9";
        }

        private void parant1_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "(";
        }

        private void parant_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + ")";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "+";
        }

        private void moins_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "-";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "*";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            txtEd.Text = txtEd.Text + "/";
        }

        private void egal_Click(object sender, RoutedEventArgs e)
        {
            if (txtEd.Text != "")
            {
                Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

                dynamic obj = Activator.CreateInstance(scriptType, false);
                obj.Language = "javascript";
                string str = null;

                try
                {
                    var res = obj.Eval(txtEd.Text);
                    str = Convert.ToString(res);
                    txtEd.Text = txtEd.Text + "=" + str;
                }
                catch (SystemException)
                {

                    txtEd.Text = "Syntax Error";
                }
            }
            else
            {
                txtEd.Text = "Syntax Error";
            }

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtEd.Text != "")
            {
                txtEd.Text = txtEd.Text.Remove(txtEd.Text.Length - 1);
            }
        }
    }
}
