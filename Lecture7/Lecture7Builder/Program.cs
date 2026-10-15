// https://en.wikipedia.org/wiki/Builder_pattern
// https://refactoring.guru/design-patterns/builder

using Lecture7Builder;


NounClauseBuilder builder = new("elephant");

builder.AddColor("blue")
	.AddColor("green")
	.AddColor("red")
	.SetSize("tiny");

Console.WriteLine(builder.GetNounClause());