using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using finalprojectv1.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalprojectv1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LinkingPage : ContentPage
    {

        public LinkingPage()
        {
            InitializeComponent();
        }

        private void classEntryPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClassEntryPage());
        }

        private void tempEntryPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        private void refreshGraph_Clicked(object sender, EventArgs e)
        {

        }

        private void diagnosticCenter_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiagnoseCenter());
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var charts = Data.CreateXamarinSampleAsync();
            this.chart1.Chart = (await charts)[0];
        }


        
        
        public static async Task<int> getCovidClass(String className)
        {
            int i = 0;
            var test = (await App.client.GetTable<MainTable>().Where(u => u.Classroom1 == className).ToListAsync()).FirstOrDefault();
            if (test != null)
            {
                if (test.Covid == 1)//  THIS SI WAHT I NEED TO USE
                {
                    i++;
                }
            }
            var test2 = (await App.client.GetTable<MainTable>().Where(u => u.Classroom2 == className).ToListAsync()).FirstOrDefault();
            if (test2 != null)
            {
                if (test2.Covid == 1)//  THIS SI WAHT I NEED TO USE
                {
                    i++;
                }
            }
            var test3 = (await App.client.GetTable<MainTable>().Where(u => u.Classroom3 == className).ToListAsync()).FirstOrDefault();
            if (test3 != null)
            {
                if (test3.Covid == 1)//  THIS SI WAHT I NEED TO USE
                {
                    i++;
                }
            }
            var test4 = (await App.client.GetTable<MainTable>().Where(u => u.Classroom4 == className).ToListAsync()).FirstOrDefault();
            if (test4 != null)
            {
                if (test4.Covid == 1)//  THIS SI WAHT I NEED TO USE
                {
                    i++;
                }
            }
            var test5 = (await App.client.GetTable<MainTable>().Where(u => u.Classroom5 == className).ToListAsync()).FirstOrDefault();
            if (test5 != null)
            {
                if (test5.Covid == 1)//  THIS SI WAHT I NEED TO USE
                {
                    i++;
                }
            }
            var test6 = (await App.client.GetTable<MainTable>().Where(u => u.Classroom6 == className).ToListAsync()).FirstOrDefault();
            if (test6 != null)
            {
                if (test6.Covid == 1)//  THIS SI WAHT I NEED TO USE
                {
                    i++;
                }
            }
            var test7 = (await App.client.GetTable<MainTable>().Where(u => u.Classroom7 == className).ToListAsync()).FirstOrDefault();
            if (test7 != null)
            {
                if (test7.Covid == 1)//  THIS SI WAHT I NEED TO USE
                {
                    i++;
                }
            }

            return Convert.ToInt32(i);
            i = 0;
        }

        private async void checkClass_Clicked(object sender, EventArgs e)
        {
            if (Global.enterTemp) 
            {
            if (Global.covid19) 
                {
                    DisplayAlert("Alert", "You have Covid Go Home!", "OK");
                }
                else
                {
                    int pos = 1;
                    int neg = 0;
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
            else 
            {
                DisplayAlert("Error", "You must enter your temperature first!", "OK");
            }
           
        }








        //<x:String>Mr Smiths class</x:String>
        //            <x:String>Mr Heratys class</x:String>
        //            <x:String>Mr Thackerys class</x:String>
        //            <x:String>Mr Johnnys class</x:String>
        //            <x:String>Mr Lawrences class</x:String>
        //            <x:String>Mr Philips class</x:String>
        //            <x:String>Mr Jeremys class</x:String>
        //            <x:String>Mr Harolds class</x:String>


    };
    }


