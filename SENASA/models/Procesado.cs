using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENASA.models
{
    public class Procesado
    {
        int turno;
        String fechaInicio;
        int idEmpaque;
        String up;
        int certificado;
        String producto;
        String variedad;
        int bins;
        Decimal kgVolcados;
        String descripcionCajas;
        String Confeccion;
        Decimal peso;
        int cajas;

        public Procesado(int turno, string fechaInicio, int idEmpaque, string up, int certificado, string producto, string variedad, int bins, decimal kgVolcados, string descripcionCajas, string confeccion, decimal peso, int cajas)
        {
            this.Turno = turno;
            this.FechaInicio = fechaInicio;
            this.IdEmpaque = idEmpaque;
            this.Up = up;
            this.Certificado = certificado;
            this.Producto = producto;
            this.Variedad = variedad;
            this.Bins = bins;
            this.KgVolcados = kgVolcados;
            this.DescripcionCajas = descripcionCajas;
            Confeccion1 = confeccion;
            this.Peso = peso;
            this.Cajas = cajas;
        }

        public int Turno { get => turno; set => turno = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int IdEmpaque { get => idEmpaque; set => idEmpaque = value; }
        public string Up { get => up; set => up = value; }
        public int Certificado { get => certificado; set => certificado = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Variedad { get => variedad; set => variedad = value; }
        public int Bins { get => bins; set => bins = value; }
        public decimal KgVolcados { get => kgVolcados; set => kgVolcados = value; }
        public string DescripcionCajas { get => descripcionCajas; set => descripcionCajas = value; }
        public string Confeccion1 { get => Confeccion; set => Confeccion = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public int Cajas { get => cajas; set => cajas = value; }
    }
}
