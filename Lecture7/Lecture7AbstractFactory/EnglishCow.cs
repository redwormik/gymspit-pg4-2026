namespace Lecture7AbstractFactory;


class EnglishCow : Cow
{
	public string Name => "cow";


	public void Moo(TextWriter writer)
	{
		writer.Write("mooo");
	}
}
