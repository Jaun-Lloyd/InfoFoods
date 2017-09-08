using System.Collections.Generic;
using Infoslips.Food.Models;

namespace Infoslips.Food
{
	public class MockTakeOutRepository : ITakeOutRepository
	{
		#region Implementation of ITakeOutRepository

		public IEnumerable<Restaurant> Restaurants
		{
			get
			{
				return new List<Restaurant>
				{
					new Restaurant
					{
						Name = "KFC",
						MenuItems = new List<MenuItems> {
							new MenuItems {
								MenuItemName = "KFC LunchBox", MenuItemPrice = 49.90
							},
							new MenuItems {
								MenuItemName = "KFC Boxmaster", MenuItemPrice = 47.90
							},
							new MenuItems {
								MenuItemName = "KFC Fully Loaded Box Meal", MenuItemPrice = 80.90
							}
						}
					},
					new Restaurant
					{
						Name = "MacDonalds",
						MenuItems = new List<MenuItems> {
							new MenuItems {
								MenuItemName = "Big Mac", MenuItemPrice = 39.90
							},
							new MenuItems {
								MenuItemName = "Quarter Pounder", MenuItemPrice = 50.90
							},
							new MenuItems {
								MenuItemName = "Happy Meal", MenuItemPrice = 50.00
							}
						}
					},
					new Restaurant
					{
						Name = "Steers",
						MenuItems = new List<MenuItems> {
							new MenuItems {
								MenuItemName = "King Steer", MenuItemPrice = 64.50
							},
							new MenuItems {
								MenuItemName = "Prince Burger", MenuItemPrice = 34.50
							},
							new MenuItems {
								MenuItemName = "Rave Burger", MenuItemPrice = 12.50
							}
						}
					}
				};
			}
		}
	}

	#endregion
}
}