namespace Lecture7AbstractFactory;


class OldMacDonald
{
	public void Sing(Farm farm, TextWriter writer)
	{
		SingFirstVerse(farm.CreateDuck(), writer);
		SingSecondVerse(farm.CreatePig(), writer);
		SingThirdVerse(farm.CreateCow(), writer);
		writer.WriteLine();
	}


	private void SingFirstVerse(Duck duck, TextWriter writer)
	{
		SignRefrain(writer);
		writer.WriteLine("On that farm, he had a {0}.", duck.Name);

		writer.Write("With a ");
		duck.Quack(writer);
		writer.Write("-");
		duck.Quack(writer);
		writer.Write(" here and a ");
		duck.Quack(writer);
		writer.Write("-");
		duck.Quack(writer);
		writer.WriteLine(" there,");

		duck.Quack(writer);
		writer.Write("-");
		duck.Quack(writer);
		writer.Write(", ");
		duck.Quack(writer);
		writer.Write("-");
		duck.Quack(writer);
		writer.WriteLine(" everywhere!");
		writer.WriteLine();
	}


	private void SingSecondVerse(Pig pig, TextWriter writer)
	{
		SignRefrain(writer);
		writer.WriteLine("On that farm, he had a {0}.", pig.Name);

		writer.Write("With a ");
		pig.Oink(writer);
		writer.Write("-");
		pig.Oink(writer);
		writer.Write(" here and a ");
		pig.Oink(writer);
		writer.Write("-");
		pig.Oink(writer);
		writer.WriteLine(" there,");

		pig.Oink(writer);
		writer.Write("-");
		pig.Oink(writer);
		writer.Write(", ");
		pig.Oink(writer);
		writer.Write("-");
		pig.Oink(writer);
		writer.WriteLine(" everywhere!");
		writer.WriteLine();
	}


	private void SingThirdVerse(Cow cow, TextWriter writer)
	{
		SignRefrain(writer);
		writer.WriteLine("On that farm, he had a {0}.", cow.Name);

		writer.Write("With a ");
		cow.Moo(writer);
		writer.Write("-");
		cow.Moo(writer);
		writer.Write(" here and a ");
		cow.Moo(writer);
		writer.Write("-");
		cow.Moo(writer);
		writer.WriteLine(" there,");

		cow.Moo(writer);
		writer.Write("-");
		cow.Moo(writer);
		writer.Write(", ");
		cow.Moo(writer);
		writer.Write("-");
		cow.Moo(writer);
		writer.WriteLine(" everywhere!");
		writer.WriteLine();
	}


	private void SignRefrain(TextWriter writer)
	{
		writer.WriteLine("Old MacDonald hard a farm, E-I-E-I-O!");
	}
}
