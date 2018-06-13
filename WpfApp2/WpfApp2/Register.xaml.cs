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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public User user=new User();
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_ClichR(object sender, RoutedEventArgs e)
        {
            user.Name = Tb1.Text;
            user.Age = Convert.ToInt32(Tb2.Text);
            user.City = Tb3.Text;
            user.Phone = Tb4.Text;
            user.Login = Tb5.Text;
            user.Password=Tb6.Password;
            
            this.Close();
            MessageBox.Show("Welcome! You register!");
        }
        

       
    }
}
