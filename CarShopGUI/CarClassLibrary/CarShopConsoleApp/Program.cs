using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
	class Program
	{
		static System.DateTime moment = new System.DateTime();
		static Store CarStore = new Store();
		static void Main(string[] args)
		{
			Console.Out.Write("Welcome to the car store.  First you must create some cars and add them to the inventory.  Then you may add cars to the shopping list.  Finally you can checkout once items are added to your shopping list.");
			bool isDone = false;
				while (!isDone) {

					switch (chooseAction()) {

						case 0:
						isDone = true;
						break;

						case 1:
							Console.Out.WriteLine("You have chosen to add a new car to the store");

							string carMake = "";
							string carModel = "";
							decimal carPrice = 0;
							int carYear = 0;
							string carColor = "";

							

						while (carMake.Equals("")) {
							try {
								Console.Out.Write("Please provide a make.  Ford, Chevrolet, BMW, etc");
								carMake = Console.ReadLine();
							} catch (Exception e){
								Console.WriteLine(e.Message);
							}
						}
						
						while (carModel.Equals(""))
						{try
							{
								Console.Out.Write("Please porvide a model of car.  Bronco, Malibu, Accord, etc");
								carModel = Console.ReadLine();
							}
							catch (Exception e)
							{
								Console.WriteLine(e.Message);
							}

						}

						while (carPrice == 0)
						{ try
							{
								Console.Out.Write("Please provide a price for this vehicle?");
								carPrice = int.Parse(Console.ReadLine());
							}
							catch (Exception e) {
								Console.Write(e.Message);
							}

						}

						while (carYear == 0) {
							
							try
							{
								Console.Out.Write("Please provide the year the car was produced.");
								carYear = int.Parse(Console.ReadLine());
							}
							catch (Exception e) {
								Console.WriteLine(e.Message);
							}
						}
						while (carColor.Equals("")){
							try {
								Console.Out.Write("Please provide a color for the car");
								carColor = Console.ReadLine();

							} catch (Exception e) {
								Console.WriteLine(e.Message);
							}
						}
							

							Car newCar = new Car();
							newCar.Make = carMake;
							newCar.Model = carModel;
							newCar.Price = carPrice;
							newCar.Year = carYear;
							newCar.Color = carColor;
							CarStore.CarList.Add(newCar);
							printStoreInventory(CarStore);
							break;

						case 2:
							printStoreInventory(CarStore);

							int choice = -1;
						while (choice < 0 || choice > (CarStore.CarList.Count - 1)){
							try
							{
								Console.Out.Write("Which car would you like to add to the cart (number)?");
								choice = int.Parse(Console.ReadLine());
								CarStore.ShoppingList.Add(CarStore.CarList[choice]);
							}
							catch (Exception e) {
								Console.Write(e.Message);
							}
						}
							printShoppingCart(CarStore);

							break;

						case 3:

							printShoppingCart(CarStore);
							Console.Out.Write("Your total cost is ${0}", CarStore.checkout());
							break;

						default:
							break;



					}

				}
		}

		static public int chooseAction() {
			int choice = 0;
			Console.Out.Write("Choose and action {0} quit  {1} add a car {2} add an item to the cart {3} checkout");
			choice = int.Parse(Console.ReadLine());
			return choice;
			
		}

		static public void printStoreInventory(Store carStore) {
			Console.Out.Write("These are the cars in the store inventory:");
			int i = 0;
			foreach (var c in carStore.CarList) {
				Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
				i++;
			}
		}

		static public void printShoppingCart(Store carStore)
		{
			Console.Out.Write("These are the cars in your Shopping Cart:");
			int i = 0;
			foreach (var c in carStore.ShoppingList)
			{
				Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
				i++;
			}
		}
	}
}
