

using csharpbases;
using csharpbases.Helpers;
using csharpbases.Models;
using System.Collections.Generic;


funkione_me_array_dhe_lista instanca = new funkione_me_array_dhe_lista();

Console.WriteLine("Ju lutem jepni nje array me int :");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// Kemi mbushur arrayn me elemente 
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Jepnieleintin ne pozicionin i" + i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int shuma = instanca.GjejShumenEArray(array);
int meIMadhi = instanca.GjejMeTeMadhin(array);
int shumaCift = instanca.GjejShumeNrCift(array);

Console.WriteLine("Shuma :" + shuma);
Console.WriteLine("Me i Madhi :" + meIMadhi);
Console.WriteLine("Gjej Shumen nr Cift " + shumaCift);


List<int> ListeMeInteger = new List<int>() { 10, 32, 43, -3, 4, 413, -11, -41 };
List<string> ListeMeString = new List<string>() { "test", "abc", "developer" };

FuksioneMeLista instancefuksioneMeLista = new FuksioneMeLista();

instancefuksioneMeLista.GjejMeTeMadhinNeListe(ListeMeInteger);
instancefuksioneMeLista.GjejShumenCiftNeListe(ListeMeInteger);
instancefuksioneMeLista.GjejShumenEListes(ListeMeInteger);

instancefuksioneMeLista.GjejNumrinElementevePozitiv(ListeMeInteger);

Console.WriteLine("Nr me i madh:" + instancefuksioneMeLista.GjejMeTeMadhinNeListe(ListeMeInteger));
Console.WriteLine("Shuma e Nr Cift : " + instancefuksioneMeLista.GjejShumenCiftNeListe(ListeMeInteger));
Console.WriteLine("Shuma e Listes " + instancefuksioneMeLista.GjejShumenEListes(ListeMeInteger));
Console.WriteLine("Elementet Pozitiv te listes :" + instancefuksioneMeLista.GjejNumrinElementevePozitiv(ListeMeInteger));

List<int> elementetTek = instancefuksioneMeLista.KtheElementetTek(ListeMeInteger);
foreach( int el in elementetTek)
{
    Console.WriteLine(el);
}
List<string> fjaletUppercase= instancefuksioneMeLista.KonvertToUpperCase(ListeMeString);

foreach(string el in fjaletUppercase)
{
    Console.WriteLine(el);
}
Person p= new Person();
p.Name = "Anisa ";
p.Age = 10;
p.Surname = " Maksutaj";
p.Address = "Tirana";
p.Phone = 0695452153;

int a=p.Age;
Console.WriteLine(p.Age);
Console.WriteLine(p.Name);
Console.WriteLine(p.Surname);
Console.WriteLine(p.Address);   
Console.WriteLine(p.Phone);

PersonalHelper helperMethods= new PersonalHelper();

Person p1= new Person();
p1.Age = 20;
p1.Name = "John";
p1.Surname = "Doeb";


PersonalHelper helperMethods = new PersonalHelper();

List<Person> ListOfPersons= new List<Person>();
ListOfPersons.Add(p1);
ListOfPersons.Add(p);


helperMethods.KthePersoninMeMoshenMeTeMAdhe(ListOfPersons);
double mosha = helperMethods.GjejMoshenMesatare(ListOfPersons);
helperMethods.RenditPersonatSipasMoshes(ListOfPersons);


