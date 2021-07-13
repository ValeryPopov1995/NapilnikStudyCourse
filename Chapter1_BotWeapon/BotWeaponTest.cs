using System;
using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	[TestFixture]
	public class BotWeaponTest
	{
		[Test]
		public void CanIFire()
		{
			var p = new Player(10);
			var w = new Weapon(1, 5);
			
			w.Fire(p);
			Assert.AreEqual(9, p.Health);
		}
		
		[Test]
		public void ComplexSimulation()
        {
			var p = new Player(2);
			var w = new Weapon(1, 5);
			var b = new Bot(w);

			b.OnSeePlayer(p);
			Assert.AreEqual(false, p.Dead);
		}
	}
}
