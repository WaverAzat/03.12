﻿using System;
using Build;
using Commerce;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestСase 1");
            Bank wolkStreet = new Bank();
            wolkStreet.CreateAccount();
            wolkStreet.CreateAccount(type: TypeAccount.Сберегательный);
            wolkStreet.CreateAccount(type: TypeAccount.Текущий);
            wolkStreet.DeleteAccount(4364_2868_4768_0000);
            foreach (var item in wolkStreet.GetListAccount())
            {
                item.Display();
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("TestCase 2");
            Creator.CreateBuild(height: 25, numberStoreys: 5, numberEntrance: 2, numberFlats: 10);
            Creator.CreateBuild(height: 50, numberStoreys: 10, numberEntrance: 3, numberFlats: 50);
            Creator.CreateBuild(height: 75, numberStoreys: 15, numberEntrance: 4, numberFlats: 100);
            Creator.CreateBuild(height: 100, numberStoreys: 20, numberEntrance: 5, numberFlats: 200);
            Creator.DeleteBuilding(137742);
            foreach (var item in Creator.GetCreatedBuildingsList())
            {
                item.Display();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}