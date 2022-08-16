using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gamer gamer= new Gamer();
            //gamer.BirthDay = 15;
            //gamer.FirstName = "kadir";
            //gamer.LastName = "ceylan";
            //gamer.IdentityNumber = 15615665;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { BirthDay = 15, FirstName = "kadir", LastName = "ceylan", IdentityNumber = 15615665 });

            
        }
    }
}
