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
using Hotel.Models;
namespace Hotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HotelEntities context = new HotelEntities();
            User user = new User();
            user.username = "Emil";
            user.first_name = "Botezatu";
            user.last_name = "Emil";
            user.role = "client";

            //user = context.Users.Add(new User() { username = "Emil", first_name = "Botezatu", last_name = "Emil", role = "employee", });
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
