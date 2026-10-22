namespace Lecture8Composite;


class Value(int value) : Expression
{
	private readonly int value = value;


	public int Evaluate()
	{
		return value;
	}
}
