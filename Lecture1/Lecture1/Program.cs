using Lecture1;

static void PrintHighways(City city)
{
	Console.WriteLine($"Highways from {city.Name}:");
	foreach (var highway in city.Highways) {
		var otherCity = highway.OtherEnd(city);
		Console.WriteLine($"- To {otherCity.Name}, Length: {highway.Length} km");
	}
}


City praha = new City("Praha");
City brno = new City("Brno");
City bratislava = new City("Bratislava");

praha.AddHighway(brno, 200);
brno.AddHighway(bratislava, 130);

PrintHighways(praha);
PrintHighways(brno);
PrintHighways(bratislava);
