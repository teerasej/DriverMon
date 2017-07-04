using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyAppPon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String username = entryUsername.Text;
            var password = entryPassword.Text;
            var email = entryEmail.Text;

            DisplayAlert(
                "ข้อมูลผู้ใช้"
                , "Username: " + username + ", Email: " + email
                , "ยกเลิก");
        }
    }
}
