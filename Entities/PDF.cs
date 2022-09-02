using apiSobreTasaGasolina.Model;

namespace apiSobreTasaGasolina.Entities
{
    public class PDF
    {
        public string style = 
        " <style>" +
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
              width: 1700px;" +
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
                        <div style=""width: 40%;"">
                            <p>DECLARACION DE LA SOBRETASA</p>
                            <P>MUNICIPAL Y DISTRITAL A LA</P>
                            <P>GASOLINA MOTOR</P>
                            <P>FORMULARIO MHCP-DAF-024-2021-GAS</P>
                        </div>
                        <div style=""width: 60%;"">
                            <table class=""tamano"" style=""border-collapse: collapse;"">
                                <tr>
                                    <td style=""padding: 13px;"" colspan=""7"" class=""bordes""><span><strong>SECCION A: INFORMACION ENTIDAD TERRITORIAL</strong></span></td>
                                </tr>
                                <tr>
                                    <td style=""padding: 6px;""><span>MUNICIPIO O DISTRITO</span></td>
                                    <td colspan=""5""><span>CODIGO DANE</span></td>
                                </tr>
                                <tr>
                                    <td style=""padding: 6px;"" class=""bordes""><span>YONDO (ANTIOQUIA)</span></td>
                                    <td class=""bordes""><span>0</span></td>
                                    <td class=""bordes""><span>5</span></td>
                                    <td class=""bordes""><span>8</span></td>
                                    <td class=""bordes""><span>9</span></td>
                                    <td class=""bordes""><span>3</span></td>
                                </tr>
                                <tr>
                                    <td style=""padding: 6px;"" colspan=""4"" class=""bordes""><span>NIT</span></td>
                                    <td class=""bordes""><span>D.V</span></td>
                                    <td class=""bordes"">6</td>
                                </tr>
                            </table>
                        </div>

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
                                                <td style=""width: 30px;"" class=""bordes""><span>{formulario.Contribuyente.tipoContribuyente}</span></td>
                                                <td><span>IMPORTADOR</span></td>
                                                <td style=""width: 30px;""></td>
                                                <td style=""width: 30px;"" class=""bordes""></td>
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
                                                <td style=""width: 30px;"" class=""bordes""><span></span></td>
                                                <td><span>OTRO</span></td>
                                                <td style=""width: 30px;""></td>
                                                <td style=""width: 30px;"" class=""bordes""></td>
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
                                                <td style=""width: 60px;text-align: center;"" colspan=""""><span>ANO</span></td>
                                                <td style=""width: 60px;text-align: center;"" colspan=""""><span>MES</span></td>
                                                <td style=""width: 60px;text-align: center;"" colspan=""""><span>DIA</span></td>
                                                <td style=""width: 30px;""></td>
                                            </tr>
                    
                                            <tr>
                                                <td><span></span></td>
                                                <td  class=""bordes""><span>{formulario.idDeclaracion}</span></td>
                                                <td colspan="""" class=""bordes""><span>&nbsp;</span></td>
                                                <td colspan="""" class=""bordes""><span></span></td>
                                                <td class=""bordes""><span></span></td>
                                                <td><span></span></td>
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
                                    <table class=""bordes tamano"">
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
                                            <td><span>ANO</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td colspan=""4"" class=""bordes""><span>{formulario.DetalleDeclaracion.ano}</span></td>
                                
                                            <td style=""width: 20px;""></td>
                                            <td ><span>MES</span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
                                            <td style=""width: 20px;""></td>
                                            <td class=""bordes""><span></span></td>
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
                                                        <td  class=""bordes""><span>{formulario.Contribuyente.nombre}</span></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""bordes""><span>&nbsp;</span></td>
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
                                                        <td class=""bordes""><span>{formulario.Contribuyente.documento}</span></td>
                                                        <td class=""bordes""><span>D.V</span></td>
                                                        <td class=""bordes""><span></span></td>
                                                    </tr>
                                                    <tr>
                                                        <td class=""bordes""><span>C.C.</span></td>
                                                        <td colspan=""3""><span></span></td>
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
                                            <td class=""bordes""><span>&nbsp;{formulario.Contribuyente.municipio}</span></td>
                                            <td class=""bordes""><span>&nbsp;</span></td>
                                            <td class=""bordes""><span>&nbsp;</span></td>
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
                                <td class=""bordes""><span>F3. TARIFA</span></td>
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
                                <td class=""bordes""><span>{formulario.DetalleDeclaracion.baseGasoCorriente}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoCorriente}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>2</span></td>
                                <td class=""bordes""><span>GASOLINA CORRIENTE OXIGENADA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoCorriOxigenada}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.tarifaGasoCorriOxigenada}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoCorriOxigenadaCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoCorriOxigenada}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoCorriOxigenada}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>3</span></td>
                                <td class=""bordes""><span>GASOLINA EXTRA BASICA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoExtra}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.tarifaGasoExtra}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoExtraCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoExtra}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoExtra}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>4</span></td>
                                <td class=""bordes""><span>GASOLINA EXTRA OXIGENADA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoExtraOxi}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.tarifaGasoExtraOxi}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoExtraOxiCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoExtraOxi}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoExtraOxi}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>5</span></td>
                                <td class=""bordes""><span>GASOLINA IMPORTADA</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoImportada}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.tarifaGasoImportada}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoImportadaCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoImportada}</span></td>
                                <td class=""bordes""><span>$ {formulario.DetalleDeclaracion.sobretasaGasoImportada}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>6</span></td>
                                <td class=""bordes""><span>GASOLINA NAL.CTE.BASICA Z.F</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoZFBasica}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.tarifaGasoZFBasica}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoZFBasicaCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoZFBasica}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.baseGasoZFOxi}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>7</span></td>
                                <td class=""bordes""><span>GASOLINA NAL.CTE.OXIGENADA Z.F</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.galonesGasoZFOxi}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.tarifaGasoZFOxi}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.gasoZFOxiCarbu}</span></td>
                                <td class=""bordes""><span>{ formulario.DetalleDeclaracion.baseGasoZFOxi}</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sobretasaGasoZFOxi}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>8</span></td>
                                <td colspan=""5"" class=""bordes""><span>TOTAL SOBRETASA A CARGO</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.totalSobreTasa}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>9</span></td>
                                <td colspan=""5"" class=""bordes""><span>VALOR SANCIONES</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.sanciones}</span></td>
                            </tr>
                            <tr>
                                <td class=""bordes""><span>10</span></td>
                                <td colspan=""5"" class=""bordes""><span>TOTAL A CARGO</span></td>
                                <td class=""bordes""><span>${formulario.DetalleDeclaracion.totalSaldoCargo}</span></td>
                            </tr>
                        </table>
                    </div>

                    <div class=""lados"" style=""margin-top: 40px;"">

                        <div class=""tamano"">
                            <table class=""tamano"" style=""border-collapse: collapse;"">
                                <tr>
                                    <td colspan=""10"" style=""border-bottom: 1px solid;""><span><strong>SECCION G: FIRMAS</strong></span></td>
                                    <td></td>
                                    <td colspan=""5""><span><strong>SECCION H: PAGOS</strong></span></td>
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid;""><span><strong>G1.DECLARANTE</strong></span></td>
                                    <td ></td>
                                    <td style=""border-right: 1px solid;"" colspan=""8""><span>declaro que la informacion aqui</span></td>
                                    <td></td>
                                    <td class=""bordes"" style=""width: 30px;""><span>11.</span></td>
                                    <td colspan=""3"" class=""bordes""><span>VR.SOBRETASA</span></td>
                       
                                    <td  class=""bordes""><span></span></td>
                                </tr>
                                <tr>
                                    <td colspan=""10"" style=""border-left: 1px solid;border-right: 1px solid;""><span>consignada es correcta y ajustada a las disposiciones legales</span></td>
                                    <td></td>
                                    <td class=""bordes""><span>12.</span></td>
                                    <td colspan=""3"" class=""bordes""><span>VR.SANCIONES</span></td>
                        
                                    <td class=""bordes""><span></span></td>
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid;""><span>FIRMA</span></td>
                                    <td ></td>
                                    <td style=""border-right: 1px solid;"" colspan=""8"" ><span>________________________________________________________</span></td>
                                    <td></td>
                                    <td class=""bordes""><span>13.</span></td>
                                    <td colspan=""3"" class=""bordes""><span>VR.INTERESES DE MORA</span></td>
                        
                                    <td class=""bordes""><span></span></td>
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid;""><span>NOMBRES Y APELLIDOS</span></td>
                                    <td></td>
                                    <td style=""border-right: 1px solid;"" colspan=""8""><span>________________________________________________________</span></td>
                                    <td></td>
                                    <td class=""bordes""><span>14.</span></td>
                                    <td colspan=""3"" class=""bordes""><span>MENOS:COMPENSACIONES</span></td>
                       
                                    <td class=""bordes""><span></span></td>
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid; border-bottom: 1px solid;""><span>C.C</span></td>
                                    <td style=""border-bottom: 1px solid;""></td>
                                    <td style=""border-bottom: 1px solid; border-right: 1px solid;"" colspan=""8""><span>1.018.431.450</span></td>
                                    <td></td>
                                    <td class=""bordes""><span>15.</span></td>
                                    <td colspan=""3"" class=""bordes""><span>VR.TOTAL A PAGAR</span></td>
                        
                                    <td class=""bordes""><span></span></td>
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid;""><span></span></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td style=""border-right: 1px solid;""></td>
                                    <td style=""border-right: 1px solid;""></td>
                                    <td style=""border-left: 1px solid;"" colspan=""2""><span><strong>FORMA DE PAGO:</strong></span></td>
                                    <td ><span></span></td>
                                    <td></td>
                                    <td style=""border-right: 1px solid;""><span></span></td>
                        
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid;""><span><strong>G.2 CONTADOR</strong></span></td>
                                    <td colspan=""2""></td>
                                    <td class=""bordes"" style=""width: 30px;""></td>
                                    <td style=""width: 30px;""><span></span></td>
                                    <td><span>REVISOR FISCAL</span></td>
                                    <td class=""bordes"" style=""width: 30px;""></td>
                                    <td style=""width: 30px;""></td>
                                    <td style=""border-right: 1px solid;"" colspan=""2""></td>
                                    <td></td>
                        
                                    <td style=""border-left: 1px solid;"" colspan=""2""><span>EFECTIVO</span></td>
                                    <td colspan=""""><span></span></td>
                                    <td></td>
                                    <td style=""border-right: 1px solid;""><span>$_______________________</span></td>
                        
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid; border-right:1px solid"" colspan=""10""><span></span></td>
                
                                    <td></td>

                                    <td style=""border-left: 1px solid;"" colspan=""2""><span>CHEQUE No</span></td>
                                    <td ><span></span></td>
                                    <td></td>
                                    <td style=""border-right: 1px solid;""><span>$_______________________</span></td>
                        
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid;""><span>FIRMA</span></td>
                                    <td style=""width: 30px;""><span></span></td>
                                    <td style=""border-right: 1px solid;"" colspan=""8""><span>___________________________________________________</span></td>
                        
                                    <td>&nbsp;</td>
                                    <td style=""border-left: 1px solid;"" colspan=""2""><span>CODIGO BANCO</span></td>
                                    <td class=""bordes"" style=""width: 30px;""><span></span></td>
                                    <td class=""bordes"" style=""width: 30px;""><span>&nbsp;</span></SPan></td>
                                    <td style=""border-right: 1px solid;"" colspan=""2""><span>$_______________________</span></td>
                        
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid;""><span>NOMBRES Y APELLIDOS</span></td>
                                    <td ><span></span></td>
                                    <td style=""border-right: 1px solid;"" colspan=""8""><span>___________________________________________________</span></td>
                                    <td></td>
                                    <td style=""border-left: 1px solid;border-right:1px solid"" colspan=""6""><span></span></td>
                                </tr>
                                <tr>
                                    <td style=""border-left: 1px solid; border-bottom: 1px solid;""><span>C.C</span></td>
                                    <td style=""border-bottom: 1px solid;""><span></span></td>
                                    <td style=""border-bottom: 1px solid;""><span>1.018.431.450</span></td>
                                    <td style=""border-bottom: 1px solid;""><span>T.P.</span></td>
                                    <td style=""border-bottom: 1px solid;""><span></span></td>
                                    <td style=""border-bottom: 1px solid;""><span></span></td>
                                    <td style=""border-right: 1px solid; border-bottom: 1px solid;"" colspan=""4""><span>173594-T</span></td>
                                    <td></td>
                        
                                    <td colspan=""6"" class=""bordes""><span></span></td>           
                                </tr>
                            </table>
        
                        </div>

                        <div class=""tamano lados"" style=""margin-top: 40px;"">
                            <div style=""width: 49%;"">
                                <table class=""bordes tamano"">
                                    <tr>
                                        <td style=""font-size: 40px; padding:40px""><span>TIMBRE Y SELLO DEL BANCO</span></td>
                                    </tr>
                                </table>
    
                            </div>

                            <div style=""width: 2%;""></div>

                           <div style=""width: 49%;"">
                            <table class=""bordes tamano"" >
                                <tr>
                                    <td  style=""font-size: 40px; padding:40px"" ><span>AUTOADHESIVO</span></td>
                                </tr>
                            </table>
                           </div>
              
                        </div>

                    </div>

                    <div class=""lados"" style=""margin-top: 300px;"">
                        <div style=""width: 40%;"">
                            <p>DECLARACION DE LA SOBRETASA</p>
                            <P>MUNICIPAL Y DISTRITAL A LA</P>
                            <P>GASOLINA MOTOR</P>
                            <P>FORMULARIO MHCP-DAF-024-2021-GAS</P>
                        </div>
                        <div style=""width: 60%;"">
                            <table class=""tamano"" style=""border-collapse: collapse;"">
                                <tr>
                                    <td style=""padding: 13px;"" colspan=""7"" class=""bordes""><span><strong>SECCION A: INFORMACION ENTIDAD TERRITORIAL</strong></span></td>
                                </tr>
                                <tr>
                                    <td style=""padding: 6px;""><span>MUNICIPIO O DISTRITO</span></td>
                                    <td colspan=""5""><span>CODIGO DANE</span></td>
                                </tr>
                                <tr>
                                    <td style=""padding: 6px;"" class=""bordes""><span>YONDO (ANTIOQUIA)</span></td>
                                    <td class=""bordes""><span>0</span></td>
                                    <td class=""bordes""><span>5</span></td>
                                    <td class=""bordes""><span>8</span></td>
                                    <td class=""bordes""><span>9</span></td>
                                    <td class=""bordes""><span>3</span></td>
                                </tr>
                                <tr>
                                    <td style=""padding: 6px;"" colspan=""4"" class=""bordes""><span>NIT</span></td>
                                    <td class=""bordes""><span>D.V</span></td>
                                    <td class=""bordes"">6</td>
                                </tr>
                            </table>
                        </div>

                        <div class=""tamano"">
                            <table class=""tamano bordes"">
                                <tr>
                                    <td class=""bordes"" style=""width: 30px;""><span></span></td>
                                    <td class=""bordes""><span>F1. CLASE DE PRODUCTO</span></td>
                                    <td class=""bordes""><span>F2. CANTIDAD DE GALONES GRAVADOS</span></td>
                                    <td class=""bordes""><span>F3. TARIFA</span></td>
                                    <td class=""bordes""><span>F4. % DE ALCOHOL CARBUR</span></td>
                                    <td class=""bordes""><span>F5. BASE GRAVABLE</span></td>
                                    <td class=""bordes""><span>F6. SOBRETASA</span></td>
                                </tr>
                                <tr>
                                    <td class=""bordes""><span></span></td>
                                    <td class=""bordes""><span>GASOLINA CORRIENTE 6% OXIGENADA</span></td>
                                    <td class=""bordes""><span>34.240,000</span></td>
                                    <td class=""bordes""><span>940,00</span></td>
                                    <td class=""bordes""><span>6.00</span></td>
                                    <td class=""bordes""><span>32.185,60</span></td>
                                    <td class=""bordes""><span>30.254.464,00</span></td>
                                </tr>
                                <tr>
                                    <td class=""bordes""><span>1</span></td>
                                    <td class=""bordes""><span>TOTAL GASOLINA CORRIENTE OXIGENADA</span></td>
                                    <td class=""bordes""><span>34.240,000</span></td>
                                    <td class=""bordes""><span></span></td>
                                    <td class=""bordes""><span></span></td>
                                    <td class=""bordes""><span>32.185,60</span></td>
                                    <td class=""bordes""><span>30.254.464,00</span></td>
                                </tr>
                                <tr>
                                    <td class=""bordes""><span>2</span></td>
                                    <td class=""bordes""><span>TOTAL GASOLINA EXTRA OXIGENADA</span></td>
                                    <td class=""bordes""><span>34.240,000</span></td>
                                    <td class=""bordes""><span></span></td>
                                    <td class=""bordes""><span></span></td>
                                    <td class=""bordes""><span>32.185,60</span></td>
                                    <td class=""bordes""><span>30.254.464,00</span></td>
                                </tr>
                                <tr>
                                    <td class=""bordes""><span>3</span></td>
                                    <td class=""bordes""><span>TOTAL GASOLINA CORRIENTE OXIGENADA Z.F.</span></td>
                                    <td class=""bordes""><span>34.240,000</span></td>
                                    <td class=""bordes""><span></span></td>
                                    <td class=""bordes""><span></span></td>
                                    <td class=""bordes""><span>32.185,60</span></td>
                                    <td class=""bordes""><span>30.254.464,00</span></td>
                                </tr>
                            </table>
                        </div>
                    </div>
      
                </div>

   
   
    
            </body>

            </html>";
            return body;
        }



    }
}
