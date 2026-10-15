namespace Lecture7AbstractFactory;


class GermanCow : Cow
{
	public string Name => "Kuh";


	public void Moo(TextWriter writer)
	{
		writer.Write("muuh");
	}
}
