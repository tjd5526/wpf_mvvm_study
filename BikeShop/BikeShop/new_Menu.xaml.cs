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

namespace BikeShop
{
    /// <summary>
    /// new_Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class new_Menu : Page
    {
        public new_Menu()
        {
            InitializeComponent();
        }

        private void contact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(contact);
            ns.Navigate(new Uri("/Contact.xaml", UriKind.Relative));
        }

        private void live_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(live);
            ns.Navigate(new Uri("/Discussion.xaml", UriKind.Relative));
        }
    }
}
