using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person p2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person p3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person p4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Relation sisterR = new Relation(Relation.RelationshipType.Sister);
            Relation brotherR = new Relation(Relation.RelationshipType.Brother);

           

            p2.DisplayPersonInfo(p2);
            Console.WriteLine(p3.ToString());
            p1.FavoriteColour = "White";
            p1.DisplayPersonInfo(p1);
            p4.AgeInTenYears(p4);

            sisterR.ShowRelationshipType(p2, p4, Relation.RelationshipType.Sister);
            brotherR.ShowRelationshipType(p1, p3, Relation.RelationshipType.Brother);

            double total= p1.Age + p2.Age+p3.Age+p4.Age;
            Console.WriteLine("Average age is : " + total/ 4);

            Console.WriteLine("The youngest person is " + p2.FirstName);
            Console.WriteLine("The oldest person is " + p3.FirstName);
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());
            Console.ReadKey();
            
           
        }
    }
}

        
    
