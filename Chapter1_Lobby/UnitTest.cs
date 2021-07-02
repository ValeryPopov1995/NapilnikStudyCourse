using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using NUnit.Framework;

namespace NapilnikStudyCourse.Chapter1_Lobby
{
	[TestFixture]
	public class UnitTest
	{
		[Test]
		public void CheckAllSimulation()
		{
			Player p1 = new Player();
			Player p2 = new Player();
			Player p3 = new Player();
			
			var r1 = p1.CreateRoom(2);
			
			//p2.TryConnectToRoom(r1);
			
			Assert.AreEqual(1, r1.Players.Count);
		}
	}
}
