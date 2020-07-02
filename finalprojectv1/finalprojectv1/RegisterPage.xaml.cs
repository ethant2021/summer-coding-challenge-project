using finalprojectv1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace finalprojectv1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            if (passwordEntry.Text == confirmPasswordEntry.Text)
            {
                var check = (await App.client.GetTable<MainTable>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();
                if (check != null)
                {
                    DisplayAlert("Error!", "Email already in use!", "OK");
                }
                else
                {
                    MainTable user = new MainTable()
                    {
                        Classroom1 = (string)classPicker1.SelectedItem,
                        Classroom2 = (string)classPicker2.SelectedItem,
                        Classroom3 = (string)classPicker3.SelectedItem,
                        Classroom4 = (string)classPicker4.SelectedItem,
                        Classroom5 = (string)classPicker5.SelectedItem,
                        Classroom6 = (string)classPicker6.SelectedItem,
                        Classroom7 = (string)classPicker7.SelectedItem,
                        Email = emailEntry.Text,
                        Password = passwordEntry.Text
                    };

                    await App.client.GetTable<MainTable>().InsertAsync(user);
                    Navigation.PushAsync(new MainPage());
                }                
            }
            else
            {
                DisplayAlert("Error", "Passwords don't match", "Ok");
            }
        }

        private void LoginUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}