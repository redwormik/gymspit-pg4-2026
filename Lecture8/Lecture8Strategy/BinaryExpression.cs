namespace Lecture8Strategy;


class BinaryExpression(
	Expression left,
	Expression right,
	BinaryOperation operation
) : Expression
{
	private readonly Expression left = left;
	private readonly Expression right = right;
	private readonly BinaryOperation operation = operation;


	public int Evaluate()
	{
		return operation.Compute(left.Evaluate(), right.Evaluate());
	}
}
