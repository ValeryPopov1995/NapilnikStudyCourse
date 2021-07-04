using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Player
	{
		public int Health { get; private set; }

		public Player(int health)
		{
			if (health < 1)
				throw new ArgumentOutOfRangeException();
			else
				Health = health;
		}
		public bool Dead => Health <= 0;
		
		public void TakeDamage(int damage)
		{
			if (Dead) return;

			Health -= damage;
		}
	}
}
