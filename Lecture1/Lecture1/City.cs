namespace Lecture1
{
	public class City(string name)
	{
		public string Name { get; private set; } = name;
		private readonly List<Highway> highways = [];

		public IEnumerable<Highway> Highways {
			get {
				foreach (var highway in highways) {
					yield return highway;
				}
			}
		}


		public void AddHighway(City otherCity, int length)
		{
			var highway = new Highway(this, otherCity, length);
			highways.Add(highway);

			if (otherCity != this) {
				otherCity.highways.Add(highway);
			}
		}
	}
}
