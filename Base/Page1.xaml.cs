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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new vlad_uEntities();
            var users = db.Users.Where((user) => user.login == Login.Text && user.password == Parol.Password).ToList();
            if (users.Count > 0)
            {
               
                    Console.WriteLine(db.User_Type.Find(users[0].type).Name);        
                
            }
            else
            {
                MessageBox.Show("You are not in the list or you entered incorrect data");
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }
    }
}
