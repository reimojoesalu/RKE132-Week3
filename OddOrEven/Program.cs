

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int resualt = userNum & 2;

Console.WriteLine(resualt);
if (resualt != 0) //!= - eiole
{
    Console.WriteLine("User number is odd.");
} else
{
    Console.WriteLine("User number is even.");
}
