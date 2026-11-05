using Lecture9Iterator;

IList<int> list = [1, 2, 3];
foreach (int num in list) {
	Console.WriteLine(num);
}

IEnumerator<int> enumerator = list.GetEnumerator();
while (enumerator.MoveNext()) {
	int item = enumerator.Current;
	Console.WriteLine(item.ToString());
}

MyList<int> myList = new();
myList.InsertFirst(1);
myList.InsertFirst(2);
myList.InsertFirst(3);

Console.WriteLine("Iterating over myList using foreach:");
foreach (int num in myList) {
	Console.WriteLine($"in foreach: {num}");
}

Console.WriteLine("Iterating over myList using enumerator:");
IEnumerator<int> myEnumerator = myList.GetEnumerator();
while (myEnumerator.MoveNext()) {
	int item = myEnumerator.Current;
	Console.WriteLine(item.ToString());
}

var 
