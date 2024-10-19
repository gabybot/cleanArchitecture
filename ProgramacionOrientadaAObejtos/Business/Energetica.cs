

namespace ProgramacionOrientadaAObejtos.Business
{
    public class Energetica : Bebida
    {
        public string Sabor { get; set; }
        public Energetica(string nombre, bool cafeina,string sabor, decimal precio, int quanity)
            : base(nombre, cafeina, precio, quanity)
        {
            Sabor = sabor;


        }
        public override string Descripcion()
        {
            return $"{Nombre} - c/cafeina: {_cafeina} - $ {Precio} - {Sabor} - {Quantity} ml";
        }
    }
}
