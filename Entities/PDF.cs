using apiSobreTasaGasolina.Model;
using SelectPdf;
using System.Drawing.Drawing2D;
using System.Drawing;
using BarcodeLib.Barcode;

namespace apiSobreTasaGasolina.Entities
{
    public class PDF
    {

        public string Code = "{Code}";
        public string style = 
        " <style>"+

            "@page{" +
            "size: A4;" +
            "}" +

            ".bordes{" +
                "z-index: 10;" +
                "border: 1px solid black;" +
                "border-collapse: collapse;"+
            "}" +

            ".tamano{" +
                "width: 100%;" +
            "}" +
            ".pagina" +
            "{" +
              @"font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;
              font-size: 26px;
              margin: auto;
              width: 2000px;" +
            "}" +

            ".lados" +
            "{" +
                "display: flex;" +
                "flex-flow: row wrap;" +
            "}" +

            "td" +
            "{" +
                "padding: 6px;" +
            "}" +

        "</style> ";

        public string llenarPDF(Formulario formulario)
        {
            string body = $@"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
                <meta charset=""UTF-8"">
                <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                <title>Document</title>
                {style}
   
            </head>

            <body>

                <div class=""pagina"">
                    <div class=""lados"">
                        <table width=""100%"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" 
                            style=""border-collapse: collapse;border-color: rgba(0,0,0,0.3);font-size: 30px;font-family: Arial, Verdana, sans-serif; margin-top: 100px;"">
                            <tbody>
                              <tr>
                                <td align=""left"" style=""padding: 5px 10px;border: 0px solid #000000;"">
                                  <img style=""width:150px; height:110px;""
                                    src='file:///C:/inetpub/wwwroot/Autoliquidable/HtmlToPdf/8909842656/images/logo1.png' />
                                  <!-- style=""width:128px;height:128px; -->
                                </td>
                                <td align=""center"" style=""padding: 5px 10px;border: 0px solid #000000;"">
                                  <span><b>MUNICIPIO DE YONDO ANTIOQUIA</b></span>
                                  <br>
                                  <span style=""font-size: 26px;""><b>NIT. 890.984.265-6</b></span>
                                  <br>
                                  <span style=""font-size: 26px;""><b>SECRETARIA HACIENDA MUNICIPAL</b></span>
                                  <br>
                                  <!-- <span style=""font-size: 25px;""><b>DECLARACION Y LIQUIDACION PRIVADA ANUAL</b></span>
                                      <br> -->
                                  <span style=""font-size: 24px;"">FORMULARIO MUNICIPAL DECLARACION DE LA SOBRETASA A LA GASOLINA MOTOR </span>
                                </td>
                                <td colspan=""3"" align=""right"" style=""padding: 5px 10px;border: 0px solid #000000;"">
                                  <img style=""width:180px; height:100px;""
                                    src='file:///C:/inetpub/wwwroot/Autoliquidable/HtmlToPdf/8909842656/images/logo2.png' />
                                </td>
                              </tr>
                            </tbody>
                          </table>



                         <table width=""100%"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0""
                                style=""border-collapse: collapse;border-color: rgba(0,0,0,0.3);font-size: 30px;font-family: Arial, Verdana, sans-serif;"">
                                <tbody>
                                  <td colspan=""5"" align=""center""
                                    style=""background: #CDCDCD;padding: 5px 10px;border: 1px solid #000000;font-size: 20px;font-weight: 600;"">
                                    <span id=""MensajeAcuerdoMunicipal""></span>
                                  </td>
                                  <tr>
                                    <td align=""left"" style=""padding: 5px 10px;border: 1px solid #000000; font-size: 22px"">
                                      <strong>MUNICIPIO
                                    <td colspan=""3"" align=""left"" style=""width: 1044px; padding: 5px 10px;border: 1px solid #000000;  font-size: 22px"">YONDO
                                    </td>
                                    <td  rowspan=""3"" align=""left"" style=""border: 1px solid #000000; width: 340px;"">
                                      <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"" style=""padding: 5px 10px; "">
                                        <tbody>
                                          <tr>
                                            <td align=""center"" style=""font-size: 22px""><strong>Fecha máxima presentación</strong></td>
                                          </tr>
                                          <tr>
                                            <td align=""center""></td>
                                          </tr>
                                          <tr>
                                            <td align=""center"" height=""30px"" style=""font-size: 20px"">{formulario.DetalleDeclaracion.FechaMaximun}</td>
                                          </tr>
                                        </tbody>
                                      </table>
                                    </td>
                                  </tr>
                                  <tr>
                                    <td  align=""left"" style=""padding: 5px 10px;border: 1px solid #000000; font-size: 22px"">
                                      <strong>DEPARTAMENTO:</strong>
                                    </td>
                                    <td colspan=""3"" align=""left"" style=""padding: 5px 10px;border: 1px solid #000000; font-size: 20px"">
                                      ANTIOQUIA</td>
                                  </tr>
                                  <tr style=""border: 1px solid #000000;"">
                                    <td align=""left"" style=""padding: 5px 10px;border: 1px solid #000000; font-size: 22px"">
                                      <strong>AÑO GRAVABLE:</strong>
                                    </td>
                                    <td  align=""left"" style=""padding: 5px 10px; border-right: 0px solid #000000;font-size: 20px"">
                                      {formulario.DetalleDeclaracion.ano}</td>
                                    <td colspan=""2"" align=""left"" style=""padding: 5px 10px;border: 0px solid #000000;"">
                                      <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                        <tbody>

                                        </tbody>
                                      </table>
                                    </td>

                                  </tr>
                                </body>
                            </table>




                        <div style=""width: 40%; margin-top: 40px;"" >
                            <table>
                                <tr>
                                    <td colspan=""8""><span><strong>SECCION B: CALIDAD DEL DECLARANTE</strong></span></td>
                                </tr>
                                <tr>
                                    <td colspan=""8"">
                                        <table class=""bordes"">
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td style=""margin-top: 1px solid; border-bottom: 1px solid;"">&nbsp;</td>
                                                <td></td>
                                                <td></td>
                                                <td style=""border-bottom: 1px solid;""></td>
                                                <td><span></span></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <td style=""width: 30px;""></td>
                                                <td><span>MAYORISTA</span></td>
                                                <td style=""width: 30px;""><span>&nbsp;</span></td>
                                                <td style=""width: 30px;"" class=""bordes""><span>{formulario.DatosReemplazar.mayorista}</span></td>
                                                <td><span>IMPORTADOR</span></td>
                                                <td style=""width: 30px;""></td>
                                                <td style=""width: 30px;"" class=""bordes""><span>{formulario.DatosReemplazar.importador}</span></td>
                                                <td style=""width: 5px;""></td>
                                                <td><span>&nbsp;</span></td>
                                            </tr>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                            <tr>
                                                <td style=""width: 30px;""></td>
                                                <td><span>PRODUCTOR</span></td>
                                                <td style=""width: 30px;""><span>&nbsp;</span></td>
                                                <td style=""width: 30px;"" class=""bordes""><span>{formulario.DatosReemplazar.productor}</span></td>
                                                <td><span>OTRO</span></td>
                                                <td style=""width: 30px;""></td>
                                                <td style=""width: 30px;"" class=""bordes""><span>{formulario.DatosReemplazar.otro}</span></td>
                                                <td style=""width: 30px;""></td>
                                                <td><span></span></td>
                         
                                            </tr>
                                            <tr>
                                                <td colspan=""9"">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div style=""width: 60%; margin-top: 40px;"">
                            <table class=""tamano"">
                                <tr>
                                    <td><span><strong>SECCION C: INFORMACION DE LA DECLARACION QUE SE CORRIGE</strong></span></td>
                                </tr>
                                <tr>
                                    <td>
                                        <table class=""bordes tamano"">
                                            <tr>
                                                <td colspan=""11"">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style=""width: 30px;""></td>
                                                <td style=""width: 500px;""><span>NUMERO DE DECLARACION</span></td>
                                                <td style=""width: 60px;text-align: center;"" colspan=""""><span></span></td>
                                                <td style=""width: 60px;text-align: center;"" colspan=""""><span>FECHA</span></td>
                                                <td style=""width: 60px;text-align: center;"" colspan=""""><span></span></td>
                                                <td style=""width: 30px; border-right: 1px solid #000000;""></td>
                                            </tr>
                    
                                            <tr>
                                                <td><span></span></td>
                                                <td  class=""bordes""><span>{formulario.DetalleDeclaracion.radicadoCorreccion}</span></td>
                                                <td colspan=""3"" class=""bordes""><span>&nbsp;{formulario.DetalleDeclaracion.fechaCorreccion}</span></td>
                                   
                                                <td style=""border-right: 1px solid #000000;""><span></span></td>
                                            </tr>
                                            <tr>
                                                <td colspan=""11"">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>
            
                    </div>

                    <div style=""margin-top: 40px;"">
                        <table class=""tamano"">
                            <tr>
                                <td><span><strong>SECCION D: PERIODO GRAVABLE</strong></span></td>
                            </tr>
                            <tr>
                                <td>
                                    <table class=""bordes tamano"" style=""border: 1px solid black;"">
                                        <tr>
                                            <td colspan=""34""><span></span></td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                            <td><span>ENE</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td><span>FEB</span></td>
                                            <td><span></span></td>
                                            <td><span>MAR</span></td>
                                            <td><span></span></td>
                                            <td><span>ABR</span></td>
                                            <td><span></span></td>
                                            <td><span>MAY</span></td>
                                            <td><span></span></td>
                                            <td><span>JUN</span></td>
                                            <td><span></span></td>
                                            <td><span>JUL</span></td>
                                            <td><span></span></td>
                                            <td><span>AGO</span></td>
                                            <td><span></span></td>
                                            <td>SEP</td>
                                            <td><span></span></td>
                                            <td><span>OCT</span></td>
                                            <td><span></span></td>
                                            <td>NOV</td>
                                            <td><span></span></td>
                                            <td><span>DIC</span></td>
                                            <td><span></span></td>

                   
                                        </tr>
                                        <tr>
                                            <td style=""width: 20px;""></td>
                                            <td><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td colspan=""4""><span></span></td>
                                
                                            <td style=""width: 20px;""></td>
                                            <td ><span>MES</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.ENE}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.FEB}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.MAR}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.ABR}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.MAY}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.JUN}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.JUL}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.AGO}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.SEP}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.OCT}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.NOV}</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span>{formulario.DatosReemplazar.DIC}</span></td>
                                            <td style=""width: 30px;""></td>
                                        </tr>
                                        <tr>
                                            <td colspan=""34"">&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div style=""margin-top: 40px;"">
                        <table class=""tamano"">
                            <tr><td ><span><strong>SECCION E: INFORMACION GENERAL</strong></span></td></tr>
                        </table>
                        <table class=""tamano bordes"">
                            <tr>
                                <td style=""width: 60%;"">
                                    <table class=""tamano"" >
                                        <tr>
                                            <td ><span>E1. APELLIDOS Y NOMBRE O RAZON SOCIAL DEL DECLARANTE</span></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table class=""bordes tamano"">
                                                    <tr>
                                                        <td  class=""bordes""><span>&nbsp;{formulario.DatosReemplazar.razonSocial}</span></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""bordes""><span>&nbsp;{formulario.DatosReemplazar.nombre}</span></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                           
                                    </table>

                                </td>
                                <td style=""width: 40%;"">
                                    <table class=""tamano"">
                                        <tr>
                                            <td colspan=""4""><span>E2. IDENTIFICACION DEL DECLARANTE</span></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table class=""tamano bordes"">
                                                    <tr>
                                                        <td class=""bordes"" style=""width: 30px;""><span>NIT</span></td>
                                                        <td class=""bordes"" style=""width: 277px;""><span>{formulario.DatosReemplazar.nit}</span></td>
                                                        <td class=""bordes""><span>D.V</span></td>
                                                        <td class=""bordes"" style=""width: 277px;""><span>{formulario.DatosReemplazar.dv}</span></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""bordes""><span>C.C.</span></td>
                                                        <td colspan=""3""><span>{formulario.DatosReemplazar.identificacion}</span></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td colspan=""2"">
                                    <table class=""tamano"" style=""border-collapse: collapse;"">
                                        <tr>
                                            <td><span>E3. DIRECCION</span></td>
                                            <td><span>MUNICIPIO</span></td>
                                            <td><span>DEPARTAMENTO</span></td>
                                            <td><span>TELEFONO</span></td>
                                        </tr>
                                        <tr>
                                            <td class=""bordes""><span>&nbsp;{formulario.Contribuyente.direccion}</span></td>
                                            <td class=""bordes""><span>&nbsp;{formulario.DatosReemplazar.municipio}</span></td>
                                            <td class=""bordes""><span>&nbsp;{formulario.DatosReemplazar.departamento}</span></td>
                                            <td class=""bordes""><span>&nbsp;{formulario.Contribuyente.telefono}</span></td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div style=""margin-top: 40px;"">
                        <table class=""tamano"" style=""border-collapse: collapse;"">
                            <tr>
                                <td colspan=""2""><span>SECCION F: LIQUIDACION</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes"" style=""width: 30px;""></td>
                                <td class=""bordes""><span>F1. CLASE DE PRODUCTO</span></td>
                                <td class=""bordes""><span>F2. CANTIDAD DE GALONES GAVADOS</span></td>
                                <td class=""bordes""><span>F3. TARIFAS</span></td>
                                <td class=""bordes"" style=""width: 50px;""><span>F4. % DE ALCOHOL CARBUR</span></td>
                                <td class=""bordes""><span>F5. BASE GRAVABLE</span></td>
                                <td class=""bordes""><span>F6. SOBRETASA</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>1</span></td>
                                <td class=""bordes""><span>GASOLINA CORRIENTE BASICA</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.galonesGasoCorriente}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.tarifaGasoCorriente}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.gasoCorrienteCarbu}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.baseGasoCorriente.ToString("0,0")}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoCorriente.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>2</span></td>
                                <td class=""bordes""><span>GASOLINA CORRIENTE OXIGENADA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoCorriOxigenada}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.tarifaGasoCorriOxigenada}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoCorriOxigenadaCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoCorriOxigenada.ToString("0,0")}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoCorriOxigenada.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>3</span></td>
                                <td class=""bordes""><span>GASOLINA EXTRA BASICA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoExtra}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.tarifaGasoExtra}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoExtraCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoExtra.ToString("0,0")}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoExtra.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>4</span></td>
                                <td class=""bordes""><span>GASOLINA EXTRA OXIGENADA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoExtraOxi}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.tarifaGasoExtraOxi}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoExtraOxiCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoExtraOxi.ToString("0,0")}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoExtraOxi.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>5</span></td>
                                <td class=""bordes""><span>GASOLINA IMPORTADA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoImportada}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.tarifaGasoImportada}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoImportadaCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoImportada.ToString("0,0")}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoImportada.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>6</span></td>
                                <td class=""bordes""><span>GASOLINA NAL.CTE.BASICA Z.F</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoZFBasica}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.tarifaGasoZFBasica}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoZFBasicaCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoZFBasica.ToString("0,0")}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.baseGasoZFOxi.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>7</span></td>
                                <td class=""bordes""><span>GASOLINA NAL.CTE.OXIGENADA Z.F</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoZFOxi}</span></td>
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.tarifaGasoZFOxi}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoZFOxiCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoZFOxi.ToString("0,0")}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoZFOxi.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>8</span></td>
                                <td colspan=""5"" class=""bordes""><span>TOTAL SOBRETASA A CARGO</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.totalSobreTasa.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>9</span></td>
                                <td colspan=""5"" class=""bordes""><span>VALOR SANCIONES</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sanciones.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>10</span></td>
                                <td colspan=""5"" class=""bordes""><span>TOTAL A CARGO</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.totalSaldoCargo.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td></td>
                                    <td colspan=""5""><span><strong>SECCION H: PAGOS</strong></span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>11.</span></td>
                                    <td colspan=""5"" class=""bordes""><span>VR.SOBRETASA</span></td>
               
                                    <td  class=""bordes""><span>{formulario.DetalleDeclaracion.totalSobreTasa.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>12.</span></td>
                                <td colspan=""5"" class=""bordes""><span>VR.SANCIONES</span></td>
            
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.sanciones.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>13.</span></td>
                                    <td colspan=""5"" class=""bordes""><span>VR.INTERESES DE MORA</span></td>
                
                                    <td class=""bordes""><span>{formulario.DetalleDeclaracion.interesMora}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>14.</span></td>
                                <td colspan=""5"" class=""bordes""><span>MENOS:COMPENSACIONES</span></td>
           
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.compensacion.ToString("0,0")}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>15.</span></td>
                                <td colspan=""5"" class=""bordes""><span>VR.TOTAL A PAGAR</span></td>
            
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.totalPagarCargo.ToString("0,0")}</span></td>
                            </tr>
                        </table>
                    </div>

                    <div class=""lados"" style=""margin-top: 40px;"">

                       <table>
                        <table class=""bordes"">
                            <tr>
                                <td width=""5%"" rowspan=""3"" align=""center""
                                  style=""border-left: 1px solid #000000; border-right: 1px solid #000000; border-bottom: 1px solid #000000;"">
                                  <table border=""0"" cellspacing=""0"" cellpadding=""0"">
                                    <tbody>
                                      <tr>
                                        <td align=""center"" rowspan=""3""><img style=""height: 50px;""
                                            src='data:image/png;base64,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' />
                                        </td>
                                      </tr>
                                    </tbody>
                                  </table>
                                </td>
                                <td colspan=""4"" align=""left"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  <strong>FIRMA DECLARANTE
                                    <br>
                                    <br>
                                    <br>
                                    <br>
                                    <br>
                                    <!-- <center><img style=""width:22%; height:39%;""  -->
              
                                    ______________________________________________________________</strong>
                                </td>
                                <td colspan=""5"" align=""left"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  <table width=""100%"" border=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"">
                                    <tbody>
                                      <tr>
                                        <td align=""left""><strong>FIRMA DEL CONTADOR
                                            <label><br><strong>________{formulario.DatosReemplazar.contador}________</strong></label>
                                          </strong></td>
                              
                                        <td align=""center""><strong>REVISOR FISCAL
                                            <label><br><strong>_________{formulario.DatosReemplazar.revisor}_______</strong></label>
                                          </strong></td>
                                      </tr>
                                    </tbody>
                                  </table>
                                  <strong>
                                    <br>
                                    <br>
                                    <br>
                                    <br>
                                    <br>
                                    <!-- <center><img style=""width:22%; height:36%; visibility:{{FirmaContadorxRevisor}}""  -->
              
                                    ______________________________________________________________</strong>
                                </td>
                              </tr>
                              <tr>
                                <td colspan=""4"" align=""left"" style=""padding: 5px 10px;border: 1px solid #000000;""><strong>NOMBRE:
                                    {formulario.DetalleDeclaracion.nombreDeclarante}</strong></td>
                                <td colspan=""5"" align=""left"" style=""padding: 5px 10px;border: 1px solid #000000;""><strong>NOMBRE:
                                    {formulario.DetalleDeclaracion.nombreContador}</strong></td>
                              </tr>
                              <tr>
                                <td colspan=""4"" align=""left"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                    <tbody>
                                      <tr>
                                        <td align=""center""><strong>CC</strong>
                                        <td align=""left""><strong>No.</strong> <strong>{formulario.DetalleDeclaracion.documentoDeclarante}</strong></td>
                                      </tr>
                                    </tbody>
                                  </table>
                                </td>
                                <td colspan=""5"" align=""left"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                    <tbody>
                                      <tr>
                                        <td align=""center""><strong>CC</strong>
                                        <td align=""left""><strong>No.</strong> <strong>{formulario.DetalleDeclaracion.documentoContadorRevisor}</strong></td>
                                        <td align=""left""><strong>T.P.</strong> <strong>{formulario.DetalleDeclaracion.tarjetaProfesional}</strong></td>
                                      </tr>
                                    </tbody>
                                  </table>
                                </td>
                              </tr>
              
                              <tr style=""padding: 5px 10px;border: 1px solid #000000;"">
                                <td colspan=""5"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  <img src=""{Code}"" width=""100%"" alt="""">
                                </td>
                                <td colspan=""5"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                </td>
                                <!-- <td colspan=""5"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;""> -->
                                <!-- ESPACIO PARA SELLO O TIMBRE -->
                                <!-- </td> -->
                              </tr>
              
                              <tr>
                                <td width=""35%"" colspan=""3"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  ESPACIO PARA CÓDIGO QR</td>
                                <td colspan=""2"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  <br /><br /><br />FORMULARIO No.{formulario.DetalleDeclaracion.ano} - {formulario.DetalleDeclaracion.radicadoCorreccion}
              
                                </td>
                                <td colspan=""5"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  <p>ESPACIO PARA SELLO O TIMBRE</p>
                                  <br><br>
                                  <p></p>
                                </td>
                              </tr>
                              <tr>
              
                                <td colspan=""5"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  Carrera 55 N 46 A 16 Barrio Colonia Sur- Codigo Postal 053410
                                  <br>
                                  Telefono: 01800400108-(094) 8325109 / Extencion 105 - 121
                                </td>
                                <td colspan=""5"" align=""center"" style=""padding: 5px 10px;border: 1px solid #000000;"">
                                  Pagina Web: www.yondo-antioquia.gov.vo <br>
                                  Email: secretariadehacienda@yondo-antioquia.gov.co <br> recaudo@yondo-antioquia.gov.co /
                                  fiscalizacion@yondo.gov.co
                                </td>
                              </tr>
                               </tbody>
                                </table>
                                </tr>
                            </table>
                        </div>
            </body>

            </html>";

       
            return body;
        }

        public string CodigoBarras(string valorFactura, string fecha, string factura, string codigoBarras)
        {
          
            string CodeBar = "";
            int j, lengthE;
            int ma = 0, me = 999999999;
            if (!String.IsNullOrEmpty(codigoBarras))
            {

                for (j = 0; j < 50; j++)
                {
                    Linear barcode = new Linear();
                    barcode.Type = BarcodeType.EAN128;
                    barcode.Data = "(415)" + codigoBarras + "(8020)" + factura.Replace(".", "").PadLeft(8, '0') + "(3900)" + valorFactura.Replace(",", "").Replace(".", "").PadLeft(10, '0') + "(96)" + fecha;
                    barcode.UOM = UnitOfMeasure.PIXEL;
                    barcode.BarWidth = 2;
                    barcode.TopMargin = 10;
                    barcode.TextFont = new Font("Arial", 16, FontStyle.Bold);
                    byte[] base64SingleBytes = barcode.drawBarcodeAsBytes();
                    lengthE = base64SingleBytes.GetLength(0);

                    if (lengthE > ma) { ma = lengthE; }
                    if (lengthE < me) { me = lengthE; }

                    if (ma != lengthE)
                    {
                        if (me < ma)
                        {
                            byte[] IMG = base64SingleBytes;
                            CodeBar = string.Format("data:image/png;base64," + Convert.ToBase64String(IMG));
                            break;
                        }
                    }
                }
            }
            //CodeBar.Replace("a", "a\n");

            return CodeBar;
        }

        public byte[] crearPDF(string body)
        {
            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.WebPageWidth = 1920;
            converter.Options.PdfPageSize = PdfPageSize.Letter11x17;
            converter.Options.MarginTop = 20;
            converter.Options.MarginLeft = 20;
            converter.Options.MarginRight = 20;

            PdfDocument doc = converter.ConvertHtmlString(body, "");
            byte[] pdfBytes = doc.Save();
            return pdfBytes;
        }
    }
}
