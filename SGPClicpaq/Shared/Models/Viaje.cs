using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class Viaje
    {
        public int Id { get; set; }
        public string? Guias { get; set; }
        public string? ZonaDestino { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? FechaViaje { get; set; }
        public string? Unidad { get; set; }
        public string? Chofer { get; set; }
        public int? Estado { get; set; }
        public DateTime? TimeGenerado { get; set; }
        public DateTime? TimeCargando { get; set; }
        public DateTime? TimeEnCamion { get; set; }
        public DateTime? TimeSaleCamion { get; set; }
        public int? Sucursal { get; set; }
        public int? TotalGuias { get; set; }
        public int? TotalBultos { get; set; }
        public int? TotalVolumen { get; set; }
        public int? TotalPeso { get; set; }
        public string? Transporte { get; set; }
        public string? EstadoStr { get; set; }
        public int? Kilometros { get; set; }
    }
}
