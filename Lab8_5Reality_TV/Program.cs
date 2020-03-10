using System;

namespace Lab8_5Reality_TV
{
    class Program
    {
        static void Main(string[] args)
        {
            DreamHouseHunters dhhContestant = new DreamHouseHunters("Omar", "Smith", "2/4/1975",
                "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234",
                "omar.smith@hotmail.com", "Full Stack Web Developer", 100000, 6, 3, 2);

            ParadiseIsland piContestant = new ParadiseIsland("Patti", "Johnson", "5/4/1994",
                "211 Love Rd", "Los Angeles", "California", 90001, "988-444-1234",
                "patti.johnson@gmail.com", "Female", "Carl", 2);

            AboveDeck adContestant = new AboveDeck("Captian", "Lee", "7/12/1964", "311 Bravo Way",
                "Los Angeles", "California", 90001, "711-333-1234", "captian@gmail.com", 20,
                "American");

            dhhContestant.Submit();
            dhhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();
        }
    }
}
