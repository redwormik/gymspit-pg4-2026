// https://en.wikipedia.org/wiki/Composite_pattern
// https://refactoring.guru/design-patterns/composite

using Lecture8Composite;

Lecture8Composite.File root = new Lecture8Composite.Directory("root", [
	new RegularFile("file1.txt"),
	new RegularFile("file2.txt"),
	new Lecture8Composite.Directory("subdir", [
		new RegularFile("file3.txt"),
		new RegularFile("file4.txt"),
	]),
	new RegularFile("file5.txt"),
]);

root.PrintOn(Console.Out);
Console.WriteLine();


// (15 + (3 * 9))
Expression expression = new Addition(
	new Value(15),
	new Multiplication(
		new Value(3),
		new Value(9)
	)
);
Console.WriteLine($"Answer: {expression.Evaluate()}");
