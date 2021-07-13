using System;
using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter1_Store
{
	[TestFixture]
	public class StoreTest
	{
		[Test]
		public void UseCase()
		{
			Good iPhone12 = new Good("iPhone 12");
			Good iPhone11 = new Good("iPhone 11");
			
			Warehouse warehouse = new Warehouse();
			
			Shop shop = new Shop(warehouse);
			
			warehouse.Delieve(iPhone12, 10);
			warehouse.Delieve(iPhone11, 1);
			
			warehouse.ShowAvailableGoods();
			
			Cart cart = shop.Cart();
			cart.Add(iPhone12, 4);
			
			cart.ShowRequestGoods();
		}
	}
}
