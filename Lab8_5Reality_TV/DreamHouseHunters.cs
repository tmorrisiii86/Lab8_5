using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5Reality_TV
{
    class DreamHouseHunters : Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int monthsToBuyHouse;
        public int numOfBedrooms;
        public int numOfBathrooms;

        public DreamHouseHunters(string firstName, string lastName, string dateOfBirth, string address,
            string city, string state, int zipCode, string phoneNumber, string email, string jobTitle,
            int currentAnnualIncome, int monthsToBuyHouse, int numOfBedrooms, int numOfBathrooms) :
            base(firstName, lastName, dateOfBirth, address, city, state, zipCode, phoneNumber, email)
        {
            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentAnnualIncome;
            this.monthsToBuyHouse = monthsToBuyHouse;
            this.numOfBedrooms = numOfBedrooms;
            this.numOfBathrooms = numOfBathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters.");
        }
    }
}
