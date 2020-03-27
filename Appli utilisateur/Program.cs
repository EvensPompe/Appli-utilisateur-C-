using System;

namespace Appli_utilisateur
{
    class Program
    {
        static void Main(string[] args)
        {
            //Début du programme
            Console.WriteLine("Bonjour, nous avons quelques questions à vous poser.");
            Console.WriteLine("Quel est votre nom ?");
            string nomUser = Console.ReadLine();
            while (String.IsNullOrEmpty(nomUser))
            {
                Console.WriteLine("Vous n'avez pas donné votre nom ! S'il vous plait, donnez nous votre nom.");
                nomUser = Console.ReadLine();
            }
            Console.WriteLine($"Salutation {nomUser}");

            Console.WriteLine("Quel âge avez-vous ?");
            string res = Console.ReadLine();
            int age;
            bool ageIsOK = Int32.TryParse(res, out age);
            while (!ageIsOK)
            {
                Console.WriteLine("Votre âge est incorrecte, pouvez-vous me le donner correctement ?");
                res = Console.ReadLine();
                ageIsOK = Int32.TryParse(res, out age);

            }
            Console.WriteLine($"Vous avez {age} ans!");

            Console.WriteLine($"Je résume, vous êtes {nomUser}, vous avez {age} ans !");
        }
    }
}
