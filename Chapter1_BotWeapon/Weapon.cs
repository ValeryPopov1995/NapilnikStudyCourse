using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Weapon
	{
		int _damage, _bullets;
		
		public int Damage
		{
			get { return _damage; }
			private set
			{
				if (value > 0) _damage = value;
				else _damage = 0;
			}
		}
		
		public int Bullets
		{
			get { return _bullets; }
			private set
			{
				if (value > 0) _bullets = value;
				else _bullets = 0;
			}
		}
		
		public Weapon(int damage, int bullets)
		{
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
