using System;

namespace NapilnikStudyCourse.Chapter1_Store
{
	public class Cart
	{
		Warehouse _warehouse;
		GoodsDictionary _goods = new GoodsDictionary();
		
		public Cart(Warehouse warehouse)
		{
			_warehouse = warehouse;
		}
		
		public void Add(Good good, int count)
		{
			if (_warehouse.IsHaveRequestingGoods(good,count)) _goods.Add(good, count);
			else throw new Exception("на складе нет нужного количества запрашиваемых товаров");
		}
		
		public void ShowRequestGoods()
		{
			Console.WriteLine();
			Console.WriteLine("Cart goods:");
			_goods.ShowGoodsInConsole();
			Console.WriteLine();
		}
	}
}
