


//CaseStudy1();

//CaseStudy2();


//CaseStudy3();



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