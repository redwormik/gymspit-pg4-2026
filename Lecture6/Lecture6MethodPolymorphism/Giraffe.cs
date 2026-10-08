namespace Lecture6MethodPolymorphism;


public class Giraffe : Omnivore
{
	public override string DoSound()
	{
		return "Nom, nom...";
	}


	public new bool DoesEat(string food)
	{
		return food.StartsWith("high ");
	}


	public override int GetStomachCount()
	{
		return 4;
	}
}
