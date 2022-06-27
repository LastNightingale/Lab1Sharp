using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Lab1Sharp
{   internal class Program
    {
        static void Main(string[] args)
        {
            Lists lists_with_information = new Lists();
            Queries query = new Queries();
            Printer print = new Printer();
            Console.WriteLine("1 запит");
            print.Prints(query.AllCars(lists_with_information.Cars));
            Console.WriteLine("2 запит");
            print.Prints(query.CarsWithYearMoreThatTwentyTen(lists_with_information.Cars));
            Console.WriteLine("3 запит");
            print.Prints(query.OrderByLicenseDesc(lists_with_information.People));
            Console.WriteLine("4 запит");
            print.Prints(query.CarsFromFrance(lists_with_information.Cars)) ;
            Console.WriteLine("5 запит");
            print.Prints(query.CarsWithExperiencedDrivers(lists_with_information.People,
                lists_with_information.Connections));
            Console.WriteLine("6 запит");
            print.Prints(query.OwnersByExperience(lists_with_information.People));
            Console.WriteLine("7 запит");
            print.Prints(query.DriverMaxExp(lists_with_information.People,
                lists_with_information.Connections));
            Console.WriteLine("8 запит");
            print.Prints(query.CarsInCertainChassis(lists_with_information.Cars));
            Console.WriteLine("9 запит");
            print.Prints(query.PersonsWithExpLessThanAverage(lists_with_information.People));
            Console.WriteLine("10 запит");
            print.Prints(query.MarksWithTwoWords(lists_with_information.Marks));
            Console.WriteLine("11 запит");
            print.Prints(query.CarsOwnersExpMoreThanNumber(lists_with_information.Cars, 
                lists_with_information.People, lists_with_information.Connections, 17));
            Console.WriteLine("12 запит");
            print.Prints(query.OwnersGroupingWithDriverMoreExp(lists_with_information.Cars, 
                lists_with_information.People, lists_with_information.Connections, 20));
            Console.WriteLine("13 запит");
            print.Prints(query.OwnersWithBlueAndRedCars(lists_with_information.Cars, lists_with_information.People, 
                lists_with_information.Connections));
            Console.WriteLine("14 запит");
            print.Prints(query.DriversOfRightOwners(lists_with_information.Cars, lists_with_information.People,
                lists_with_information.Connections));
            Console.WriteLine("15 запит");
            print.Prints(query.RedCarDriversID(lists_with_information.Cars, lists_with_information.People,
                lists_with_information.Connections));
            Console.WriteLine("16 запит");
            print.Prints(query.MaxAndMinExp(lists_with_information.People));
        }
    }   

}

