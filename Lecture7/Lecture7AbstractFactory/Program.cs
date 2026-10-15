// https://en.wikipedia.org/wiki/Abstract_factory_pattern
// https://refactoring.guru/design-patterns/abstract-factory

using Lecture7AbstractFactory;


OldMacDonald oldMacDonald = new();

oldMacDonald.Sing(new EnglishFarm(), Console.Out);
oldMacDonald.Sing(new CzechFarm(), Console.Out);
oldMacDonald.Sing(new GermanFarm(), Console.Out);
oldMacDonald.Sing(new AnimalFarm(), Console.Out);