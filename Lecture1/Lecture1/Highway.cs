namespace Lecture1
{
	public class Highway(City from, City to, int length)
	{
		public City From { get; private set; } = from;
		public City To { get; private set; } = to;
		public int Length { get; private set; } = length;


		public City OtherEnd(City city)
		{
			if (city == From) {
				return To;
			} else if (city == To) {
				return From;
			} else {
				throw new ArgumentException("The specified city is not connected by this highway.");
			}
		}
	}
}
