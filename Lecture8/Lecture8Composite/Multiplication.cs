namespace Lecture8Composite;


class Multiplication(Expression left, Expression right) : BinaryOperation(left, right)
{
	protected override int Compute(int leftValue, int rightValue)
	{
		return leftValue * rightValue;
	}
}
