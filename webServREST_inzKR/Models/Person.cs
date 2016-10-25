using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webServREST_inzKR.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public HowRelated Relation { get; set; }

        public Person(string Name, string Surname, HowRelated Relation)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Relation = Relation;
        }
    }

    public enum HowRelated
    {
        familyMember,
        friendOfMine,
        someStranger
    }
}