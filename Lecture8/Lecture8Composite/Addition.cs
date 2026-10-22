namespace Lecture8Composite;


class Addition(Expression left, Expression right) : BinaryOperation(left, right)
{
	protected override int Compute(int leftValue, int rightValue)
	{
		return leftValue + rightValue;
	}
}
