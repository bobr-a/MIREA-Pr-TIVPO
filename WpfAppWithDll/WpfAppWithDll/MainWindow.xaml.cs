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
using System.Reflection;
using System.Runtime.InteropServices;

namespace WpfAppWithDll
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

        private void Summ_Click(object sender, RoutedEventArgs e)
        {
            string number1_txt = textbox1.Text;
            string number2_txt = textbox2.Text;
            int number1 = 0, number2 = 0;
            try
            {
                number1 = int.Parse(number1_txt);
                number2 = int.Parse(number2_txt);
                resultSumm.Text = LibraryImport.summ(number1, number2).ToString();
            }
            catch (Exception ex)
            {
                label1.Content = ex.Message;
            }
        }
         private void Equals_Click(object sender, RoutedEventArgs e)
        {
            string number1_txt = textbox1.Text;
            string number2_txt = textbox2.Text;
            int number1 = 0, number2 = 0;
            try
            {
                number1 = int.Parse(number1_txt);
                number2 = int.Parse(number2_txt);
                resultEquals.Text = LibraryImport.equeals(number1, number2).ToString();
            }
            catch (Exception ex)
            {
                label1.Content = ex.Message;
            }
        }
        public string Equals_Click(int number1, int number2)
        {
          
            try
            {
                return resultEquals.Text = LibraryImport.equeals(number1, number2).ToString();
            }
            catch (Exception ex)
            {
               return ex.Message;
            }
        }
        public string Summ_Click(int number1, int number2)
        {
            try
            {
               return resultSumm.Text = LibraryImport.summ(number1, number2).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void resultSumm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    public static class LibraryImport
    {

        [DllImport(@"C:\ProjectsVS\DllTest.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int summ(int num1, int num2);
        [DllImport(@"C:\ProjectsVS\DllTest.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool equeals(int num1, int num2);
    }
}
