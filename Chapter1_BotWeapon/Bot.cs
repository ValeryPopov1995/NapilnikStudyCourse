using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Bot
	{
		readonly Weapon _weapon;
		
		public Bot(Weapon weapon)
		{
			_weapon = weapon;
		}
		
		public void OnSeePlayer(Player player)
		{
			_weapon.Fire(player);
		}
	}
}
