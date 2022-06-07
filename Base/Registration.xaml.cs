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

namespace Base
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Parol1.Password == Parol2.Text || Parol1.Password.Length > 0 && Parol2.Text.Length > 0 && Login1.Text.Length > 0 )
            {
                
                MessageBox.Show("You have successfully registered");
                NavigationService.Navigate(new Page1());
            }
            else
            {
                MessageBox.Show("Error");
            }
            var db = new vlad_uEntities();
            var user = new Users();
            user.login = Login1.Text;
            user.password = Parol2.Text;
            db.Users.Add(user);
            db.SaveChanges();


        }
    }
}