namespace Lecture8Composite;


abstract class BinaryOperation(Expression left, Expression right) : Expression
{
	private readonly Expression left = left;
	private readonly Expression right = right;


	public int Evaluate()
	{
		return Compute(left.Evaluate(), right.Evaluate());
	}


	abstract protected int Compute(int leftValue, int rightValue);
}
