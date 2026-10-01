static string ReadLine(string prompt)
{
	Console.Write($"{prompt}: ");
	return Console.ReadLine() ?? "";
}


static string ReadWord()
{
	return ReadLine("Enter a word to translate");
}


static string ReadTranslation(string word)
{
	return ReadLine($"Enter a translation of \"{word}\"");
}


static string ReadQuery()
{
	return ReadLine("Enter a word to find");
}


IDictionary<string, string> ReadDictionary()
{
	Dictionary<string, string> dictionary = [];

	string word = ReadWord();
	while (word != "")
	{
		string translation = ReadTranslation(word);
		dictionary[word] = translation;
		word = ReadWord();
	}

	return dictionary;
}


void QueryDictionary(IDictionary<string, string> dictionary)
{
	string query = ReadQuery();
	while (query != "") {
		if (dictionary.TryGetValue(query, out string? translation)) {
			Console.WriteLine($"Translation of \"{query}\" is \"{translation}\".");
		} else {
			Console.WriteLine($"Translation of \"{query}\" not found.");
			
			string newTranslation = ReadTranslation(query);
			if (newTranslation != "") {
				dictionary[query] = newTranslation;
			}
		}

		query = ReadQuery();
	}
}


IDictionary<string, string> dictionary = ReadDictionary();
QueryDictionary(dictionary);
