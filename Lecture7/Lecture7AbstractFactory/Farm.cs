namespace Lecture7AbstractFactory;


interface Farm
{
	Cow CreateCow();

	Duck CreateDuck();

	Pig CreatePig();
}
