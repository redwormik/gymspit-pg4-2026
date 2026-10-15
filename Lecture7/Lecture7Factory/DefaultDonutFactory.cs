namespace Lecture7Factory;


class DefaultDonutFactory(string filling, string glaze) : DonutFactory
{
	private readonly string filling = filling;

	private readonly string glaze = glaze;


	public Donut CreateDonut()
	{
		return new Donut(filling, glaze);
	}
}
