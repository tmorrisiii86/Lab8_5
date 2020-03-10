using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5Reality_TV
{
    class ParadiseIsland : Application
    {
        public string gender;
        public string nameOfBoyOrGirlfriend;
        public int yearsDating;

        public ParadiseIsland(string firstName, string lastName, string dateOfBirth, string address,
            string city, string state, int zipCode, string phoneNumber, string email, string gender,
            string nameOfBoyOrGirlfriend, int yearsDating) : base(firstName, lastName, dateOfBirth,
                address, city, state, zipCode, phoneNumber, email)
        {
            this.gender = gender;
            this.nameOfBoyOrGirlfriend = nameOfBoyOrGirlfriend;
            this.yearsDating = yearsDating;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island.");
        }
    }
}
