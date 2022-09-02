using apiSobreTasaGasolina.Model;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using apiSobreTasaGasolina.Entities;


 

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
                List<Ciudad> ciudades = db.Query<Ciudad>("select * from tbl_Ciudad").ToList();
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
            public ActionResult PreviewPdf(Formulario formulario)
            {
                try
                {
                    PDF pdf = new PDF();
                    string body = pdf.llenarPDF(formulario);

                HtmlToImage converter = new HtmlToImage();
                //converter.WebPageWidth = 600;
                //Image img = converter.ConvertHtmlString(body, "");
                //    byte[] imgBytes = (byte[])(new ImageConverter()).ConvertTo(body, typeof(byte[]));
                //string[] partes = body.Split("td");
                    return Ok();
                }
                catch (Exception ex)
                {

                    return Problem(ex.Message);
                }
               
            }
        
    }
}