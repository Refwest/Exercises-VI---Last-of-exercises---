using Exercises_VI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesV;

class Program
{

    static void Main(string[] args)
    {
        //!Exercises VI.1

        //Square[] arrayOfSquares = new Square[10];

        //for (int i = 0; i < 10; i++)
        //{
        //    arrayOfSquares[i] = new Square(i + 1);

        //    Console.WriteLine("Length of side of a sqaure is {0}, area of this square equals {1}",arrayOfSquares[i].SideLength, arrayOfSquares[i].Area);
        //}



        // !Exercises VI.2
        //Taxpayer[] taxPayer = new Taxpayer[5];

        //for(int i = 0; i < taxPayer.Length; i++)
        //{
        //Console.WriteLine("Enter id of {0} taxpayer", i+1);
        //int id = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter gross income of {0} taxpayer", id);
        //int gross = int.Parse(Console.ReadLine());

        //taxPayer[i] = new Taxpayer(id, gross);
        //Console.WriteLine("Taxpayer with id {0} has gross income {1} and tax owed in amount {2}", taxPayer[i].IdNumber, taxPayer[i].GrossIncome, taxPayer[i].TaxOwed);
        //}


        // !Exercises VI.3

        Job j1 = new Job("dishwashing", 5, 14);
        Console.WriteLine("Job type: {0}, Work time: {1} hour, Charge for hour: {2}$, Total pay for work: {3}$", j1.JobType, j1.WorkTime, j1.ChargeForHour, j1.TotalFee);
        Job j2 = new Job("mowing the grass", 3, 16);
        Console.WriteLine("Job type: {0}, Work time: {1} hour, Charge for hour: {2}$, Total pay for work: {3}$", j2.JobType, j2.WorkTime, j2.ChargeForHour, j2.TotalFee);
        Job j3 = j1+j2;
        Console.WriteLine("Job type: {0}, Work time: {1} hour, Charge for hour: {2}$, Total pay for work: {3}$", j3.JobType, j3.WorkTime ,j3.ChargeForHour, j3.TotalFee );
    }



    ///////////////   !END OF THE COURSE: Fundamentals of Programming: Understanding C#Begin your journey into the world of programming through a series of easy to understand video lectures.Ocena: 4,6 na 55440 recenzji10,5 godz. łącznie62 wykładyWszystkie poziomy///////
}