namespace Lecture8Composite;


class Directory(string name, File[] files) : File(name)
{
	public File[] Files { get; } = files;


	public override void PrintOn(TextWriter writer, int indent = 0)
	{
		writer.WriteLine($"{FormatName(indent)}:");

		foreach (File file in Files) {
			file.PrintOn(writer, indent + 1);
		}
	}
}
