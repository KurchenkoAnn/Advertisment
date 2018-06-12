using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    
    public partial class MainWindow : Window
    { 
        ObservableCollection<Advertisement> adv= new ObservableCollection<Advertisement>();
        public MainWindow()
        {

            InitializeComponent();

            adv.Add(new Advertisement() {Tema="I will sell a dog",Autor = "Vasy", Category="Dogs",Description = "The puppy is white.Breed: reetworker." ,ImagePath = @"C:\Users\user.STEP.001\Desktop\images.jpg", Price=3000   });
            adv.Add(new Advertisement() { Tema = "I will sell a car", Autor = "Vity", Category = "Cars", Description = "The car is blue.", ImagePath = @"C:\Users\user.STEP.001\Desktop\images (1).jpg", Price=120000 });
            adv.Add(new Advertisement() { Tema = "I will sell a phone", Autor = "Vika", Category = "Phones", Description = "The phone is black.", ImagePath = @"C:\Users\user.STEP.001\Desktop\len.jpg", Price=2400 });
            lv.ItemsSource = adv;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Window1 add = new Window1();
            add.ShowDialog();
            Advertisement a = add.a;
            adv.Add(a);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window2 reg = new Window2();
            reg.ShowDialog();

            
        }

       
    }
    public class Advertisement
    {
        public string Tema { get; set; }
        public string Autor { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Price { get; set; }
      
    }
}
