
namespace ProgramacionOrientadaAObejtos.Business
{
    public class Bebida : Drink , ISaleble
    {

        protected bool _cafeina;
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    //Metodo constructor
    public Bebida(string nombre, bool cafeina, decimal precio, int quantity)
        : base(quantity)

    {
        Nombre = nombre;
        _cafeina = cafeina;

        Precio = precio;
    }

    //Metodo de la case
    public virtual string Descripcion()
    {
        return $"{Nombre} - c/cafeina: {_cafeina} - $ {Precio} - {Quantity} ml";
    }
    public decimal GetPrice()
    
        => Precio;

    }
}
