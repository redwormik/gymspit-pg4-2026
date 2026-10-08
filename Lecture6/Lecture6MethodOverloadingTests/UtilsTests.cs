namespace Lecture6MethodOverloading.Tests;


[TestClass()]
public class UtilsTests
{
	[TestMethod]
	public void LengthTest()
	{
		Assert.AreEqual(7, Utils.Length());
	}


	[TestMethod]
	public void LengthIntTest()
	{
		Assert.AreEqual(1, Utils.Length(0));
		Assert.AreEqual(3, Utils.Length(-99));
		Assert.AreEqual(3, Utils.Length(123));
	}


	[TestMethod]
	public void LengthStringTest()
	{
		Assert.AreEqual(5, Utils.Length("Hello"));
		Assert.AreEqual(11, Utils.Length("Hello World", true));
		Assert.AreEqual(10, Utils.Length("Hello World", false));
	}


	[TestMethod]
	public void LengthArrayTest()
	{
		int[] array = [1, 2, 3, 4, 5];
		Assert.AreEqual(5, Utils.Length(array));
	}


	[TestMethod]
	public void LengthParentTest()
	{
		Parent parent = new Parent();
		Assert.AreEqual(6, Utils.Length(parent));
		Parent childAsParent = new Child();
		Assert.AreEqual(6, Utils.Length(childAsParent));
	}


	[TestMethod]
	public void LengthChildTest()
	{
		Child child = new Child();
		Assert.AreEqual(5, Utils.Length(child));
	}


	public void LengthVirtualTest()
	{
		Parent parent = new Parent();
		Assert.AreEqual(6, Utils.LengthVirtual(parent));
		Child child = new Child();
		Assert.AreEqual(5, Utils.LengthVirtual(child));
		Parent childAsParent = new Child();
		Assert.AreEqual(5, Utils.LengthVirtual(childAsParent));
	}
}