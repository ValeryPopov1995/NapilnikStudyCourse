using System;

namespace NapilnikStudyCourse.Chapter1_Store
{
	public class Shop
	{
		private readonly Warehouse _warehouse;
		private Cart _cart;
		
		public Shop(Warehouse warehouse)
		{
			if (warehouse == null)
				throw new ArgumentNullException();
			
			_warehouse = warehouse;
		}
		
		public Cart Cart()
		{
			_cart = new Cart(_warehouse);
			return _cart;
		}
	}
}
