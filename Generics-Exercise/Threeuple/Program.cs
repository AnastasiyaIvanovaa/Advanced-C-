using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] adressData = Console.ReadLine().Split();
            string name = $"{adressData[0]} {adressData[1]}";
            string town = adressData[3];
            if(adressData.Length==5)
            {
                town+=$" {adressData[4]}";
            }
            Threeuple<string, string, string> adress = new Threeuple<string, string, string>(name, adressData[2], town);
            string[] drink = Console.ReadLine().Split();
            string yesOrNot = string.Empty;
            if (drink[2] == "drunk")
            {
                yesOrNot = "True";
            }
            else
            {
                yesOrNot= "False";
            }
            Threeuple<string, int, string> drinker = new Threeuple<string, int, string>(drink[0], int.Parse(drink[1]), yesOrNot);
            string[] bank = Console.ReadLine().Split();
            Threeuple<string, double, string> account = new Threeuple<string, double, string>(bank[0], double.Parse(bank[1]), bank[2]);
            Console.WriteLine(adress);
            Console.WriteLine(drinker);
            Console.WriteLine(account);
        }
    }
}
