//business logic // The other will contain our custom class. This includes the class declaration itself, our constructor, and any additional methods. We'll refer to this as the class file or business logic. This is the "backend" of our application. 
using System;

namespace Dealership.Models {
public class Car {
  private string _makeModel;
  public string MakeModel {
    get {
      return "That's a big secret. You'll have to visit Lonny's to find a deal!";
    }
    set {
      _makeModel = value;
    }
  }
  private int _price;
  private int _miles;
  private string _driveTrain;

  public Car(string makeModel, int price, int miles, string driveTrain){
    _makeModel = makeModel;
    _price = price;
    _miles = miles;
    _driveTrain = driveTrain;
  }
  public string GetMakeModel() {
    return _makeModel;
  }
  public int GetPrice() {
    return _price;
  }
  public int GetMiles() {
    return _miles;
  }
  public string GetDriveTrain() {
    return _driveTrain;
  }

  //Car secondCar = new Car("1981 Ford Pinto", 200, 36000);//

  public bool WorthBuying(int maxPrice){
    return (_price <= maxPrice);
    }
  public bool WorthRally(string driveTrain) {
    return (_driveTrain == "AWD");
  }
  public void SetPrice(int newPrice) {
    _price = newPrice;
  }
  }
}