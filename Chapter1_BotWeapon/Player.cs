using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Player
	{
		public bool Dead { get; private set; }
		public int Health { get; private set; }

		public Player(int health)
		{
			if (health <= 0) Health = 1;
			else Health = health;
		}
		
		public void TakeDamage(int damage)
		{
			Health -= damage;
			if (Health <= 0) die();
		}

		void die()
		{
			Dead = true;
		}
	}
}
