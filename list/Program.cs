// See https://aka.ms/new-console-template for more information

//List<int> numbers = new() { 1, 2, 3, 4, 5 };
//foreach(var num in numbers)
//{
//    Console.WriteLine(num);
//}


//List<string> fruits = new()
//{
//    "Apple",
//    "Banana",
//    "Cherry"
//};

//foreach(var fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}


//List<double> temperatures = new()
//{
//    78.88,
//    44.56,
//    23.45
//};
//foreach (var temp in temperatures)
//{
//    Console.WriteLine(temp);
//}


//List<char> name = new()
//{
//    'U', 'M', 'E', 'R'
//};
//foreach (var ltr in name)
//{
//    Console.Write(ltr);
//}


//List<int> numbers = new()
//{
//    10, 20, 30, 40
//};

//numbers.Add(50);
//numbers.AddRange(new List<int> { 50, 60, 70 });
//numbers.Insert(2, 25);
//numbers.Remove(30);
//numbers.RemoveAll(a => a > 30);
//numbers.RemoveAt(1);
//numbers.Clear();
//Console.WriteLine(numbers.Contains(50));
//Console.WriteLine(numbers.Count);

//foreach (var num in numbers)
//{
//    Console.WriteLine(num);
//}



// *****************************************
// *****************************************
//    List + Loop + Condition Practice  
// *****************************************
// *****************************************

// 1. Find the Maximum Number in a List 
//List<int> numbers = new() { 10, 25, 5, 70, 45, 90, 15 };
////int max = numbers[0];
//foreach(var num in numbers)
//{
//    if(num > max)
//    {
//        max = num;
//    }
//}
//Console.WriteLine("maximum number is : " + max);

// 2. Remove All Even Numbers
//List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
//numbers.RemoveAll(n => n % 2 == 0);
//foreach (var num in numbers)
//{
//    Console.WriteLine(num);
//}
