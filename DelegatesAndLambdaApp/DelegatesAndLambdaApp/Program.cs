

//CaseStudy1();

//CaseStudy2();

CaseStudy3();

void CaseStudy3()
{
    Action<string, int>  printDetails=(name, nTimes) => {

        for (int iterations = 1; iterations <= nTimes; iterations++)
        {
            Console.WriteLine(name.ToUpper());
        }
    };

    printDetails("Lamda", 10);

}

void CaseStudy2()
{
    Func<double> randomNumberGenerator= ()=> {

        Random random = new Random();

        return random.NextDouble();
    };

    Console.WriteLine(randomNumberGenerator());


}

void CaseStudy1()
{

    Func<int, int, double> muliply= (input1,input2) => {

        return input1*input2;
    };

    Console.WriteLine(muliply(10,20));
}