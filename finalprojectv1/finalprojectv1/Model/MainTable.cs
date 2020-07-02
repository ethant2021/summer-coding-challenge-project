using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace finalprojectv1.Model
{
    class MainTable
    {
        public string Id { get; set; }
        public string Day { get; set; }
        public string Classroom1 { get; set; }
        public string Classroom2 { get; set; }
        public string Classroom3 { get; set; }
        public string Classroom4 { get; set; }
        public string Classroom5 { get; set; }
        public string Classroom6 { get; set; }
        public string Classroom7 { get; set; }
        public int Covid { get; set; }
        public int Temp { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }






        public static string passId(string Email)
        {

            var test = App.client.GetTable<MainTable>().Where(t => t.Email == Email).ToListAsync();
            string hopework = Convert.ToString(test.Id);
            return hopework;
            Global.UserID = hopework;
           

        }
    }
}
