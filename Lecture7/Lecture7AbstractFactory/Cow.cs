namespace Lecture7AbstractFactory;


interface Cow
{
	string Name { get; }

	void Moo(TextWriter writer);
}
