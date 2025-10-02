// => - Operador Lambda

// a)

string[] Lista1 = { "C#", "Aprender C#","ASP.NET MVC com C#",
     "Entity Framework","Bootstrap","Identity",
     "Lambda","Delegates","Linq","POO com C# "
     };

// Query syntax
var ordenados_ = from x in Lista1 orderby x select x;

// Extension Methods
var _ordenados = Lista1.Where(x => x.Contains("C#")).OrderBy(s => s);

foreach (string x in ordenados_) Console.Write($" {x} "); Console.Write($"\n");
foreach (string x in _ordenados) Console.Write($" {x} "); Console.Write($"\n");

Console.ReadKey();

// b)

// var, o pau para toda a obra
var _solucao = from x in Lista1 where x.Length < 6 select x; // Query Syntax

var solucao_ = Lista1.Where(x => x.Length < 6); // Extension Methods
                                                // Aqui podemos usar mais do que um operador

foreach (string x in _solucao) Console.Write($" {x} "); Console.Write("\n");
foreach (string x in solucao_) Console.Write($" {x} "); Console.Write("\n");

// c)

var _resultado = (from x in Lista1 where x.Contains("C#") select x).Count(); // Query Syntax

var resultado_ = Lista1.Count(x => x.Contains("C#"));

Console.Write($" {resultado_} "); Console.Write($"\n");
Console.Write($" {_resultado} "); Console.Write($"\n");

// d)

// O que é o operador trim? É para cortar coisas.
// Por exemplo, um cliente coloca uma password que tem um espaço no inicio ou no fim e não se apercebe, é "indiferente".
// Quando tenta fazer login, não vai dar. O trim remove esses espaços (no inicio e no fim).

// Query Syntax
var _resultado2 = from x in Lista1 select x.Trim().Split(' ').Count();

// Extension Methods
var resultado2_ = Lista1.Select(x => x.Trim().Split(' ').Count());

foreach (int x in _resultado2) Console.Write($" {x} "); Console.Write("\n");
foreach (int x in resultado2_) Console.Write($" {x} "); Console.Write("\n");

// e)

int[] Numeros = { 10, 23, 54, 77, 85, 12, 1, 4, 53 };

// Query Syntax
var _solucao2 = (from x in Numeros select x).Average();

// Extension Methods
var solucao2_ = Numeros.Average();

Console.Write($" {_solucao2.ToString("F2")} "); Console.Write("\n");
Console.Write($" {solucao2_.ToString("F2")} "); Console.Write("\n");

//string[] ListaDois = { "C#", "ASP.NET MVC", "Linq", "Lambda e C#" };