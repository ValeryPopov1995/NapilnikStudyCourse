using System;
using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	[TestFixture]
	public class UnitTest
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
		public void NotNegativeDamage()
		{
			var p = new Player(10);
			var w = new Weapon(-1, -5);
			
			w.Fire(p);
			Assert.AreEqual(0,w.Damage);
		}
		
		[Test]
		public void CheckAllSimulation()
		{
			var p = new Player(10);
			var w = new Weapon(1, 5);
			var b = new Bot(w);
			
			b.OnSeePlayer(p);
			Assert.AreEqual(9, p.Health);
		}
		
		[Test]
		public void HEY_CanYouBreakIt()
		{
			Assert.AreEqual(9, 9);
		}
	}
}
