string bracketsString = "((())())";
int nestingDepth = 0;
int validation = 0;
int maxNestingDepth = 0;
int checkValidation = 0;

for (int i = 0; i < bracketsString.Length; i++)
{
    if (bracketsString[i] == '(')
    {
        validation++;
        nestingDepth++;

        if (maxNestingDepth < nestingDepth)
        {
            maxNestingDepth = nestingDepth;
        }
    }
    else if (bracketsString[i] == ')')
    {
        validation--;
        nestingDepth--;
    }
}

Console.WriteLine(bracketsString);

if (validation == checkValidation)
{
    Console.WriteLine("Данная строка символов является корректным скобочным выражением, а так же её максимальная глубина равна " + maxNestingDepth);
}
else if (validation > checkValidation)
{
    Console.WriteLine("Данная строка символов является некорректным скобочным выражением");
}
