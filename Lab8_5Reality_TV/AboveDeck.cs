using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5Reality_TV
{
    class AboveDeck : Application
    {
        public int yearsOfExpBoating;
        public string nationality;

        public AboveDeck(string firstName, string lastName, string dateOfBirth, string address,
            string city, string state, int zipCode, string phoneNumber, string email,
            int yearsOfExpBoating, string nationality) : base(firstName, lastName, dateOfBirth, address,
                city, state, zipCode, phoneNumber, email)
        {
            this.yearsOfExpBoating = yearsOfExpBoating;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck.");
        }
    }
}