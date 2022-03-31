using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication1.Models
{
    public class ENCABEZADO_EMISOR
    {
        public string EMPRESA;
        public string RFC_EMPRESA;
        public string REG_PATRONAL;
        public string DOM_EMPRESA;
        public string DOM_LUGAR_TRABAJO;
        public int REG_FISCAL;
        public string LUG_EXPEDICION;
        public string TIPO_COMPROBANTE;
        public string UNIDAD;
    }

    public class ENCABEZADO
    {
        public string FOLIO_FISCAL;
        public DateTime FECHA_EMISION;
        public DateTime FECHA_TIMBRADO;
        public string CERTIFICADO_EMISOR;
        public double CERTIFICADO_SAT;
    }

    public class ENCABEZADO_RECEPTOR
    {
        public string NOM_EMPLEADO;
        public string PUESTO;
        public string RFC_EMPLEADO;
        public string CURP_EMPLEADO;
        public double NSS;
        public string FEC_INGRESO;
        public string DEPARTAMENTO;
        public int CVE_EMPLEADO;
        public string TIPO_NOMINA;
        public double SALARIO_DIARIO;
        public double SDI_IMSS;
        public double SDP;
        public int DIAS_LABORADOS;
        public string PER_PAGO;
    }

    public class CONCEPTOS
    {
        public int CVE_CONCEPTO;
        public string DES_CONCEPTO;
        public int UNIDADES;
        public double PERCEPCIONES;
        public int DEDUCCIONES;
    }

    public class DETALLE
    {
        public List<CONCEPTOS> CONCEPTOS;
    }

    public class TOTAL
    {
        public double TOTAL_PERCEPCION;
        public double TOTAL_DEDUCCION;
        public double NETO_PAGAR;
        public string NETO_LETRA;
    }

    public class TOTAL_QR
    {
        public double NETO_PAGAR_QR;
    }

    public class PRESTACIONES_ESPECIE
    {
        public CONCEPTOS CONCEPTOS;
    }

    public class PIE_PAGINA_1
    {
        public int CUENTA_DEPOSITO;
        public string BANCO_NOMBRE;
        public string LEYENDA_ESPECIE;
        public PRESTACIONES_ESPECIE PRESTACIONES_ESPECIE;
        public int TOTAL_PERCEPCION_ESPECIE;
        public int TOTAL_DEDUCCION_ESPECIE;
        public int NETO_PAGAR_ESPECIE;
    }

    public class PIE_PAGINA_2
    {
        public string LEYENDA;
    }

    public class PIE_PAGINA_3
    {
        public string SELLO_CONTRIBUYENTE;
        public string SELLO_SAT;
        public string CADENA_ORIGINAL;
        public DateTime FECHA_PAGA_LEYENDA;
        public string NOM_EMPLEADO_LEYENDA;
    }

    public class RECIBO_NOMINA_CFDI
    {
        public ENCABEZADO_EMISOR ENCABEZADO_EMISOR;
        public ENCABEZADO ENCABEZADO;
        public ENCABEZADO_RECEPTOR ENCABEZADO_RECEPTOR;
        public DETALLE DETALLE;
        public TOTAL TOTAL;
        public TOTAL_QR TOTAL_QR;
        public PIE_PAGINA_1 PIE_PAGINA_1;
        public PIE_PAGINA_2 PIE_PAGINA_2;
        public PIE_PAGINA_3 PIE_PAGINA_3;
    }

    public class RECIBO_NOMINA
    {
        public RECIBO_NOMINA_CFDI RECIBO_NOMINA_CFDI;
    }


}
