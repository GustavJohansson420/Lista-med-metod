using System;
using System.Collections.Generic;

class Program {

static int Minsta(List<int> listan) {
    int minsta = listan[0];
    foreach (int element in listan)
    if (element < minsta)
    minsta = element;

return minsta;
}

static int Största(List<int> listan) {
    int största = listan[0];
    foreach (int element in listan)
    if (element > största)
    största = element;
return största;
}

static void SkrivUt(List<int> listan) {
foreach (int element in listan)
Console.WriteLine(element);
}

public static void Main (string[] args) {
List<int> minLista = new List<int>();
minLista.Add(11); minLista.Add(5);
minLista.Add(12); minLista.Add(3);
minLista.Add(6); minLista.Add(3);


SkrivUt(minLista);

Console.WriteLine("Största tal: "+Största(minLista));
Console.WriteLine("Minsta tal: "+Minsta(minLista));

}
}