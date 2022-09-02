namespace apiSobreTasaGasolina.Model
{
    public class Formulario
    {
        public long idDeclaracion { get; set; }
        public int idMunicipio { get; set; }
        public Contribuyente Contribuyente { get; set; }
        public long valorPagar { get; set; }
        public SobreTasaGasolina DetalleDeclaracion { get; set; }

    }
}
