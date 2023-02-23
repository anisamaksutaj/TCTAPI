

using csharpbases;
using csharpbases.Helpers;
using csharpbases.Models;
using System.Data.Common;

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

List<Person> ListOfPersons= new List<Person>();




PersonHelper.KthePersoninMeMoshenMeTeMAdhe(ListOfPersons);
PersonHelper.GjejMoshenMesatare(ListOfPersons);
PersonHelper .RenditPersonatSipasMoshes(ListOfPersons);



Animal A=new Animal(5,"Cat", "Mjau","Ground");
Animal B = new Animal();

Teacher t = new Teacher("Matematike", 25, "Anisa", "Maksutaj","Tirane",695452153);

Dog d =new Dog(true, 5, "Tobi", "hamham", "Ground");
Cat c = new Cat("Nine", 2, "Piti", " Mjau", "Ground");

FuksioneMeLista.ListOfMultiples(3, 24); 
