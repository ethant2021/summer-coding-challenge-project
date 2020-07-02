using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalprojectv1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiagnoseCenter : ContentPage
    {
        public DiagnoseCenter()
        {
            InitializeComponent();





        }


        public bool pickChecker()
        {

            if (feverPicker.SelectedItem == null || coughPicker.SelectedItem == null || breathingPicker.SelectedItem == null || headachePicker.SelectedItem == null || musclePicker.SelectedItem == null || diarrheaPicker.SelectedItem == null)
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }







        private void checkSymptoms_Clicked(object sender, EventArgs e)
        {

            if (pickChecker())
            {
                if (feverPicker.SelectedItem == "Yes" && coughPicker.SelectedItem == "Yes" && breathingPicker.SelectedItem == "Yes" && headachePicker.SelectedItem == "Yes" && musclePicker.SelectedItem == "Yes" && diarrheaPicker.SelectedItem == "Yes")
                {
                    DisplayAlert("Alert!", "You have symptoms of Covid! Go get tested!", "OK");
                }
                else if (feverPicker.SelectedItem == "Yes" && coughPicker.SelectedItem == "No" && breathingPicker.SelectedItem == "No" && headachePicker.SelectedItem == "Yes" && musclePicker.SelectedItem == "No" && diarrheaPicker.SelectedItem == "No")
                {
                    DisplayAlert("Alert!", "You have symptoms of a common Cold!", "OK");
                }
                else if (feverPicker.SelectedItem == "No" && coughPicker.SelectedItem == "Yes" && breathingPicker.SelectedItem == "No" && headachePicker.SelectedItem == "Yes" && musclePicker.SelectedItem == "Yes" && diarrheaPicker.SelectedItem == "No")
                {
                    DisplayAlert("Alert!", "You have symptoms of dehydration! Go drink some water!", "OK");
                }
                else
                {
                    DisplayAlert("Error", "Unknown diagnosis", "OK");
                }
            }
            else
                DisplayAlert("Error!", "You are missing one or more of the fields above!", "OK");






        }
    }
}