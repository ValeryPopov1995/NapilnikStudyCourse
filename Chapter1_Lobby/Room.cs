using System.Collections.Generic;
using System;

namespace NapilnikStudyCourse.Chapter1_Lobby
{
	public class Room
	{
		public int MaxPlayers { get; private set; }
		public List<Player> Players {get; private set;}
		public List<string> Chat { get; private set; }
		
		private bool _gameMode = false;
		private int _readyPlayers
		{
			get
			{
				int count = 0;
				foreach (Player p in Players) if (p.IsReady) count++;
				return count;
			}
		}

		public Room(int maxPlayers, Player player)
		{
			if (player == null)
				throw new ArgumentNullException();

			int defaultMaxPlayers = 30;
			
			Players = new List<Player>();
			Chat = new List<string>();

			if (maxPlayers > 0)
				MaxPlayers = maxPlayers;
			else
				MaxPlayers = defaultMaxPlayers;
			
			AddPlayer(player);
			Console.WriteLine("room created with MaxPlayers: " + MaxPlayers);
		}
		
		public bool AddPlayer(Player player)
		{
			if (player == null)
				throw new ArgumentNullException();

			if (_readyPlayers < MaxPlayers)
			{
				Players.Add(player);
				return true;
			}
			return false;
		}
		
		public void RemovePlayer(Player player)
		{
			if (player == null)
				throw new ArgumentNullException();

			Players.Remove(player);
			updateReadyPlayers();
		}

		public void GetMassage(Player player, string massage)
		{
			if (player == null || massage == null)
				throw new ArgumentNullException();

			string m = player.Nick + " : " + massage;
			Chat.Add(m);
		}

		private void updateReadyPlayers()
		{
			//readyPlayers == MaxPlayers ? _gameMode = true : _gameMode = false;
			if (_readyPlayers == MaxPlayers)
				_gameMode = true;
			else
				_gameMode = false;
		}
		
	}
}
