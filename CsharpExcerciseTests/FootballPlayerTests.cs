using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpExcercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExcercise.Tests
{
	[TestClass()]
	public class FootballPlayerTests
	{
		//[TestMethod()]
		//public void FootballPlayerTest()
		//{
		//	//Assert.Fail();
		//}
		[TestMethod()]
		public void IDTest()
		{
			FootballPlayer player = new FootballPlayer();
			player.ID = 1;
			Assert.AreEqual(1, player.ID);
		}

		[TestMethod()]
		public void NameTest()
		{
			FootballPlayer player = new FootballPlayer();
			player.Name = "Benjamin";
			Assert.AreEqual("Benjamin", player.Name);

			Assert.ThrowsException<ArgumentException>(
				() => player.Name = "Ib");
		}

		[TestMethod()]
		public void PriceTest()
		{
			FootballPlayer player = new FootballPlayer();
			player.Price = 25000;
			Assert.AreEqual(25000, player.Price);

			Assert.ThrowsException<ArgumentOutOfRangeException>(
				() => player.Price = -500);
		}

		[TestMethod()]
		public void ShirtNumberTest()
		{
			FootballPlayer player = new FootballPlayer();
			player.ShirtNumber = 50;
			Assert.AreEqual(50, player.ShirtNumber);

			Assert.ThrowsException<ArgumentOutOfRangeException>(
				() => player.ShirtNumber = 0);
		}

	}
}