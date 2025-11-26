


//CaseStudy1();

//CaseStudy2();


//CaseStudy3();

<<<<<<< HEAD
CaseStudy4();

void CaseStudy4()
{
    Func<int, bool> fnptr = IsEvenNumber;
    Console.Write("Enter a number");
    int no = int.Parse(Console.ReadLine());
    bool result1 = fnptr(no);

    if (result1 == true)
    {
        Console.WriteLine("Result is even as your number is this:" +no);

    }
    else
    {
        Console.WriteLine("Result is odd as your number is this:" + no);
    }

        Predicate<int> pdptr;
    pdptr = IsEvenNumber;
    bool result2 = pdptr.Invoke(1);

    Console.WriteLine("result:" + result2);
 }


bool IsEvenNumber(int number)
{
    if (number % 2 == 0)
    return true;

    return false;
=======
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
>>>>>>> 0d837b618eb29003473c676dcf889b64af7a74f2
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