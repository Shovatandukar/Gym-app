using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_App
{
    class Program
    {
        static void Main(string[] args)
        {

            bool displayMainMenu = true;
            while (displayMainMenu)
            {
                displayMainMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Plese choose an option:");
            Console.WriteLine("1) Calculate BMI");
            Console.WriteLine("2) View Membership rates");
            Console.WriteLine("3) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    CalculateBMI();
                    return true;
                case "2":
                    ShowMembershipRates();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string ChooseMembershipType()
        {
            Console.Write("Membership cost per week is $10 for ‘Basic’, $15 for ‘Regular’ and $20 for ‘Premium’. ");
            Console.WriteLine("Please choose membership Type:");
            Console.WriteLine("1) Basic");
            Console.WriteLine("2) Regular");
            Console.WriteLine("3) Premium");
            
            return Console.ReadLine();
        }

       
        private static void ShowMembershipRates()
        {
            String selection = ChooseMembershipType();
            switch (selection)
            {
                case "1":
                    //print rate for Basic
                    Console.WriteLine("Membership cost per week is $10");
                    Console.WriteLine("Membership cost per month is $40");
                    Console.ReadLine();
                    return;
                case "2":
                    Console.WriteLine("Membership cost per week is $15");
                    Console.WriteLine("Membership cost per month is $60");
                    Console.ReadLine();
                    return;
                case "3":
                    Console.WriteLine("Membership cost per week is $20");
                    Console.WriteLine("Membership cost per month is $80");
                    Console.ReadLine();
                    return;
                default:
                    Console.WriteLine("Invalid Options");
                    return;
            }
        }

        private static void CalculateBMI()
        {
            double height = 0;
            double weight = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("Please enter your Height in meters");
                height = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your Weight in KGs");
                weight = double.Parse(Console.ReadLine());

                Double BMI = Math.Round(weight / (height * height), 2);

                Console.WriteLine(String.Format("Your BMI is : {0}", BMI.ToString()));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please check your input and try again");
                Console.ReadLine();
            }

        }

    }
}
  