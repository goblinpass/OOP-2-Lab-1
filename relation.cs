using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Relation
    {

        public enum RelationshipType
        {
            Sister,
            Brother,
            Mother,
            Father
        }

        private RelationshipType sister;

     

        public Relation(RelationshipType sister)
        {
           this.sister = sister;
          
        }

        public void ShowRelationshipType(Person x, Person y, RelationshipType r)
        {
            Console.WriteLine("Relationship between " + x.FirstName + "and " + y.FirstName + "is:" + r);
        }


    }
}
