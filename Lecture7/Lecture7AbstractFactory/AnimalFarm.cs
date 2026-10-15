namespace Lecture7AbstractFactory;


class AnimalFarm : EnglishFarm
{
	override public Pig CreatePig()
	{
		return new OrwellianPig();
	}
}
