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
using System.Data.SqlClient;
using System.Data;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ConnectionString = "Data Source=.; Initial Catalog = porject; User ID = sa; Password = FIATS@2024 ";
        public MainWindow()
        {
            InitializeComponent();
            Adduser();
          
        }
        public void Adduser()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(" select * from accs", connection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                DG.ItemsSource = dt.DefaultView;
            }
            
        }
            public void Enter()
        { 
        using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "insert into accs (acc_G,acc_FN,acc_LN,acc_phone) values (@acc_G,@acc_FN,@acc_LN,@acc_phone),";
                using (SqlCommand sqlcommand=new SqlCommand(query,connection))
                {
                    sqlcommand.Parameters.AddWithValue("@acc_FN",txtfnmae.Text.Trim());
                    sqlcommand.Parameters.AddWithValue("@acc_G", txtmail.Text.Trim());
                    sqlcommand.Parameters.AddWithValue("@acc_LN", txtlnmae.Text.Trim());
                    sqlcommand.Parameters.AddWithValue("@acc_phone", phone.Text.Trim());
                    sqlcommand.ExecuteNonQuery();
                }
                
                MessageBox.Show("DONE");
                Adduser();
                
            }
       }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString)) 
            connection.Open();
            MessageBox.Show("Open");
            MessageBox.Show("close");
      

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
