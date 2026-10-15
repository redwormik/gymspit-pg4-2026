namespace Lecture7FactoryMethod;


abstract class Organism(Atmosphere atmosphere)
{
	protected Atmosphere atmosphere = atmosphere;

	private readonly IList<Cell> cells = [];


	public void Breathe()
	{
		foreach (Cell cell in cells) {
			cell.Breathe();
		}
	}


	public void Grow()
	{
		cells.Add(CreateCell());
	}


	// factory method
	protected abstract Cell CreateCell();
}
