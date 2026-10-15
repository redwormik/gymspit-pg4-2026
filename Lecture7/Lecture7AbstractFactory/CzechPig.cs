namespace Lecture7AbstractFactory;


class CzechPig : Pig
{
	public string Name => "prase";


	public void Oink(TextWriter writer)
	{
		writer.Write("chro");
	}
}
