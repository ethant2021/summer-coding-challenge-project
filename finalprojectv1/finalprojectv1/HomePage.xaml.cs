using  System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using finalprojectv1.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime;


namespace finalprojectv1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {

            InitializeComponent();

        }

        public bool pickChecker() {

            if (covidPicker.SelectedItem == null || tempEntry.Text == null)
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

        private async void InfoButton_Clicked(object sender, EventArgs e)
        {
            
            //DisplayAlert("Success!", "You're information has been sucessfully inputed, you will get notified shortly", "OK");

            if (pickChecker())
            {
                Global.enterTemp = true;
                
                string convertTemp = tempEntry.Text;
                int test;
                if (int.TryParse(convertTemp, out test))
                {

                    string covid = Convert.ToString(covidPicker.SelectedItem);
                    string Positive = "Positive";
                    string Negative = "Negative";
                    int pos = 1;
                    int neg = 0;
                    int x = 0;
                    string todaysDate = Convert.ToString(DateTime.Today);
                    if (covid == Positive)
                    {
                        x = 1; 
                    }
                    else if (covid == Negative) 
                    {
                        x = 0;
                    }
                    
                    string aUsersEmail = Global.UserEmail;
                    var updateInfo = (await App.client.GetTable<MainTable>().Where(d => d.Email == aUsersEmail).ToListAsync()).FirstOrDefault(); ;
                    updateInfo.Covid = x;
                    updateInfo.Temp = test;
                    updateInfo.Day = todaysDate;
                    await App.client.GetTable<MainTable>().UpdateAsync(updateInfo);
                    if (covid == Positive)
                    {
                        DisplayAlert("Alert!", "You have Covid go home!", "OK");
                        Global.covid19 = true;
                    }
                    else
                    {
                        var checkPeople = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
                        if (checkPeople != null)
                        {
                            DisplayAlert("Alert!", "There are people in your first class with COVID!", "OK");
                        }
                        var checkPeople2 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom2 == Global.UserClassroom2 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
                        if (checkPeople2 != null)
                        {
                            DisplayAlert("Alert!", "There are people in your second class with COVID!", "OK");
                        }
                        var checkPeople3 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
                        if (checkPeople3 != null)
                        {
                            DisplayAlert("Alert!", "There are people in your third class with COVID!", "OK");
                        }
                        var checkPeople4 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
                        if (checkPeople4 != null)
                        {
                            DisplayAlert("Alert!", "There are people in your fourth class with COVID!", "OK");
                        }
                        var checkPeople5 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
                        if (checkPeople5 != null)
                        {
                            DisplayAlert("Alert!", "There are people in your fifth class with COVID!", "OK");
                        }
                        var checkPeople6 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
                        if (checkPeople6 != null)
                        {
                            DisplayAlert("Alert!", "There are people in your sixth class with COVID!", "OK");
                        }
                        var checkPeople7 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
                        if (checkPeople7 != null)
                        {
                            DisplayAlert("Alert!", "There are people in your seventh class with COVID!", "OK");
                        }
                    }


                    







                }
                else
                {
                    DisplayAlert("ERROR", "You are missing one or more of the fields above", "OK");
                }
            }
            else
            {
            DisplayAlert("ERROR", "Please enter a valid number in the temperature field", "OK");
            }
        }

        private async void updateButton_Clicked(object sender, EventArgs e)
        {


            string covid = Convert.ToString(covidPicker.SelectedItem);
            string Positive = "Positive";
            string Negative = "Negative";
            int pos = 1;
            int neg = 0;
            int x = 0;
            string todaysDate = Convert.ToString(DateTime.Today);

            
            var checkPeople = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
            if (checkPeople != null)
            {
                DisplayAlert("Alert!", "There are people in your first class with COVID!", "OK");
            }
            var checkPeople2 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom2 == Global.UserClassroom2 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
            if (checkPeople2 != null)
            {
                DisplayAlert("Alert!", "There are people in your second class with COVID!", "OK");
            }
            var checkPeople3 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
            if (checkPeople3 != null)
            {
                DisplayAlert("Alert!", "There are people in your third class with COVID!", "OK");
            }
            var checkPeople4 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
            if (checkPeople4 != null)
            {
                DisplayAlert("Alert!", "There are people in your fourth class with COVID!", "OK");
            }
            var checkPeople5 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
            if (checkPeople5 != null)
            {
                DisplayAlert("Alert!", "There are people in your fifth class with COVID!", "OK");
            }
            var checkPeople6 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
            if (checkPeople6 != null)
            {
                DisplayAlert("Alert!", "There are people in your sixth class with COVID!", "OK");
            }
            var checkPeople7 = (await App.client.GetTable<MainTable>().Where(c => c.Classroom1 == Global.UserClassroom1 && c.Covid == pos && c.Day == todaysDate).ToListAsync()).FirstOrDefault();
            if (checkPeople7 != null)
            {
                DisplayAlert("Alert!", "There are people in your seventh class with COVID!", "OK");
            }
            





        }
    }
}

//var user = (await App.client.GetTable<Users>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault(); 
//var user = (await App.client.GetTable<Users>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault(); 

    /*
     * temp
     * if (classroom
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */










//bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
//bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

//            if (isEmailEmpty || isPasswordEmpty)


//Users user = new Users()
//{
//    Email = emailEntry.Text,
//    Password = passwordEntry.Text
//};