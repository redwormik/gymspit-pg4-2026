// https://en.wikipedia.org/wiki/Factory_(object-oriented_programming)

using Lecture7Factory;


DonutFactory defaultFactory = new DefaultDonutFactory("chocolate", "sugar");

Donut donut1 = defaultFactory.CreateDonut();
Console.WriteLine($"Donut 1: {donut1.Filling} with {donut1.Glaze}");

Donut donut2 = defaultFactory.CreateDonut();
Console.WriteLine($"Donut 2: {donut2.Filling} with {donut2.Glaze}");


DonutFactory randomFactory = new RandomDonutFactory(
	["chocolate", "vanilla", "strawberry"],
	["sugar", "glaze", "chocolate"]
);

for (int i = 0; i < 10; i++) {
	Donut donut = randomFactory.CreateDonut();
	Console.WriteLine($"Donut {i + 1}: {donut.Filling} with {donut.Glaze}");
}
