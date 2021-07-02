using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace NapilnikStudyCourse.Chapter1_Lobby
{
	public class Room
	{
		public List<Player> Players {get; private set;}
		
		bool _gameMode = false;
		int _maxPlayers;
		List<string> chat = new List<string>();
		
		public int MaxPlayers
		{
			get { return _maxPlayers; }
			private set
			{
				if (value <= 0) _maxPlayers = 30; // default
				else _maxPlayers = value;
			}
		}
		
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
			Players = new List<Player>();
			MaxPlayers = maxPlayers;
			AddPlayer(player);
			Console.WriteLine("room created with MaxPlayers: " + MaxPlayers);
		}
		
		public bool AddPlayer(Player player)
		{
			if (readyPlayers < MaxPlayers)
			{
				
				return true;
			}
			return false;
		}
		
		public void RemovePlayer(Player player)
		{
			Players.Remove(player);
			UpdateReadyPlayers();
		}
		
		public void UpdateReadyPlayers()
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
