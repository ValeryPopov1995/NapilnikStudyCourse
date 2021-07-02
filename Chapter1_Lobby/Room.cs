using System.Collections.Generic;
using System;

namespace NapilnikStudyCourse.Chapter1_Lobby
{
	public class Room
	{
		public List<Player> Players {get; private set;}
		
		bool _gameMode = false;
		List<string> chat = new List<string>();
		
		public int MaxPlayers {get; private set;}
		
		int readyPlayers
		{
			get
			{
				int count = 0;
				foreach(Player p in Players) if (p.IsReady) count++;
				return count;
			}
		}
		
		public Room(int maxPlayers, Player player)
		{
			int defaultMaxPlayers = 30;
			
			Players = new List<Player>();
			if (maxPlayers > 0) MaxPlayers = maxPlayers;
			else MaxPlayers = defaultMaxPlayers;
			
			AddPlayer(player);
			Console.WriteLine("room created with MaxPlayers: " + MaxPlayers);
		}
		
		public bool AddPlayer(Player player)
		{
			if (readyPlayers < MaxPlayers)
			{
				Players.Add(player);
				return true;
			}
			return false;
		}
		
		public void RemovePlayer(Player player)
		{
			Players.Remove(player);
			updateReadyPlayers();
		}
		
		void updateReadyPlayers()
		{
			//readyPlayers == MaxPlayers ? _gameMode = true : _gameMode = false; // not work in my compilator
			if (readyPlayers == MaxPlayers) _gameMode = true;
			else _gameMode = false;
		}
		
		public void GetMassage(Player player, string massage)
		{
			// TODO
		}
	}
}
