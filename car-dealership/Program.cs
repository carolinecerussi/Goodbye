//ui front end logic// One will contain the user interface or command line interface logic. This file will be responsible for prompting the user, gathering user input, calling any methods, and returning information to the user.

using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership {

public class Program {
  static void Main() {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "FWD");
    Car yugo = new Car("1980 Yugo Koral", 700, 5600, "FWD");
      Console.WriteLine(yugo.MakeModel);
      yugo.MakeModel = "Worst Car Ever";
      Console.WriteLine(yugo.MakeModel);
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "AWD");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "RWD");

  List<Car>Cars = new List<Car>() {volkswagen,yugo,ford,amc};
// changes price of yugo//
  yugo.SetPrice(300);

  Console.WriteLine("Enter maximum price:");
  string stringMaxPrice = Console.ReadLine();
  int maxPrice = int.Parse(stringMaxPrice);
  Console.WriteLine("Do you want to Rally?! Search for AWD");
  string stringDriveTrain = Console.ReadLine();
  string driveTrain = stringDriveTrain;

  List<Car>CarsMatchingSearch = new List<Car>(0);
  foreach(Car automobile in Cars) {
    if (automobile.WorthBuying(maxPrice) && automobile.WorthRally(driveTrain)) {
      CarsMatchingSearch.Add(automobile);
    }
  }


  foreach(Car automobile in CarsMatchingSearch) {
  Console.WriteLine("----------------------");
  Console.WriteLine(automobile.GetMakeModel());
  Console.WriteLine(automobile.GetMiles() + " miles");
  Console.WriteLine("$" + automobile.GetPrice());
  Console.WriteLine("Drive Train:" + automobile.GetDriveTrain());
  }
}
}
}