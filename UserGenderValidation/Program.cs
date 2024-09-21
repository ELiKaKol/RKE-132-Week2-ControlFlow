// See https://aka.ms/new-console-template for more information
//rakendus  küsib kasutajal valida tema sugu (m/f)
//rakendus  küsib kasutajal sisedtada tema perekonnanime
//lähtudes kasutaja valikust, rakendustervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]/"Welcome, Ms. [kasutaja perekonnanimi]"

using System.ComponentModel.Design;

Console.WriteLine("Please, select your gendel (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) fornaadis
Console.WriteLine("Please, enter your lastname");
string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, {userLastName} !");
}
else
{
    Console.WriteLine($"Welcome, {userLastName} !");
}
