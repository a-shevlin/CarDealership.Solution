using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<NewCar> allCars = NewCar.GetAll();
      return View(allCars);
    }
    
    [HttpGet("/cars/new")]
    public ActionResult CarForm() { return View(); }
    
    [HttpPost("/cars")]
    public ActionResult Index(string year, string make, string model, string mileage, string price)
    {
    NewCar newCar = new NewCar();
    newCar.Year = year;
    newCar.Mileage = mileage;
    newCar.Make = make;
    newCar.Model = model;
    newCar.Price = price;
    newCar.Year = year;
    newCar.Mileage = mileage;
    newCar.Make = make;
    newCar.Model = model;
    newCar.Price = price;
    return RedirectToAction("Index");
    }
  }
}