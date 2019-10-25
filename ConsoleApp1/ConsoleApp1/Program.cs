using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Metod(object obj)
        {
            foreach (Bank bank in obj as List<Bank>)
            {
                Console.WriteLine(bank);
            }
        }

        static void Main(string[] args)
        {
            //List<Bank> banks = new List<Bank> { new Bank { Money = 100, Name = "Name1", Percent = 1, Id = 1}, new Bank { Money = 200, Name = "Name2", Percent = 2, Id = 2 },
            //new Bank { Money = 300, Name = "Name3", Percent = 3, Id = 3}, new Bank { Money = 400, Name = "Name4", Percent = 4, Id = 4}, new Bank { Money = 500, Name = "Name5", Percent = 5, Id = 5},
            //new Bank { Money = 600, Name = "Name6", Percent = 6, Id = 6}, new Bank { Money = 700, Name = "Name7", Percent = 7, Id = 7}};

            //ParameterizedThreadStart threadstart = new ParameterizedThreadStart(Metod);
            //Thread thread = new Thread(threadstart);
            //thread.Start(banks as object);

            Bank bank = new Bank { Name = "Name"};
            bank.Name = "NewName";
            bank.Name = "NewNewName";
            bank.Name = "NewNewNewName";
        }
    }
}