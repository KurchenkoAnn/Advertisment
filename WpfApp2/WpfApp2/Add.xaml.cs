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
using System.Windows.Forms;
using System.IO;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Advertisement a = new Advertisement();
        private User CurrentUser = null;
        public Window1(User CU)
        {
            InitializeComponent();
            CurrentUser = CU;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
 
            if (op.FileName.Contains(".jpg") || op.FileName.Contains(".png") || op.FileName.Contains(".jpeg") || op.FileName.Contains(".JPG"))
            {
                a.ImagePath = op.FileName;
                //FileInfo f = new FileInfo(op.FileName);
                
            }
           
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            
            //a.Autor=tb1.Text;
            a.Tema = tb2.Text;
            a.Category = tb3.Text;
            a.Price = Convert.ToDouble(tb4.Text);
            a.User = CurrentUser;
            this.Close();
        }
    }
}
