using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ProfileService
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

        private void SendToDb(object sender, RoutedEventArgs e)
        {
            using (var context = new Context())
            {
                Profile profile = new Profile
                {
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    Address = address.Text,
                    ImagePath = logoEnter.Text
                };

                context.Add(profile);
                context.SaveChanges();

                using (var contextP = new Context())
                {
                    string path = "user.png";
                    var user = contextP.Profiles.LastOrDefault();
                    path = user.ImagePath;

                    if (String.IsNullOrWhiteSpace(path)) { path = "user.png"; }

                    logo.Source = new BitmapImage(new Uri(path, UriKind.Relative));
                }
            }
        }
    }
}
