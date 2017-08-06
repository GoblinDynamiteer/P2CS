using System;
using System.Collections.Generic;

namespace trf
{
    class Owner
    {
        string firstName, lastName;
        string street, town, country;
        int zipCode;
        DateTime birthDate;
        List<Tiger> tigers; // List of tigers

        /* Constructor */
        public Owner(string firstName, string lastName, DateTime birthDate,
                     string street, string town, int zipCode, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.street = street;
            this.town = town;
            this.country = country;
            this.zipCode = zipCode;
            this.birthDate = birthDate;
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }

        public void AddTiger(string name, string type)
        {
            tigers.Add(new Tiger(name, type));
        }
    }
}
