namespace CleanArchitecture.Application.Features.properties.Queries.GetPropiedadList
{
    public class PropiedadVm
    {
        public string? Descripcion { get; set; } = string.Empty;
          public string Direccion { get; set; } = string.Empty;
        public bool Esverificado { get; set; } = false;
        public long? TipoPropiedad { get; set; }
        public long? CiudadId { get; set; }
        public string? Estado { get; set; }
    }
}
