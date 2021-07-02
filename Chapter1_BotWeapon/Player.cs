using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Player
	{
		int _health;
		
		public int Health
		{
			get { return _health;}
			private set
			{
				if (value > 0) _health = value;
				else _health = 1;
			}
		}
		
		public Player(int health)
		{
			Health = health;
		}
		
		public void TakeDamage(int damage)
		{
			Health -= damage;
		}
	}
}
