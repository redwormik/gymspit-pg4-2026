namespace Lecture8Composite;


class RegularFile(string name) : File(name)
{
	public override void PrintOn(TextWriter writer, int indent = 0)
	{
		writer.WriteLine(FormatName(indent));
	}
}
