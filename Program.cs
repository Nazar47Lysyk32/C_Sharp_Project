using ConsoleApp2;
using System;

namespace C_3._3
{
    delegate void AttackDelagate();

    class Program
    {
        private static string check_random;

        public static void Main(string[] args)
        {
            Archer archer = new Archer();
            Warrior warrior = new Warrior();
            Mage mage = new Mage();

            Console.WriteLine("Welcome to Area");
            Console.WriteLine("Change Heroes");
            Console.WriteLine("\n1-Archer.\n2-Maga \n3-Warrior \n4-Exit");

            bool check_exit;

            while (check_exit)
            {

                string check;
                check = Console.ReadLine();
                switch (check)
                {
                    case ("1"):

                        string heroes = "Maga"; ;
                        string heroes1 = "Archer";
                        string heroes2 = "Warrior";

                        string ckeck_random;

                        Random random = new Random();
                        int a = random.Next(1, 4);

                        if (a == 1)
                        {
                            check_random = heroes;
                        }

                        if (a == 2)
                        {
                            check_random = heroes1;
                        }

                        if (a == 3)
                        {
                            check_random = heroes2;
                        }


                        Console.WriteLine("You change 'Maga'");
                        Console.WriteLine($"You choise" { heroes } );
                        int damage = mage.attack_dg(archer.AttackPower, Attack.Magical,);

                        Console.WriteLine($"You Enemy" { heroes} );

                        check_exit = false;
                        break;


                //    case ("2"):
                //        Console.WriteLine("You change 'Archer'");
                //        Console.WriteLine($"You choise" { heroes1 } );
                //        int damage = archer.attack_dg(mage.AttackPower, Attack.Physical,);

                //        Console.WriteLine($"You Enemy" { heroes1 } );

                //        check_exit = false;
                //        break;


                //    case ("3"):
                //        Console.WriteLine("You change 'Warrior'");
                //        Console.WriteLine($"You choise" { heroes2 } );
                //        int damage = warrior.attack_dg(mage.AttackPower, Attack.Physical,);

                //        Console.WriteLine($"You Enemy" { heroes2 } );

                //        check_exit = false;


                //        break;

                //    case ("4"):
                //        break;
                //}








            }





        }
    }

}