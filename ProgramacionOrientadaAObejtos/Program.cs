
using ProgramacionOrientadaAObejtos.Business;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;

Energetica redbull = new Energetica("redbull", true, "naranja", 5.2m, 250);

Bebida sprite = new Bebida("sprite", false, 4.2m, 500);
Jugo sprim = new Jugo(250);

Console.WriteLine(sprite.Descripcion());
Console.WriteLine(redbull.Descripcion());
Console.WriteLine(sprim.getMl());
Vender(sprite);

ISaleble[] concept =
{
    sprite,
    redbull
};
decimal total = 0;
foreach (var item in concept)
{
    total += item.GetPrice();
    
}
Console.WriteLine($"precio toal {total}");
void Vender(ISaleble some)
{
    Console.WriteLine($"Vendiendo {sprite.Descripcion()} por {some.GetPrice()}");
}


