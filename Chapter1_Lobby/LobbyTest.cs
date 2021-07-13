using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter1_Lobby
{
	[TestFixture]
	public class LobbyTest
	{
		[Test]
		public void CheckAllSimulation()
		{
			Player p1 = new Player("p1");
			Player p2 = new Player("p2");
			Player p3 = new Player("p3");
			
			var r1 = p1.CreateRoom(2);
			
			p2.TryConnectToRoom(r1);

			p1.SendMassage("пошумим");
			
			Assert.AreEqual(2, r1.Players.Count);
		}
	}
}
