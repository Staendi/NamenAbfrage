using System;

namespace NamenAbfrage
{

    /// <summary>
    /// Ein Programm welches Namen/Passwort lesen kann
    /// </summary>
    class Program
    {

        static void Main()
        {
            //Benutzername
            var UserName = "Username";
            //Passwort
            var Password = "Password";


            Console.WriteLine("Bitte gib deinen Username ein:");
            if(Console.ReadLine() == UserName)
            {
                Console.WriteLine("Bitte gib dein Passwort ein:");
                if(Console.ReadLine() == Password)
                {
                    Console.WriteLine("Du wurdest eingeloggt!");
                    Console.WriteLine("Viel Spaß...");

                    //Ende
                }
                //Wenn Passwort falsch
                else
                {
                    Console.WriteLine("Falsches Passwort angegeben!");
                    //Programm wiederholen
                    Main();
                }
            }
            //Wenn Username falsch
            else
            {
                Console.WriteLine("Falscher UserName angegeben!");
                //Programm wiederholen
                Main();
            }
        }
    }
}
