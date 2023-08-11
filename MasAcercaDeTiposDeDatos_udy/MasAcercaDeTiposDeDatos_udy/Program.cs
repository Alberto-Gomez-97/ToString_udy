//ToString a string o hacia string

var cant = 5; //int
//para invocar una funcionalidad requieren parentesis
if (cant.ToString() == "5") //convertido a string
{
    Console.WriteLine("Son iguales");
}
else
{
    Console.WriteLine("No son iguales");
}

var esCierto = true;
esCierto.ToString();
// ToString "" se puede escoger el tipo de fomato
var hoy = DateTime.Today.ToString("yyyy-MM-dd (dddd)");
Console.WriteLine(hoy);
