int number = 4566;
string numberAsString = number.ToString();
char[] Letters = numberAsString.ToArray();

int Counter0 = 0;
int Counter1 = 0;
int Counter2 = 0;
int Counter3 = 0;
int Counter4 = 0;
int Counter5 = 0;
int Counter6 = 0;
int Counter7 = 0;
int Counter8 = 0;
int Counter9 = 0;
foreach (var v in Letters)
{
    Console.WriteLine(v);
}
