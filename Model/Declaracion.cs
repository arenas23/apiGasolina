namespace apiSobreTasaGasolina.Model
{
    public class Declaracion
    {
        public long idDeclaracion { get; set; }
        public long contribuyente { get; set; }
        public DateTime fecha { get; set; }
        public byte[] PDF { get; set; }
        public long valorPagar { get; set; }
        public int tipo { get; set; }
        public int idMunicipio { get; set; }
    }
}
