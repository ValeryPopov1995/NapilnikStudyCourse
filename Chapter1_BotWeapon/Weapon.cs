using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Weapon
	{
		int _bullets;
		
		public int Damage { get; private set; }
		
		public int Bullets { get; private set; }

		public Weapon(int damage, int bullets)
		{
			if (damage <= 0) Damage = 0;
			else Damage = damage;

			if (bullets <= 0) Bullets = 0;
			else Bullets = bullets;
		}
		
		public void Fire(Player player)
		{
			if (Bullets <= 0) return;
			
			player.TakeDamage(Damage);
			Bullets--;
		}
	}
}
