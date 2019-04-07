using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Program
    {
        static void group()
        {
            vehicles Vec = new vehicles();
            weapons Wep = new weapons();
            mission Mis = new mission();
            Personnel Per = new Personnel();

            string name = "";
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("\nSelect from the following Mission options below.");
                Console.Write("1. Airbore Operation " + "2. Hostage Rescue " + "3. Resuplly Mission " + "4. Medivac the wounded " + "5. Testing polymorphism " + "6. Quit");
                Console.Write("\nMy option is: ");
                name = Console.ReadLine();
                switch (name)
                {
                    case "1":
                        Console.Clear();
                        Mis.Deploy("Lets Go!!!");

                        Console.WriteLine("\nMission Brief:");
                        Mis.AirborneOp();
                        Vec.HMWVV();
                        Wep.M240B();
                        Per.Intel();
                        Wep.Fought();

                        Mis.ComeHome("About Time!!");

                        check = false;
                        break;

                    case "2":
                        Console.Clear();
                        Mis.Deploy("Lets Go!!!");

                        Console.WriteLine("\nMission Brief:");
                        Mis.HostageRescue();
                        Vec.FootPatrol();
                        Wep.M4();
                        Per.Infantry();
                        Mis.Fought();

                        Mis.ComeHome("About Time!!");

                        check = false;
                        break;
                    case "3":
                        Console.Clear();
                        Mis.Deploy("Lets Go!!!");

                        Console.WriteLine("\nMission Brief:");
                        Mis.Resupply();
                        Vec.Tank();
                        Wep.TankRound();
                        Per.Supply();
                        Vec.Fought();

                        Mis.ComeHome("About Time!!");
                        
                        check = false;
                        break;

                    case "4":
                        Console.Clear();
                        Mis.Deploy("Lets Go!!!");

                        Console.WriteLine("\nMission Brief:");
                        Mis.Medivac();
                        Vec.LMTV();
                        Wep.M9();
                        Per.Medics();
                        Per.Fought();

                        Mis.ComeHome("About Time!!");

                        check = false;
                        break;

                    case "5":
                        Console.Clear();

                        Console.WriteLine("\nTesting polymorphism:\n");
                Military v = Wep;
                v.Fought();
                v = Mis;
                v.Fought();
                v = Vec;
                v.Fought();
                v = Per;
                v.Fought();


                        check = false;
                        break;

                    case "6":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThanks for playing. Duces (>^_^>) (<^_^<)\n");

                check = true;
                break;

                default:
                        Console.Clear();
                        Console.WriteLine("Invalid Selection");
                check = false;
                break;

            }
            }
        }

        static void Main()
        {
            try
            {
                group();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
