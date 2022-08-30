using apiSobreTasaGasolina.Model;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace apiSobreTasaGasolina.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GasolinaController : ControllerBase
    {
        private readonly IDbConnection db;

        public GasolinaController()
        {

            db = new SqlConnection(ConectionString.connection);

        }

        [HttpGet("municipios")]
        public ActionResult  GetMunicipios()
        {
            try
            {
                List<Municipio> municipios = db.Query<Municipio>("select * from tbl_Municipio").ToList();
                return Ok(municipios);
            }
            catch (Exception e)
            {

                return NotFound(e.Message);
            }
        }

        [HttpGet("municipios/{codigo}")]
        public ActionResult GetMunicipio(string codigo)
        {
            try
            {
                List<Municipio> municipios = db.Query<Municipio>($"select * from tbl_Municipio where codigoMunicipio='{codigo}'").ToList();
                return Ok(municipios);
            }
            catch (Exception e)
            {

                return NotFound(e.Message);
            }
        }

        [HttpGet ("departamentos")]
        public ActionResult GetDepartamentos()
        {
            try
            {
                List<Departamento> departamentos = db.Query<Departamento>("select * from tbl_Departamento").ToList();
                return Ok(departamentos);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

        [HttpPost("GuardarContribuyente")]
        public ActionResult GuardarContribuyente(Contribuyente contribuyente)
        {
            try
            {
                List<Contribuyente> contribuyentes = db.Query<Contribuyente>($"select * from tbl_Contribuyente where documento={contribuyente.documento}").ToList();
                if (contribuyentes.Count == 0)
                {
                    db.Query("insert into tbl_Contribuyente (documento,nombre,direccion,municipio,telefono,celular,tipoContribuyente,tipoDocumento)" +
                        $"values ({contribuyente.documento},'{contribuyente.nombre}','{contribuyente.direccion}',{contribuyente.municipio}," +
                        $"'{contribuyente.telefono}','{contribuyente.celular}',{contribuyente.tipoContribuyente},{contribuyente.tipoDocumento})");
                }
                else
                {
                    return Ok("ya existe");
                }
                return Ok("200");
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }

            [HttpPost ("GuardarFormulario")]
            public ActionResult GuardarFormulario(SobreTasaGasolina formulario)
            {
                try
                {
                    db.Query($"insert into tbl_SobreTasaGasolina (galonesGasoCorriente,galonesGasoCorriOxigenada,galonesGasoExtra,galonesGasoExtraOxi,"
                        + $"galonesGasoImportada,galonesGasoZFBasica,galonesGasoZFOxi,baseGasoCorriente,baseGasoCorriOxigenada,baseGasoExtra,baseGasoExtraOxi'"
                        + $"baseGasoImportada,baseGasoZFBasica,baseGasoZFOxi,gasoCorrienteCarbu,gasoCorriOxigenadaCarbu,gasoExtraCarbu,gasoExtraOxiCarbu,"
                        + $"gasoImportadaCarbu,gasoZFBasicaCarbu,gasoZFOxiCarbu,tarifaGasoCorriente,tarifaGasoCorriOxigenada,tarifaGasoExtra,tarifaGasoExtraOxi,"
                        + $"tarifaGasoImportada,tarifaGasoZFBasica,tarifaGasoZFOxi,sobretasaGasoCorriente,sobretasaGasoCorriOxigenada,sobretasaGasoExtra,"
                        + $"sobretasaGasoExtraOxi,sobretasaGasoImportada,sobretasaGasoZFBasica,sobretasaGasoZFOxi,totalSobreTasa,totalSaldoCargo,sanciones,"
                        + $"mesDeclarar,ano,compensacion VALUES ('{formulario.galonesGasoCorriente}','{formulario.galonesGasoCorriOxigenada}',"
                        + $"'{formulario.galonesGasoExtra}','{formulario.galonesGasoExtraOxi}','{formulario.galonesGasoImportada}','{formulario.galonesGasoZFBasica}',"
                        + $"'{formulario.galonesGasoZFOxi}','{formulario.baseGasoCorriente}','{formulario.baseGasoCorriOxigenada}','{formulario.baseGasoExtra}',"
                        + $"'{formulario.baseGasoExtraOxi}','{formulario.baseGasoImportada}','{formulario.baseGasoZFBasica}','{formulario.baseGasoZFOxi}',"
                        + $"'{formulario.gasoCorrienteCarbu}','{formulario.gasoCorriOxigenadaCarbu}','{formulario.gasoExtraCarbu}','{formulario.gasoExtraOxiCarbu}',"
                        + $"'{formulario.gasoImportadaCarbu}','{formulario.gasoZFBasicaCarbu}','{formulario.gasoZFOxiCarbu}','{formulario.tarifaGasoCorriente}',"
                        + $"'{formulario.tarifaGasoCorriOxigenada}','{formulario.tarifaGasoExtra}','{formulario.tarifaGasoExtraOxi}','{formulario.tarifaGasoImportada}',"
                        + $"'{formulario.tarifaGasoZFBasica}','{formulario.tarifaGasoZFOxi}','{formulario.sobretasaGasoCorriente}','{formulario.sobretasaGasoCorriOxigenada}',"
                        + $"'{formulario.sobretasaGasoExtra}','{formulario.sobretasaGasoExtraOxi}','{formulario.sobretasaGasoImportada}',"
                        + $"'{formulario.sobretasaGasoZFBasica}','{formulario.sobretasaGasoZFOxi}','{formulario.totalSobreTasa}','{formulario.totalSaldoCargo}',"
                        + $"'{formulario.sanciones}','{formulario.mesDeclarar}','{formulario.ano}','{formulario.compensacion}',)");

                    return Ok("se guardo el formulario");
                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }

                
            }
        
    }
}