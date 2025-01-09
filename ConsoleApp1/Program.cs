namespace A5;

#region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
// enum WeekDays
// {
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Saturday,
//     Sunday,
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         for (int i = 0; i < 7; i++)
//             Console.WriteLine((WeekDays)i);
//     }
// }
#endregion

#region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

// struct Person
// {
//     public string Name;
//     public int Age;
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Person[] p = new Person[3];
//
//         p[0] = new Person { Name = "ahmed", Age = 31 };
//         p[1] = new Person { Name = "marwan", Age = 21 };
//         p[2] = new Person { Name = "moaz", Age = 24 };
//
//         Console.WriteLine("Person's details : ");
//         foreach (Person p1 in p)
//             Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");
//     }
// }
#endregion

#region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

// enum Season
// {
//     Spring, Summer, Autumn, Winter
// }
//
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         string szn;
//         bool sznFlag;
//
//         do
//         {
//             Console.WriteLine("Enter a season : ");
//             szn = Console.ReadLine().ToLower();
//             sznFlag = string.IsNullOrWhiteSpace(szn);
//         } while (sznFlag || (szn != "spring" && szn != "summer" && szn != "autumn" && szn != "winter"));
//
//         Season sznValue = Enum.Parse<Season>(szn, true);
//
//         if (sznValue == Season.Spring)
//             Console.WriteLine("march to may");
//         else if (sznValue == Season.Summer)
//             Console.WriteLine("june to august");
//         else if (sznValue == Season.Autumn)
//             Console.WriteLine("spetember to november");
//         else
//             Console.WriteLine("December to february");
//     }
// }

#endregion

#region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

// enum Color
// {
//     Red, Green, Blue, Yellow
// }
//
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         
//         string color;
//         bool colorFlag;
//
//          do
//          {
//              Console.WriteLine("Enter a color : ");
//              color = Console.ReadLine().ToLower();
//              colorFlag = string.IsNullOrWhiteSpace(color);
//          } while (colorFlag || (color != "red" && color != "yellow" && color != "green" && color != "blue"));
//
//          Color c = Enum.Parse<Color>(color, true);
//          
//          if(c == Color.Red || c == Color.Yellow || c == Color.Blue)
//              Console.WriteLine("primary");
//          else
//              Console.WriteLine("secondary");
//     }
// }

#endregion