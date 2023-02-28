

List<string> firstNames = new List<string>();


firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");

Console.WriteLine(firstNames[firstNames.Count - 1]);

// List<T> - generic

string data = " Corey,Smith,Jones";
List<string> lastNames = data.Split(',').ToList();

Console.WriteLine(lastNames[lastNames.Count - 1]);