using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNameAdress = Console.ReadLine().Split();
            string name = $"{inputNameAdress[0]} {inputNameAdress[1]}";
            string adress = inputNameAdress[2];

            MyTuple<string, string> tupelNameAdress = new MyTuple<string, string>(name, adress);

            string[] inputbearMan = Console.ReadLine().Split();
            string bearMan = inputbearMan[0];
            int litersBear = int.Parse(inputbearMan[1]);

            MyTuple<string, int> tupelBearMan = new MyTuple<string, int>(bearMan, litersBear);

            string[] inputIntAndDouble = Console.ReadLine().Split();
            int intProblem = int.Parse(inputIntAndDouble[0]);
            double doubleProblem = double.Parse(inputIntAndDouble[1]);

            MyTuple<int, double> tupleIntDouble = new MyTuple<int, double>(intProblem, doubleProblem);

            Console.WriteLine(tupelNameAdress.GetItems());
            Console.WriteLine(tupelBearMan.GetItems());
            Console.WriteLine(tupleIntDouble.GetItems());
        }
    }
}
