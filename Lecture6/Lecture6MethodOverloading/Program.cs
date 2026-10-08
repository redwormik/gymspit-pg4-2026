// https://learn.microsoft.com/en-us/dotnet/csharp/methods

using Lecture6MethodOverloading;

Console.WriteLine($"Length() = {Utils.Length()}");
Console.WriteLine($"Length(0) = {Utils.Length(0)}");
Console.WriteLine($"Length(1) = {Utils.Length(1)}");
Console.WriteLine($"Length(-1) = {Utils.Length(-1)}");
Console.WriteLine($"Length(5) = {Utils.Length(5)}");
Console.WriteLine($"Length(-5) = {Utils.Length(-5)}");
Console.WriteLine($"Length(10) = {Utils.Length(10)}");
Console.WriteLine($"Length(-10) = {Utils.Length(-10)}");
Console.WriteLine($"Length(50) = {Utils.Length(50)}");
Console.WriteLine($"Length(-50) = {Utils.Length(-50)}");
Console.WriteLine($"Length(10000) = {Utils.Length(10000)}");
Console.WriteLine($"Length(-10000) = {Utils.Length(-10000)}");
Console.WriteLine($"Length(\"50000\") = {Utils.Length("50000")}");
Console.WriteLine($"Length(\"-50000\") = {Utils.Length("-50000")}");
Console.WriteLine($"Length(\"ahoj\") = {Utils.Length("ahoj")}");
Console.WriteLine($"Length(\"Length\") = {Utils.Length("Length")}");
// Console.WriteLine($"Length(true) = {Utils.Length(true)}");

string str = "quick brown fox jumps over the lazy dog";
Console.WriteLine($"Length(\"{str}\") = {Utils.Length(str)}");
Console.WriteLine($"Length(\"{str}\", false) = {Utils.Length(str, false)}");
Console.WriteLine($"Length(\"{str}\", true) = {Utils.Length(str, true)}");

Console.WriteLine($"Length([4, 42, 24]) = {Utils.Length([4, 42, 24])}");

Console.WriteLine($"Length(new Parent()) = {Utils.Length(new Parent())}");
Console.WriteLine($"Length(new Child()) = {Utils.Length(new Child())}");

Parent[] list = [new Parent(), new Child()];
foreach (Parent obj in list) {
	Console.WriteLine($"Length(obj) = {Utils.Length(obj)}");
	Console.WriteLine($"LengthVirtual(obj) = {Utils.LengthVirtual(obj)}");
}
