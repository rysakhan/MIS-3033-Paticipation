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

namespace WPFParticipation
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

            //MessageBox.Show("You clicked me!");

            string answerName = txtEnterName.Text;

            string bday = txtBDay.Text;

            DateTime Birthday = Convert.ToDateTime(bday);

            int birthyear = Birthday.Year;

            int age = DateTime.Now.Year - birthyear;


            MessageBox.Show("Hey " + answerName + "! You are " + age + " years old!");

                //lblMessage.Content = "Hello World!";

                //string answer = txtFavoriteNumber.Text;
                //double result = Convert.ToDouble(answer);


            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCalculate_MouseEnter(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = Brushes.DarkGreen;
        }

        private void btnCalculate_MouseLeave(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = Brushes.BlueViolet;
        }

    }
}
