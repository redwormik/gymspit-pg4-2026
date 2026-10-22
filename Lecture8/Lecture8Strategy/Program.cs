// https://en.wikipedia.org/wiki/Strategy_pattern
// https://refactoring.guru/design-patterns/strategy

using Lecture8Strategy;

BinaryOperation addition = new Addition();
BinaryOperation subtraction = new Subtraction();
BinaryOperation multiplication = new Multiplication();
BinaryOperation division = new Division();

// (15 + (3 * 9))
Expression expression = new BinaryExpression(
	new Value(15),
	new BinaryExpression(
		new Value(3),
		new Value(9),
		multiplication
	),
	addition
);
Console.WriteLine($"(15 + (3 * 9)) = {expression.Evaluate()}");

// ((93 - (15 / 7)) / 3) * (4 + 1)
Expression expression2 = new BinaryExpression(
	new BinaryExpression(
		new BinaryExpression(
			new Value(93),
			new BinaryExpression(
				new Value(15),
				new Value(7),
				division
			),
			subtraction
		),
		new Value(3),
		division
	),
	new BinaryExpression(
		new Value(4),
		new Value(1),
		addition
	),
	multiplication
);
Console.WriteLine($"((93 - (15 / 7)) / 3) * (4 + 1) = {expression2.Evaluate()}");
