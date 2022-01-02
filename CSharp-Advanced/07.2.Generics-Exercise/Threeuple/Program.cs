using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputNameAdressTown = Console.ReadLine().Split();
            string name = $"{inputNameAdressTown[0]} {inputNameAdressTown[1]}";
            string adress = inputNameAdressTown[2];
            string town = inputNameAdressTown.Length == 5 ? $"{inputNameAdressTown[3]} {inputNameAdressTown[4]}"
                : $"{inputNameAdressTown[3]}";

            Threeuple<string, string, string> threeuplelNameAdressTown = new Threeuple<string, string, string>(name, adress, town);
            
            string[] inputbearMan = Console.ReadLine().Split();
            string bearMan = inputbearMan[0];
            int litersBear = int.Parse(inputbearMan[1]);
            bool isDrunkOrNot = inputbearMan[2] == "drunk";

            Threeuple<string, int, bool> threeupleBearMan = new Threeuple<string, int, bool>(bearMan, litersBear, isDrunkOrNot);

            string[] inputBank = Console.ReadLine().Split();
            string clientName = inputBank[0];
            double accountBalance = double.Parse(inputBank[1]);
            string bankName = inputBank[2];

            Threeuple<string, double, string> threeupleBank = new Threeuple<string, double, string>(clientName, accountBalance, bankName);

            Console.WriteLine(threeuplelNameAdressTown.GetItems());
            Console.WriteLine(threeupleBearMan.GetItems());
            Console.WriteLine(threeupleBank.GetItems());
        }
    }
}
