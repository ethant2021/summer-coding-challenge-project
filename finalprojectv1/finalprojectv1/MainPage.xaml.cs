using finalprojectv1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace finalprojectv1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);

            iconImage.Source = ImageSource.FromResource("finalprojectv1.Assets.schoollogo.jpg", assembly);

        }


        private async void LoginButton_Clicked(object sender, EventArgs e)
        {

            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEmpty || isPasswordEmpty)
            {
                DisplayAlert("Error", "Missing Email or Password", "OK");
            }
            else
            {

                // app.client
                String Email = emailEntry.Text;
                Global.UserEmail = emailEntry.Text;
                var user = (await App.client.GetTable<MainTable>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password == passwordEntry.Text)//  THIS SI WAHT I NEED TO USE
                    {
                        MainTable.passId(Email);
                        Global.UserClassroom1 = user.Classroom1;
                        Global.UserClassroom2 = user.Classroom2;
                        Global.UserClassroom3 = user.Classroom3;
                        Global.UserClassroom4 = user.Classroom4;
                        Global.UserClassroom5 = user.Classroom5;
                        Global.UserClassroom6 = user.Classroom6;
                        Global.UserClassroom7 = user.Classroom7;
                      
                        await Navigation.PushAsync(new LinkingPage());
                        

                    }
                        

                    else
                        DisplayAlert("Error", "Incorrect Email Or Password", "OK");
                }
                else 
                {
                    DisplayAlert("Error", "Missing Email or Password", "OK");
                }
            }

        }
        private void RegisterButton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new RegisterPage());
           
        }
    }
}
