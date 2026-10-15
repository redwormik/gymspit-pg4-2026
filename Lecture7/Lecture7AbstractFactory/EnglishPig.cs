namespace Lecture7AbstractFactory;


class EnglishPig : Pig
{
	public string Name => "pig";


	public void Oink(TextWriter writer)
	{
		writer.Write("oink");
	}
}
