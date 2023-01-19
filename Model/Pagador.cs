namespace apiSobreTasaGasolina.Model
{
    public class Pagador
    {
        public long Referencia { get; set; }
        public long Factura { get; set;}
        public long Total { get; set;}
        public string CodigoEntidad { get; set; }
        public int TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
