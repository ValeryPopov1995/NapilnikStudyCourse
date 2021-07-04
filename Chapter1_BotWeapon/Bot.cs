using System;

namespace NapilnikStudyCourse.Chapter1_BotWeapon
{
	public class Bot
	{
		private readonly Weapon _weapon;
		
		public Bot(Weapon weapon)
		{
			_weapon = weapon;
		}
		
		public void OnSeePlayer(Player player)
		{
			if (player.Dead) return;

			_weapon.Fire(player);
		}
	}
}
