using apiSobreTasaGasolina.Model;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using apiSobreTasaGasolina.Entities;
using SelectPdf;
using System.Drawing;

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

        [HttpGet ("ciudades")]
        public ActionResult GetCiudades()
        {
            try
            {
                List<Ciudad> ciudades = db.Query<Ciudad>("select c.idCiudad, c.nombreCiudad,c.idDepartamento, d.nombreDepartamento from tbl_Ciudad c inner join tbl_Departamento d on c.idDepartamento = d.idDepartamento").ToList();
                return Ok(ciudades);
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
        public ActionResult GuardarFormulario(Formulario formulario)
        {
            try
            {
                List<Contribuyente> contribuyentes = db.Query<Contribuyente>($"select * from tbl_Contribuyente where documento={formulario.Contribuyente.documento}").ToList();
                if (contribuyentes.Count == 0)
                {
                    db.Query("insert into tbl_Contribuyente (documento,nombre,direccion,municipio,telefono,celular,tipoContribuyente,tipoDocumento)" +
                        $"values ({formulario.Contribuyente.documento},'{formulario.Contribuyente.nombre}','{formulario.Contribuyente.direccion}',{formulario.Contribuyente.municipio}," +
                        $"'{formulario.Contribuyente.telefono}','{formulario.Contribuyente.celular}',{formulario.Contribuyente.tipoContribuyente},{formulario.Contribuyente.tipoDocumento})");
                }
                        
            }
            catch (Exception ex)
            {

            return BadRequest(ex.Message);

            }

            try
            {
                var resultado = db.Query("guardarFormulario ",formulario.DetalleDeclaracion,commandType:CommandType.StoredProcedure).FirstOrDefault();

                return Ok(resultado);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

                
        }
        
        [HttpPost("Preview")]
        public ActionResult PreviewPdf(ConsultaPreview consulta)
        {
            try
            {
                Formulario formulario = new Formulario();
                formulario.Contribuyente = db.Query<Contribuyente>($"select * from tbl_Contribuyente where documento={consulta.contribuyente}").FirstOrDefault();
                formulario.DetalleDeclaracion = db.Query<SobreTasaGasolina>($"select * from tbl_SobreTasaGasolina where idGasolina = {consulta.IdDeclaracion}").FirstOrDefault();
                formulario.DatosReemplazar = consulta.datos;
                PDF pdf = new PDF();
                string body = pdf.llenarPDF(formulario);
                var converter = new HtmlToImage();
                converter.WebPageWidth = 600;
                Image img = converter.ConvertHtmlString(body, "");
                byte[] imgBytes = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
                 //string[] partes = body.Split("td");
                return Ok(imgBytes);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
               
        }

        [HttpPost("Declarar")]
        public ActionResult Declarar(ConsultaPDF consulta)
        {
            try
            {
                Formulario formulario = new Formulario();
                formulario.Contribuyente = db.Query<Contribuyente>($"select * from tbl_Contribuyente where documento={consulta.Contribuyente}").FirstOrDefault();
                formulario.DetalleDeclaracion = db.Query<SobreTasaGasolina>($"select * from tbl_SobreTasaGasolina where idGasolina = {consulta.IdDeclaracion}").FirstOrDefault();
                formulario.DatosReemplazar = consulta.DatosReemplazar;
                PDF pdf = new PDF();
                string body = pdf.llenarPDF(formulario);
                
                string total = "", fecha = "", factura = "", EAN = "7709999999999", doc = "", FechaDeclarado = "";
                Declaracion declaracion = new Declaracion();
                declaracion.idDeclaracion = consulta.IdDeclaracion;
                declaracion.contribuyente = consulta.Contribuyente;
                declaracion.fecha = consulta.fecha;
                
                //declaracion.CodeBar = codeBar;
                declaracion.valorPagar = formulario.DetalleDeclaracion.totalPagarCargo;
                declaracion.tipo = consulta.Tipo;
                declaracion.idMunicipio = consulta.municipio;


                total = declaracion.valorPagar.ToString();
                fecha = declaracion.fecha.ToString();
                factura = declaracion.idDeclaracion.ToString();
                doc = declaracion.contribuyente.ToString();

                body = body.Replace("{Code}",pdf.CodigoBarras(total, Convert.ToDateTime(fecha).ToString("yyyyMMdd"), factura + doc, EAN));
                byte[] pdfBytes = pdf.crearPDF(body);
                declaracion.PDF = pdfBytes;
                Console.WriteLine(body);
  
                db.Query("Declarar", declaracion, commandType: CommandType.StoredProcedure).FirstOrDefault();

                return Ok(pdfBytes);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        
    }
}