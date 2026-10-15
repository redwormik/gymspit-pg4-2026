namespace Lecture7Factory;


class RandomDonutFactory(string[] fillings, string[] glazes) : DonutFactory
{
	private readonly string[] fillings = fillings;

	private readonly string[] glazes = glazes;

	private readonly Random random = new();


	public Donut CreateDonut()
	{
		int filling = random.Next(fillings.Length);
		int glaze = random.Next(glazes.Length);
		return new Donut(fillings[filling], glazes[glaze]);
	}
}
