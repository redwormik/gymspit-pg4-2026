namespace Lecture7AbstractFactory;


class EnglishFarm : Farm
{
	virtual public Cow CreateCow()
	{
		return new EnglishCow();
	}


	virtual public Duck CreateDuck()
	{
		return new EnglishDuck();
	}


	virtual public Pig CreatePig()
	{
		return new EnglishPig();
	}
}
