
namespace agencia_viagem.Models
{
    public class Destino
    {
        public Destino(int cod, string destinos, string embarque, DateOnly data, int hora)
        {
            Cod = cod;
            Destinos = destinos;
            Embarque = embarque;
            Data = data;
            Hora = hora;
        }

        public int Cod { get; set; }
        public string Destinos { get; set; }

        public string Embarque { get; set; }
        public DateOnly Data { get; set; }

        public int Hora { get; set; }
    }
}
