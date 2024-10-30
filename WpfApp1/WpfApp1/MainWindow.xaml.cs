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

namespace WpfApp1
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
            string x = "mohamed";//Username
            string y = "123";// password
            if (txt_user.Text==x && pass.Text==y)//check if the username and password are right
            {
                MessageBox.Show("Welcome"+x);
            }
            else
            {
                MessageBox.Show("user name" +
                    " or password incoret");
            }
   
        }
        public   void TextBox_TextChanged(object sender, TextChangedEventArgs e )
        {
         
        }
        public void txt_user_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
        private void pass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
