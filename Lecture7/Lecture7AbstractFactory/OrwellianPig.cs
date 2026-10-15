namespace Lecture7AbstractFactory;


class OrwellianPig : Pig
{
	public string Name => "Napoleon";


	public void Oink(TextWriter writer)
	{
		writer.WriteLine();
		writer.WriteLine("Four feet good, two feet better");
	}
}
