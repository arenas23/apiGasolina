namespace apiSobreTasaGasolina.Model
{
    public class SobreTasaGasolina
    {
        public int galonesGasoCorriente { get; set; }
        public int galonesGasoCorriOxigenada { get; set; }
        public int galonesGasoExtra { get; set; }
        public int galonesGasoExtraOxi { get; set; }
        public int galonesGasoImportada { get; set; }
        public int galonesGasoZFBasica { get; set; }
        public int galonesGasoZFOxi { get; set; }
        public int baseGasoCorriente { get; set; }
        public int baseGasoCorriOxigenada { get; set; }
        public int baseGasoExtra { get; set; }
        public int baseGasoExtraOxi { get; set; }
        public int baseGasoImportada { get; set; }
        public int baseGasoZFBasica { get; set; }
        public int baseGasoZFOxi { get; set; }
        public int gasoCorrienteCarbu { get; set; }
        public int gasoCorriOxigenadaCarbu { get; set; }
        public int gasoExtraCarbu { get; set; }
        public int gasoExtraOxiCarbu { get; set; }
        public int gasoImportadaCarbu { get; set; }
        public int gasoZFBasicaCarbu { get; set; }
        public int gasoZFOxiCarbu { get; set; }
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
    }
}
