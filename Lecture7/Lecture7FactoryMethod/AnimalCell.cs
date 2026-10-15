namespace Lecture7FactoryMethod;


class AnimalCell(Animal animal, Atmosphere atmosphere) : Cell(animal, atmosphere)
{
	private readonly Animal animal = animal;


	public override void Breathe()
	{
		atmosphere.DecreaseOxygen(6);
		atmosphere.IncreaseCO2(6);
	}
}
