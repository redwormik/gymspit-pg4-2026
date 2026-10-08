// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism

using Lecture6MethodPolymorphism;


static void TryFeed(Animal animal, string food)
{
	if (animal.DoesEat(food)) {
		Console.WriteLine($"Successfully fed {food} to {animal.ToString()}.");
	} else {
		Console.WriteLine($"{animal.ToString()} DOES NOT EAT {food}!");
	}
}

Dog dog = new();
Giraffe giraffe = new();
Cow cow = new();

Animal[] animals = [
	dog,
	giraffe,
	cow,
	// new Animal(),
	// new Omnivore(),
];


Console.WriteLine(dog.DoSound());
Console.WriteLine(giraffe.DoSound());
Console.WriteLine(cow.DoSound());

foreach (Animal animal in animals) {
	Console.WriteLine(animal.DoSound());
}

Console.WriteLine();


Console.WriteLine($"dog.DoesEat(\"meat\") = {dog.DoesEat("meat")}");
Console.WriteLine($"dog.DoesEat(\"high meat\") = {dog.DoesEat("high meat")}");
Console.WriteLine($"dog.DoesEat(\"grass\") = {dog.DoesEat("grass")}");
Console.WriteLine($"giraffe.DoesEat(\"meat\") = {giraffe.DoesEat("meat")}");
Console.WriteLine($"giraffe.DoesEat(\"high meat\") = {giraffe.DoesEat("high meat")}");
Console.WriteLine($"giraffe.DoesEat(\"grass\") = {giraffe.DoesEat("grass")}");
Console.WriteLine($"cow.DoesEat(\"meat\") = {cow.DoesEat("meat")}");
Console.WriteLine($"cow.DoesEat(\"high meat\") = {cow.DoesEat("high meat")}");
Console.WriteLine($"cow.DoesEat(\"grass\") = {cow.DoesEat("grass")}");

TryFeed(dog, "meat");
TryFeed(dog, "high meat");
TryFeed(dog, "grass");
TryFeed(giraffe, "meat");
TryFeed(giraffe, "high meat");
TryFeed(giraffe, "grass");
TryFeed(cow, "meat");
TryFeed(cow, "high meat");
TryFeed(cow, "grass");

Console.WriteLine();


Console.WriteLine("dog.GetStomachCount() = {0}", dog.GetStomachCount());
Console.WriteLine("giraffe.GetStomachCount() = {0}", giraffe.GetStomachCount());

foreach (Animal animal in animals) {
	if (animal is Omnivore omnivore) {
		Console.WriteLine("omnivore == animal = {0}", omnivore == animal);
		Console.WriteLine(
			"omnivore({1}).GetStomachCount() = {0}",
			// animal.GetStomachCount(),
			omnivore.GetStomachCount(),
			omnivore.ToString()
		);
	}
}