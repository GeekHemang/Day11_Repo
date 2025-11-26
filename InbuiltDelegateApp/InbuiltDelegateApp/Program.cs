


//CaseStudy1();

//CaseStudy2();


//CaseStudy3();

//CaseStudy4();

CaseStudy5();

void CaseStudy5()
{
    Func<int,bool> functPtr = IsEvenNumber;

    if (functPtr(3))
    {
        Console.WriteLine("is even via func");
    }
    else
        Console.WriteLine("is odd via func");
}

void CaseStudy4()
{
    Predicate<int> predicatePtr = IsEvenNumber;

    if (predicatePtr(3)) {
        Console.WriteLine("is even");
    }else
        Console.WriteLine("is odd");
}

void CaseStudy3()
{
    Action<string, int> actionPtr = PrintDetails;
    actionPtr("emerson", 5);
}

void CaseStudy2()
{
    Func<double> fntptr;
    fntptr = GetRandomNo;
    Console.WriteLine(fntptr());


}

bool IsEvenNumber(int input) { 

     if(input % 2 ==0)
        return true;
     else return false;
}

double GetRandomNo()
{
    Random random = new Random();

    return random.NextDouble();
}


void PrintDetails(string name, int nTimes)
{
    for (int iterations = 1; iterations <= nTimes; iterations++)
    {
        Console.WriteLine(name.ToUpper());
    }
}

void CaseStudy1()
{

    Func<int, int, double> fntPtr;//expects a functions which returns double and two integers
    fntPtr = Multiply;
    double result = fntPtr(10, 5);
    Console.WriteLine(result);


}

double Multiply(int first, int second)
{
    return first * second;
}