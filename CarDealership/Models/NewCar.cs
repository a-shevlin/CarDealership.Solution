using System.Collections.Generic;

namespace CarDealership.Models
{
  public class NewCar
  {
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Price { get; set; }
    public string Mileage { get; set; }
    public string MakeModel { get; set; }
    private static List<NewCar> _instances = new List<NewCar> {};

    public NewCar()
    { 
      _instances.Add(this);
    }

  public static List<NewCar> GetAll()
  {
    return _instances;
  }
  }
}

// using System;

// namespace Dealership.Models {

//   public class Car
//   {
//      public string MakeModel { get; set; }
//     public int Price { get; set; }
//     public int Miles { get; set; }

//      public Car(string makeModel, int price, int miles)
//     {
//         MakeModel = makeModel;
//         Price = price;
//         Miles = miles;
//     }

//     public string GetMakeModel()
//     {
//       return _makeModel;
//     }

//     public int GetPrice()
//     {
//       return _price;
//     }

//     public int GetMiles()
//     {
//       return _miles;
//     }

//     public bool WorthBuying(int maxPrice)
//     {
//       return (_price <= maxPrice);
//     }

//     public void SetPrice(int newPrice)
//     {
//       _price = newPrice;
//     }
//   }

// }