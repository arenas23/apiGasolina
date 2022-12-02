namespace apiSobreTasaGasolina.Model
{
    public class SobreTasaGasolina
    {
        public string documentoContadorRevisor { get; set; }
        public string FechaMaximun { get; set; }
        public float galonesGasoCorriente { get; set; }
        public float galonesGasoCorriOxigenada { get; set; }
        public float galonesGasoExtra { get; set; }
        public float galonesGasoExtraOxi { get; set; }
        public float galonesGasoImportada { get; set; }
        public float galonesGasoZFBasica { get; set; }
        public float galonesGasoZFOxi { get; set; }
        public float baseGasoCorriente { get; set; }
        public float baseGasoCorriOxigenada { get; set; }
        public float baseGasoExtra { get; set; }
        public float baseGasoExtraOxi { get; set; }
        public float baseGasoImportada { get; set; }
        public float baseGasoZFBasica { get; set; }
        public float baseGasoZFOxi { get; set; }
        public float gasoCorrienteCarbu { get; set; }
        public float gasoCorriOxigenadaCarbu { get; set; }
        public float gasoExtraCarbu { get; set; }
        public float gasoExtraOxiCarbu { get; set; }
        public float gasoImportadaCarbu { get; set; }
        public float gasoZFBasicaCarbu { get; set; }
        public float gasoZFOxiCarbu { get; set; }
        public float tarifaGasoCorriente { get; set; }
        public float tarifaGasoCorriOxigenada { get; set; }
        public float tarifaGasoExtra { get; set; }
        public float tarifaGasoExtraOxi { get; set; }
        public float tarifaGasoImportada { get; set; }
        public float tarifaGasoZFBasica { get; set; }
        public float tarifaGasoZFOxi { get; set; }
        public long sobretasaGasoCorriente { get; set; }
        public long sobretasaGasoCorriOxigenada { get; set; }
        public long sobretasaGasoExtra { get; set; }
        public long sobretasaGasoExtraOxi { get; set; }
        public long sobretasaGasoImportada { get; set; }
        public long sobretasaGasoZFBasica { get; set; }
        public long sobretasaGasoZFOxi { get; set; }
        public long totalSobreTasa { get; set; }
        public long totalSaldoCargo { get; set; }
        public long totalPagarCargo { get; set; }
        public int sanciones { get; set; }
        public string mesDeclarar { get; set; }
        public string ano { get; set; }
        public int compensacion { get; set; }
        public string nombreContador { get; set; }
        public string documentoContador {get;set;}
        public string cargo { get; set; }
        public string tarjetaProfesional { get; set; }
        public string nombreDeclarante { get; set; }
        public string documentoDeclarante { get; set; }
        public long idFormulario { get; set; }
        public string fechaCorreccion { get; set; }
        public long radicadoCorreccion { get; set; }
        public int interesMora { get; set; }

    }
}
