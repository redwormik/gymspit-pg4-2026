namespace Lecture7FactoryMethod;


class Animal(Atmosphere atmosphere) : Organism(atmosphere)
{
	// factory method
	protected override Cell CreateCell()
	{
		return new AnimalCell(this, atmosphere);
	}
}
