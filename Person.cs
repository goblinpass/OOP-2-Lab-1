using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Person
    {
        private int personid;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public Person(int personid, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.Personid = personid;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FavoriteColour = favoriteColour;
            this.Age = age;
            this.IsWorking = isWorking;
        }

        public int Personid { get => personid; set => personid = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColour { get => favoriteColour; set => favoriteColour = value; }
        public int Age { get => age; set => age = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public void DisplayPersonInfo(Person x)
        {
            Console.WriteLine(x.Personid + " :" + x.FirstName + " " + x.LastName + " favourite colour is " + x.FavoriteColour);

        }
        public void AgeInTenYears(Person x)
        {
            Console.WriteLine(x.firstName + " " + x.LastName + " Age in 10 years is " + (x.Age + 10));
        }

        public override string ToString()
        {

            return $" ID:{personid} \r\n First Name:{firstName} \r\n Last Name: {lastName} \r\n Favorite Colour:{favoriteColour} \r\n Age:{age} \r\n Is Working:{isWorking}";



        }
    }
}
