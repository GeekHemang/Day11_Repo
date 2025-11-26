using AccountPublisherLIb.Domain;

var acc1 = new Account(101, "Krishna");


acc1.OnBalanceChanged += SendSms;
acc1.OnBalanceChanged += SendEmail;

acc1.Deposit(1000);
acc1.Withdraw(0);



void SendSms(double latestBalance) {

    Console.WriteLine("sending sms");
    Console.WriteLine("balanced changed for "+latestBalance);

}

void SendEmail(double latestBalance)
{

    Console.WriteLine("sending email");
    Console.WriteLine("balanced changed for " + latestBalance);

}
