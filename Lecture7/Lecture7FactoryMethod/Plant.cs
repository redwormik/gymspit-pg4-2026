namespace Lecture7FactoryMethod;


class Plant(Atmosphere atmosphere) : Organism(atmosphere)
{
	// factory method
	protected override Cell CreateCell()
	{
		return new PlantCell(this, atmosphere);
	}
}
