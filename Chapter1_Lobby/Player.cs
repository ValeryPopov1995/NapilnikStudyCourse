using System;

namespace NapilnikStudyCourse.Chapter1_Lobby
{
	public class Player
	{
		public bool IsReady {get; private set;}
		Room _connectedRoom;
		
		public bool TryConnectToRoom(Room room)
		{
			if (room.AddPlayer(this))
			{
				_connectedRoom = room;
				return true;
			}
			return false;
		}
		
		public Room CreateRoom(int maxPlayers)
		{
			if (_connectedRoom != null) _connectedRoom.RemovePlayer(this);
			
			IsReady = false;
			_connectedRoom = new Room(maxPlayers, this);
			
			return _connectedRoom;
		}
		
		public void SendMassage(string massage)
		{
			if (_connectedRoom == null) return;
			
			_connectedRoom.GetMassage(this, massage);
		}
		
		public void SetReady(bool isReady)
		{
			if (isReady == IsReady || _connectedRoom == null) return;
			
			IsReady = isReady;
		}
	}
}
