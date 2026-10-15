namespace Lecture7AbstractFactory;


class GermanPig : Pig
{
	public string Name => "Schwein";


	public void Oink(TextWriter writer)
	{
		writer.Write("grunz");
	}
}
