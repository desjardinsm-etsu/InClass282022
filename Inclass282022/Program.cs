// See https://aka.ms/new-console-template for more information
using Inclass282022;

var parent = new Parent("Mathew", "Desjardins") ;
var parent2 = new Parent("Mathew", "Desjardins") ;

var child = new Child("Addison", "Desjardins");
var child2 = new Child("Ali", "Desjardins");

var list = new List<Person> { child, parent, parent2 };


foreach (var item in list)
{
    Console.WriteLine(item.FullName);
}

Console.WriteLine(child.Equals(child2));



parent.AddVehicle(2005);
parent.AddVehicle(DateTime.Now);

child.AddVehicle(DateTime.Now);

var listOfParentsAndChild = new List<Parent>();

listOfParentsAndChild.Add(parent);

listOfParentsAndChild.Add(child);

foreach (var item in listOfParentsAndChild)
{
    Console.WriteLine();
}


var veh = new Vehicle(2005);

veh.AddFeature("Power Windows");
veh.AddFeature("backup Camera");
veh.AddFeature("DVD Player");

Console.WriteLine(veh[0]);

foreach (var item in veh)
{
    Console.WriteLine(item);
}
