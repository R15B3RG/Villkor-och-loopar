//int age = 37;
//string name = "Andreas";

//if (name == "Andreas")
//{
//    Console.WriteLine("Hej " + name);
//}

//else if (age > 35)
//{
//    Console.WriteLine("oof");
//}

//else
//{
//    Console.WriteLine("Vem är du");
//}

//int counter = 0;

//while (name == "Andreas")
//{
//    counter = counter + 1;
//    Console.WriteLine(counter);
//    if (counter >= 10)

//    {
//        break;
//    }
//    Console.WriteLine("LOL");

//}
//Console.WriteLine("---------------------------------------------------------");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    if (name != "Andreas")
//    {
//        break;
//    }
//    Console.WriteLine("LOL");
//}

int[] goodNumbers;
goodNumbers = new int[10];

for (int i = goodNumbers.Length - 1; i >= 0; i--)
{
    goodNumbers[i] = 10 - i;
}

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);

}

Console.WriteLine("-----------------------------");

Array.Sort(goodNumbers);

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);

}

//foreach (int number in goodNumbers)
//{

//    Console.WriteLine(number);
//}

//int index = 0;

//while (index < goodNumbers.Length)

//{

//    index++;
//}

//string name = "Andreas";

//name = name + "!";

//Console.WriteLine(name.Length);

//Console.WriteLine(name[2]);

//for (int i = 0; i < name.Length; i++)

//{
//    Console.WriteLine(name[i]);
//}

