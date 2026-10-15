namespace Lecture7AbstractFactory;


class CzechFarm : Farm
{
	public Cow CreateCow()
	{
		return new CzechCow();
	}


	public Duck CreateDuck()
	{
		return new CzechDuck();
	}


	public Pig CreatePig()
	{
		return new CzechPig();
	}
}
