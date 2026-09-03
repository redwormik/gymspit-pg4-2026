using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture1;


namespace Lecture1.Tests
{
	[TestClass]
	public class CityTests
	{
		[TestMethod]
		public void AddHighwayTest()
		{
			City praha = new City("Praha");
			City brno = new City("Brno");
			City bratislava = new City("Bratislava");

			Assert.AreEqual(0, praha.Highways.Count());
			Assert.AreEqual(0, brno.Highways.Count());
			Assert.AreEqual(0, bratislava.Highways.Count());

			praha.AddHighway(brno, 200);
			brno.AddHighway(bratislava, 130);

			Assert.AreEqual(1, praha.Highways.Count());
			Assert.AreEqual(2, brno.Highways.Count());
			Assert.AreEqual(1, bratislava.Highways.Count());

			Assert.AreEqual(brno, praha.Highways.First().OtherEnd(praha));
			Assert.AreEqual(praha, brno.Highways.First().OtherEnd(brno));
			Assert.AreEqual(bratislava, brno.Highways.Last().OtherEnd(brno));
			Assert.AreEqual(brno, bratislava.Highways.First().OtherEnd(bratislava));
		}
	}
}