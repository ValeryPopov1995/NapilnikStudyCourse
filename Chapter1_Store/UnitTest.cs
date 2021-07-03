using System;
using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter1_Store
{
	[TestFixture]
	public class UnitTest
	{
		[Test]
		[ExpectedException(typeof(Exception))]
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
			cart.Add(iPhone11, 3); // expected exception
			
			cart.ShowRequestGoods();
		}
		
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NullArguments()
		{
			Good iPhone11 = new Good("iPhone 10");
			Warehouse warehouse = new Warehouse();
			Shop shop = new Shop(warehouse);
			
			warehouse.Delieve(null, 9);
		}
	}
}
