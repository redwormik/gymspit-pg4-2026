namespace Lecture7AbstractFactory;


interface Duck
{
	string Name { get; }

	void Quack(TextWriter writer);
}
