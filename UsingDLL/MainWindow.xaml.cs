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
using DLL101;

namespace UsingDLL
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

        Calculationdll calc = new Calculationdll();

        private void BtnAdd(object sender, EventArgs e)
        {
            try
            {
                // storing the result in int r
                int r = calc.Add(int.Parse(txtBoxForFirstNumber.Text), int.Parse(txtBoxForSecondNumber.Text));
                txtBoxResult.Text = r.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSub(object sender, EventArgs e)
        {
            try
            {
                // storing the result in int r
                int r = calc.Sub(int.Parse(txtBoxForFirstNumber.Text), int.Parse(txtBoxForSecondNumber.Text));
                txtBoxResult.Text = r.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
