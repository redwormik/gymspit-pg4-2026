namespace Lecture7FactoryMethod;


class PlantCell(Plant plant, Atmosphere atmosphere) : Cell(plant, atmosphere)
{
	private readonly Plant plant = plant;


	public override void Breathe()
	{
		Photosynthesize();
		atmosphere.DecreaseOxygen(2);
		atmosphere.IncreaseCO2(2);
	}


	private void Photosynthesize()
	{
		int amount = (int) Math.Floor(12 * atmosphere.SunIntensity);
		atmosphere.DecreaseCO2(amount);
		atmosphere.IncreaseOxygen(amount);
	}
}
