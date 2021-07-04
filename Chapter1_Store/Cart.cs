using System;
using System.Text;

namespace NapilnikStudyCourse.Chapter1_Store
{
	public class Cart
	{
		Warehouse _warehouse;
		GoodsDictionary _goods = new GoodsDictionary();
		
		public Cart(Warehouse warehouse)
		{
			if (warehouse == null)
				throw new ArgumentNullException();

			_warehouse = warehouse;
		}
		
		public void Add(Good good, int count)
		{
			if (good == null)
				throw new ArgumentNullException();
			
			if (_warehouse.HasRequestingGoods(good,count))
				_goods.Add(good, count);
			else
				throw new Exception("на складе нет нужного количества запрашиваемых товаров");
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
