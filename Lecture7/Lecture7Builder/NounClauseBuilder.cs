namespace Lecture7Builder;


class NounClauseBuilder(string noun)
{
	private readonly string noun = noun;

	private string size = "";

	private readonly IList<string> colors = [];


	public NounClauseBuilder SetSize(string size)
	{
		this.size = size;
		return this;
	}


	public NounClauseBuilder AddColor(string color)
	{
		colors.Add(color);
		return this;
	}


	public string GetNounClause()
	{
		IList<string> parts = [];

		if (size != "") {
			parts.Add(size);
		}

		string colorPart = GetColorPart();
		if (colorPart != "") {
			parts.Add(colorPart);
		}

		parts.Add(noun);
		return string.Join(" ", [.. parts]);
	}


	private string GetColorPart()
	{
		if (colors.Count == 0) {
			return "";
		}

		if (colors.Count == 1) {
			return colors.First();
		}

		IList<string> allButLast = [.. colors];
		allButLast.RemoveAt(allButLast.Count - 1);
		return string.Format("{0} and {1}", string.Join(", ", allButLast), colors.Last());
	}
}
