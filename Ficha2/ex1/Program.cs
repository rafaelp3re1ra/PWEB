// var é uma variável inferida, não é genérica. A aplicação vai inferir o tipo de dados correto e tá feito.

var ListA = new List<string>();

foreach (var x in ListaStrings) if (x.Contains("C#")) ListA.Add(x);

var ListB = from s in ListaStrings where s.Contains("C#") select s;

var ListC = ListaStrings.Where(l => l.Contains("C#"));