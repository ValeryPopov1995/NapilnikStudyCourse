using System;

namespace NapilnikStudyCourse.Chapter1_Lobby
{
	public class Player
	{
		public readonly string Nick = "Player";
		public bool IsReady {get; private set;}

		private Room _connectedRoom;

		public Player(string nick)
        {
			Nick = nick;
        }
		
		public bool TryConnectToRoom(Room room)
		{
			if (room == null)
				throw new ArgumentNullException();

			if (room.AddPlayer(this))
			{
				_connectedRoom = room;
				return true;
			}
			return false;
		}
		
		public Room CreateRoom(int maxPlayers)
		{
			if (maxPlayers < 1)
				throw new ArgumentOutOfRangeException();

			if (_connectedRoom != null)
				_connectedRoom.RemovePlayer(this);
			
			IsReady = false;
			_connectedRoom = new Room(maxPlayers, this);
			
			return _connectedRoom;
		}
		
		public void SendMassage(string massage)
		{
			if (_connectedRoom == null) return;

			if (massage == null)
				throw new ArgumentNullException();

			_connectedRoom.GetMassage(this, massage);
		}
		
		public void SetReady(bool isReady)
		{
			if (isReady == IsReady || _connectedRoom == null) return;
			
			IsReady = isReady;
		}
	}
}
