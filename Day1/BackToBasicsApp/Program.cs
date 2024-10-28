//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int num1;
//char myChar1 = 'a';
//string myName = "3";
////num1 =myChar1;
//num1 = Convert.ToInt32(myName);//unboxing - ref type to value type
//num1 = int.Parse(myName);//unboxing - ref type to value type
//Console.WriteLine(++num1);
//Console.WriteLine("------------------");
//myName = null;
//num1 = Convert.ToInt32(myName);
//Console.WriteLine("New value of num "+num1);
//Console.WriteLine("------------Parse");
//myName = null;
//num1 = int.Parse(myName);
//Console.WriteLine("New value of num " + num1);
//best practice
//int num1;
//Console.WriteLine("Please enter a number");
//string strNum1 =Console.ReadLine();
//bool parseResult = int.TryParse(strNum1, out num1);
//if (parseResult)
//{
//    num1++;
//    Console.WriteLine("The incremented value is " + num1);
//}
//else
//{
//    Console.WriteLine("Unable to parse");
//}

//int num1;
//Console.WriteLine("Please enter a number");
//string strNum1 ;
//while (int.TryParse(Console.ReadLine(), out num1) == false)
//{
//    Console.WriteLine("Invalid entry for whole number. Please try again");
//}
//num1++;
//Console.WriteLine("The incremented value is " + num1);
//int num1 = int.MaxValue;
//Console.WriteLine(num1);
//checked
//{
//    num1+=10;
//    Console.WriteLine("After increment " + num1);
//}
//float num1 = float.MaxValue;
//Console.WriteLine(num1);
//if (num1 <= float.MaxValue)
//{
//    num1 += float.MaxValue;
//    Console.WriteLine("After increment " + num1);
//}
//else
//    Console.WriteLine("Already full");
//float num1 = 10.3f;
//float num2 = 10.378f;
//Console.WriteLine(MathF.Max(num1,num2));

Console.WriteLine("Float min and max");
Console.WriteLine(float.MinValue);
Console.WriteLine(float.MaxValue);
Console.WriteLine("Decimal min and max");
Console.WriteLine(decimal.MinValue);
Console.WriteLine(decimal.MaxValue);
decimal num1 = decimal.MaxValue;
num1++;
Console.WriteLine(num1);






