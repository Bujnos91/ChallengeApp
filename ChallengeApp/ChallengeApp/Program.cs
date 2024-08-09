using System.ComponentModel.Design;

int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
    if (letter == '0')
    { counter0 = counter0 + 1; }
    else if (letter == '1')
    { counter0++; }
    else if (letter == '1')
    { counter1++; }
    else if (letter == '2')
    { counter2++; }
    else if (letter == '3')
    { counter3++; }
    else if (letter == '4')
    { counter4++; }
    else if (letter == '5')
    { counter5++; }
    else if (letter == '6')
    { counter6++; }
    else if (letter == '7')
    { counter7++; }
    else if (letter == '8')
    { counter8++; }
    else if (letter == '9')
    { counter9++; }

Console.WriteLine(number);
Console.WriteLine("liczba cyfr 0:" + counter0);
Console.WriteLine("liczba cyfr 1:" + counter1);
Console.WriteLine("liczba cyfr 2:" + counter2);
Console.WriteLine("liczba cyfr 3:" + counter3);
Console.WriteLine("liczba cyfr 4:" + counter4);
Console.WriteLine("liczba cyfr 5:" + counter5);
Console.WriteLine("liczba cyfr 6:" + counter6);
Console.WriteLine("liczba cyfr 7:" + counter7);
Console.WriteLine("liczba cyfr 8:" + counter8);
Console.WriteLine("liczba cyfr 9:" + counter9);


