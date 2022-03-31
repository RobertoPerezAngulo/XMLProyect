using ConsoleApplication1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Web;
using PdfSharp.Drawing;
using System.Drawing;
using ConsoleApplication1.Rpt;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string path = @"C:\Users\jrperez\Documents\visual studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\38632_15032022_Formato2.xml";
                string _xmlNomina = @"C:\Users\jrperez\Documents\visual studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\Recursos\XMLNomina.html";
                XmlSerializer serializer = new XmlSerializer(typeof(RECIBO_NOMINA));
                var doc1 = File.ReadAllText(path);
                var _xml = File.ReadAllText(_xmlNomina);
                RECIBO_NOMINA oNomina =  (RECIBO_NOMINA)serializer.Deserialize(new StringReader(doc1));
                //var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                //htmlToPdf.Orientation = NReco.PdfGenerator.PageOrientation.Portrait;
                //htmlToPdf.Zoom = 3f;
                //htmlToPdf.Size = NReco.PdfGenerator.PageSize.A3;
                //htmlToPdf.GeneratePdf(_xml, null, @"C:\Users\jrperez\Documents\visual studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\mapa.pdf");


                Nomina rpt = new Nomina();
                rpt.SetParameterValue("NOMBRE_PAGADORA", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_EMISOR.EMPRESA);
                rpt.SetParameterValue("REGI_PAT", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_EMISOR.REG_PATRONAL);
                rpt.SetParameterValue("RFC", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_EMISOR.RFC_EMPRESA);
                rpt.SetParameterValue("DOMICILIO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_EMISOR.DOM_EMPRESA.Replace("|"," "));
                rpt.SetParameterValue("REGIMEN_FISCAL", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_EMISOR.REG_FISCAL);
                rpt.SetParameterValue("LUGAR_DE_EXPE", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_EMISOR.LUG_EXPEDICION);
                rpt.SetParameterValue("TIPO_COMPRO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_EMISOR.TIPO_COMPROBANTE);
                rpt.SetParameterValue("FOLIO_FISCAL", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO.FOLIO_FISCAL);
                rpt.SetParameterValue("FECHA_EMI", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO.FECHA_EMISION);
                rpt.SetParameterValue("FECHA_TIMBRA", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO.FECHA_TIMBRADO);
                rpt.SetParameterValue("CERTIFICADO_EMI", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO.CERTIFICADO_EMISOR);
                rpt.SetParameterValue("CERTIFICADO_SAT", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO.CERTIFICADO_SAT.ToString());
                rpt.SetParameterValue("NOMBRE_EMPLEADO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.NOM_EMPLEADO);
                rpt.SetParameterValue("PUESTO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.PUESTO);
                rpt.SetParameterValue("RFC_EMPLEADO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.RFC_EMPLEADO);
                rpt.SetParameterValue("CLAVE_EMPLEADO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.CVE_EMPLEADO);
                rpt.SetParameterValue("CURP", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.CURP_EMPLEADO);
                rpt.SetParameterValue("NSS", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.NSS);
                rpt.SetParameterValue("FECHA_INGRESO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.FEC_INGRESO);
                rpt.SetParameterValue("DEPARTAMENTO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.DEPARTAMENTO);
                rpt.SetParameterValue("TIPO_NOMINA", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.TIPO_NOMINA);
                rpt.SetParameterValue("SALARIO_DIARIO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.SALARIO_DIARIO);
                rpt.SetParameterValue("SDI_IMSS", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.SDI_IMSS);
                rpt.SetParameterValue("DIAS_LABO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.DIAS_LABORADOS);
                rpt.SetParameterValue("PERIODO_PAGO", oNomina.RECIBO_NOMINA_CFDI.ENCABEZADO_RECEPTOR.PER_PAGO);
                rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\Users\jrperez\Documents\visual studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\cheetos.pdf");
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
