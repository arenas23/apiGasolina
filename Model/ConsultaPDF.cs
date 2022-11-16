namespace apiSobreTasaGasolina.Model
{
    public class ConsultaPDF
    {
        public long IdDeclaracion { get; set; }
        public long Contribuyente { get; set; }
        public DataReplaceX DatosReemplazar { get; set; }
        public DateTime fecha { get; set; }
        public int Tipo { get; set; }
        public int municipio { get; set; }
    }
}
