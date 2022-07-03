//using ConsoleAppTestDeligates;

//MyArray myArray = new MyArray(8, 45, 6, 76);
//myArray.Print();

//myArray.Sort((a, b) => b > a);

//myArray.Print();


//using ConsoleAppTestDeligates;

//ProcDelegate procDelegate = null;

//ProcDelegate procDelegate = () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine("hello world");
//    }
//};

//if (procDelegate != null)
//{
//    procDelegate.Invoke();
//}

//procDelegate?.Invoke();

//procDelegate();


//Action procDelegate = () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine("hello world");
//    }
//};

//procDelegate();

//Action<int, int> procDelegate2 = (x, y) =>
//{
//    Console.WriteLine($"sum = {x + y}");
//};

//procDelegate2(4, 6);

//Func<int, int, int> func1 = (x, y) => x + y;

//int a = func1(10, 5);

//List<int> numbers = new List<int> { 34, 234, 3, 4657, 23, 78, 23, 12, 86, 90, 45 };

//numbers.Sort((a, b) =>
//{
//    if (a > b) { return 1; }
//    else if (a < b) { return -1; }
//    else { return 0; }
//});


//numbers.ForEach(item => Console.Write(item + " "));
//Console.WriteLine();

//List<int> filteredNumbers = numbers.Where(item => item % 2 == 0).ToList();
//filteredNumbers.ForEach(item => Console.Write(item + " "));
//Console.WriteLine();

//int firstValue = numbers.Find(item => item > 6000);
//Console.WriteLine(firstValue);

//int firstIndex = numbers.FindIndex(item => item > 6000);
//Console.WriteLine(firstIndex);

//int firstValue2 = numbers.FirstOrDefault(item => item > 6000);
//Console.WriteLine(firstValue2);

using ConsoleAppTestDeligates;

var people = new List<Person>
{
    new Person ("Tom", 23),
    new Person ("Bob", 27),
    new Person ("Sam", 29),
    new Person ("Alice", 24)
};

var names = people.Select(item => item.Name).ToList();

var filteredPeople = people.Where(item => item.Age > 25).ToList();

names.ForEach(item => Console.WriteLine(item));

filteredPeople.ForEach(item => Console.WriteLine(item));