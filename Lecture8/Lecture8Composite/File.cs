namespace Lecture8Composite;


abstract class File(string name)
{
	public string Name { get; } = name;


	abstract public void PrintOn(TextWriter writer, int indent = 0);


	protected string FormatName(int indent)
	{
		return $"{new string(' ', indent * 3)}{(indent > 0 ? " - " : "")}{Name}";
	}
}
