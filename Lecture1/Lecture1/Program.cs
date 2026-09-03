using Lecture1;

static void PrintHighways(City city)
{
	Console.WriteLine($"Highways from {city.Name}:");
	foreach (var highway in city.Highways) {
		var otherCity = highway.OtherEnd(city);
		Console.WriteLine($"- To {otherCity.Name}, Length: {highway.Length} km");
	}
}


static bool Neighbors(City city, City destination)
{
	foreach (var highway in city.Highways) {
		if (highway.OtherEnd(city) == destination) {
			return true;
		}
	}

	return false;
}


static bool Connected(City city, City destination)
{
	var visited = new HashSet<City>();
	var queue = new Queue<City>();
	queue.Enqueue(city);
	visited.Add(city);

	while (queue.Count > 0) {
		var currentCity = queue.Dequeue();
		if (currentCity == destination) {
			return true;
		}

		foreach (var highway in currentCity.Highways) {
			var neighbor = highway.OtherEnd(currentCity);
			if (!visited.Contains(neighbor)) {
				visited.Add(neighbor);
				queue.Enqueue(neighbor);
			}
		}
	}

	return false;
}


static int? ShortestPath(City city, City destination, out IList<City> path)
{
	ISet<City> visited = new HashSet<City>();
	path = [city];
	return ShortestPathRecursion(city, destination, visited, ref path);
}


static int? ShortestPathRecursion(City city, City destination, ISet<City> visited, ref IList<City> path)
{
	if (city == destination) {
		return 0;
	}

	visited.Add(city);

	int? shortestLength = null;
	IList<City> shortestPath = [];
	foreach (var highway in city.Highways) {
		var neighbor = highway.OtherEnd(city);
		if (visited.Contains(neighbor)) {
			continue;
		}

		IList<City> currentPath = [.. path, neighbor];
		int? length = ShortestPathRecursion(neighbor, destination, visited, ref currentPath);

		if (length.HasValue) {
			length += highway.Length;
			if (!shortestLength.HasValue || length < shortestLength) {
				shortestLength = length;
				shortestPath = currentPath;
			}
		}
	}

	path = shortestPath;
	return shortestLength;
}


static void PrintPath(City city, City destination)
{
	IList<City> path;
	int? length = ShortestPath(city, destination, out path);

	if (length.HasValue) {
		Console.WriteLine($"Shortest path from {city.Name} to {destination.Name}:");
		foreach (var c in path) {
			Console.WriteLine($"\t{c.Name}");
		}

		Console.WriteLine($"Total length: {length.Value} km");
	} else {
		Console.WriteLine($"No path found from {city.Name} to {destination.Name}");
	}
}


City praha = new City("Praha");
City plzen = new City("Plzeň");
City liberec = new City("Liberec");
City brno = new City("Brno");
City bratislava = new City("Bratislava");

City newYork = new City("New York");
City newJersey = new City("New Jersey");
City lasVegas = new City("Las Vegas");
City losAngeles = new City("Los Angeles");
City sanFrancisco = new City("San Francisco");

City anchorage = new City("Anchorage");

praha.AddHighway(praha, 50);
praha.AddHighway(brno, 200);
praha.AddHighway(plzen, 100);
praha.AddHighway(liberec, 100);
plzen.AddHighway(liberec, 150);
brno.AddHighway(bratislava, 130);

newYork.AddHighway(newJersey, 150);
newYork.AddHighway(lasVegas, 1500);
lasVegas.AddHighway(losAngeles, 500);
lasVegas.AddHighway(sanFrancisco, 1000);
losAngeles.AddHighway(sanFrancisco, 150);

anchorage.AddHighway(anchorage, 10);

PrintHighways(praha);
PrintHighways(plzen);
PrintHighways(liberec);
PrintHighways(brno);
PrintHighways(bratislava);
PrintHighways(anchorage);

Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, praha.Name, Neighbors(praha, praha));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, brno.Name, Neighbors(praha, brno));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, plzen.Name, Neighbors(praha, plzen));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, liberec.Name, Neighbors(praha, liberec));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, bratislava.Name, Neighbors(praha, bratislava));

Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, newYork.Name, Neighbors(praha, newYork));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, newJersey.Name, Neighbors(praha, newJersey));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, lasVegas.Name, Neighbors(praha, lasVegas));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, losAngeles.Name, Neighbors(praha, losAngeles));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, sanFrancisco.Name, Neighbors(praha, sanFrancisco));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, anchorage.Name, Neighbors(praha, anchorage));

Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, praha.Name, Connected(praha, praha));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, brno.Name, Connected(praha, brno));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, plzen.Name, Connected(praha, plzen));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, liberec.Name, Connected(praha, liberec));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, bratislava.Name, Connected(praha, bratislava));

Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, newYork.Name, Connected(praha, newYork));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, newJersey.Name, Connected(praha, newJersey));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, lasVegas.Name, Connected(praha, lasVegas));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, losAngeles.Name, Connected(praha, losAngeles));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, sanFrancisco.Name, Connected(praha, sanFrancisco));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, anchorage.Name, Connected(praha, anchorage));

Console.WriteLine("Connected({0}, {1}) = {2}", anchorage.Name, anchorage.Name, Connected(anchorage, anchorage));
Console.WriteLine("Connected({0}, {1}) = {2}", anchorage.Name, praha.Name, Connected(anchorage, praha));

PrintPath(praha, praha);
PrintPath(praha, brno);
PrintPath(praha, plzen);
PrintPath(praha, liberec);
PrintPath(praha, bratislava);

PrintPath(praha, newYork);
PrintPath(praha, newJersey);
PrintPath(praha, lasVegas);
PrintPath(praha, losAngeles);
PrintPath(praha, sanFrancisco);
PrintPath(praha, anchorage);

PrintPath(plzen, liberec);

PrintPath(anchorage, anchorage);
PrintPath(anchorage, praha);
