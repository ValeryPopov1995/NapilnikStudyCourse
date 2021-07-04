using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Weapon
	{
		public int Damage { get; private set; }
		
		public int Bullets { get; private set; }

		public Weapon(int damage, int bullets)
		{
			if (damage <= 0)
				throw new ArgumentOutOfRangeException();
			if (bullets <= 0)
				throw new ArgumentOutOfRangeException();

			Damage = damage;
			Bullets = bullets;
		}
		
		public void Fire(Player player)
		{
			if (Bullets <= 0) return;
			
			player.TakeDamage(Damage);
			Bullets--;
		}
	}
}
