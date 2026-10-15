namespace Lecture7FactoryMethod;


abstract class Cell(Organism organism, Atmosphere atmosphere)
{
	protected readonly Organism organism = organism;
	protected readonly Atmosphere atmosphere = atmosphere;

	public abstract void Breathe();
}
