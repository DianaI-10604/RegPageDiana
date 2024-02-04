using Avalonia.Controls;
using Avalonia.Interactivity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegPageDiana
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Register(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Text1.Text = FirstName.Text;
            w1.Text2.Text = LastName.Text;
            w1.Email.Text = Email.Text;
            w1.Password.Text = Password.Text;

            w1.Show();
        }
    }
}