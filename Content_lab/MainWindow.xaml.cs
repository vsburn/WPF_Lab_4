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

namespace Content_lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Валюты
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate.Text);
            double s = Convert.ToDouble(num.Text);
            result.Text = Convert.ToString(r * s);
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate1.Text);
            double s = Convert.ToDouble(num1.Text);
            result1.Text = Convert.ToString(r * s);
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate2.Text);
            double s = Convert.ToDouble(num2.Text);
            result2.Text = Convert.ToString(r * s);
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate3.Text);
            double s = Convert.ToDouble(num3.Text);
            result3.Text = Convert.ToString(r * s);
        }
        #endregion
        #region Расстояния
        private void Button_Click20(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate20.Text);
            result20.Text = Convert.ToString(r * 1.093613);
        }
        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate21.Text);
            result21.Text = Convert.ToString(r * 0.621371);
        }
        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate22.Text);
            result22.Text = Convert.ToString(r * 0.393701);
        }
        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            double r = Convert.ToDouble(rate23.Text);
            result23.Text = Convert.ToString(r * 3.28084);
        }
        #endregion
    }
}