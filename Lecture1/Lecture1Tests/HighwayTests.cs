using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture1;


namespace Lecture1.Tests
{
	[TestClass()]
	public class HighwayTests
	{
		[TestMethod()]
		public void OtherEndTest()
		{
			City praha = new City("Praha");
			City brno = new City("Brno");

			Highway highway = new Highway(praha, brno, 200);

			Assert.AreEqual(brno, highway.OtherEnd(praha));
			Assert.AreEqual(praha, highway.OtherEnd(brno));
			Assert.ThrowsException<ArgumentException>(() => highway.OtherEnd(new City("Bratislava")));
		}
	}
}