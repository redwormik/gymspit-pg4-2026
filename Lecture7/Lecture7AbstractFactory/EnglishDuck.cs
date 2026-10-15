namespace Lecture7AbstractFactory;


class EnglishDuck : Duck
{
	public string Name => "duck";


	public void Quack(TextWriter writer)
	{
		writer.Write("quack");
	}
}
