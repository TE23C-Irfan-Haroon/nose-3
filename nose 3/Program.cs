// static void Hello32()
// {
//    for (int i = 0; i < 32; i++)
//    {
//       Console.WriteLine("Hello, World");
//    }
// }

// Hello32();

// static void Square(int n)
// {
//    Console.WriteLine(n * n);
// }

// Square(4);


// static float Multi(float n, float y)
// {
//    return n * y;
// }

// float r = Multi(5,3);

// Console.WriteLine(r);


// Console.ReadLine();

// static float RightTriangleArea(float x, float y)
// {
//    return x * y / 2;
// }

// float r = RightTriangleArea(5,6);
// Console.WriteLine(r);

// Console.ReadLine();

// static float RightCircleArea(float x)
// {
//    return x * x * MathF.PI;
// }

// float r = RightCircleArea(5);
// Console.WriteLine(r);

// Console.ReadLine();

// static int GetNumberInput() 
// {
//    bool isNumber = false;
//    int num2 = 0;
//    while (isNumber == false)
//    {

//       Console.WriteLine("write a number");
//       string num = Console.ReadLine();
//       isNumber = int.TryParse(num, out num2);

//    }
//    return num2;
// }


// GetNumberInput();

// Console.ReadLine();


// static int GetChoice(string choice1, string choice2, string choice3)
// {
//    string answer = "0";

//    while (answer != "1" && answer != "2" && answer != "3")
//    {
//       Console.WriteLine("Choose between option 1-3.");
//       Console.WriteLine($"1.{choice1} 2.{choice2} 3.{choice3}");
//       answer = Console.ReadLine();
//       if (answer == "1")
//       {
//         return 1;
//       }
//       if (answer == "2")
//       {
//          return 2;
//       }
//       if (answer == "3")
//       {
//          return 3;
//       }
//       else
//       {
//          continue;
//       }
//    }
//    return 0;
// }


// int c = GetChoice("Choklad", "Vanilj", "Jordgubbe");

// Console.WriteLine($"Du valde {c} !!!");

// Console.ReadLine();
