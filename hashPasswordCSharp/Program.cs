// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

 
string sha256()
{


    Console.WriteLine("Enter the password");
    string password = Console.ReadLine();
    var sha = SHA256.Create();
    var asByteArray = Encoding.Default.GetBytes(password);
    var hashedPassword = sha.ComputeHash(asByteArray);

    var text = Convert.ToBase64String(hashedPassword);
    return text;

}
string SHA512m()
{


    Console.WriteLine("Enter the password");
    string password = Console.ReadLine();
    var sha = SHA512.Create();
    var asByteArray = Encoding.Default.GetBytes(password);
    var hashedPassword = sha.ComputeHash(asByteArray);

    var text = Convert.ToBase64String(hashedPassword);
    return text;

}
string SHA384m()
{


    Console.WriteLine("Enter the password");
    string password = Console.ReadLine();
    var sha = SHA384.Create();
    var asByteArray = Encoding.Default.GetBytes(password);
    var hashedPassword = sha.ComputeHash(asByteArray);

    var text = Convert.ToBase64String(hashedPassword);
    return text;

}
Console.WriteLine("Choose the type of Hash \n 1.sha256 \n 2.SHA512 \n 3. SHA384");
int choose = Int32.Parse(Console.ReadLine());
switch (choose)
{
    case 1:
        Console.WriteLine(sha256());
        break;
    case 2:
        Console.WriteLine(SHA512m());
        break;
    case 3:
        Console.WriteLine(SHA384m());
        break;
    default:
        Console.WriteLine("You choose is wrong");
        break;
}