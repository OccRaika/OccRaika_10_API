namespace Raika_OCC_10_API.DTOs.UserDTO_s
{
    public class UserGetDTO
    {
        public string Nombre { get; set; } = string.Empty!;
        public string ApellidoPaterno { get; set; } = string.Empty!;
        public string ApellidoMaterno { get; set; } = string.Empty!;
        public string? Calle { get; set; }
        public string? Colonia { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Municipio { get; set; }
        public string? EntidadFederativa { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? Celular { get; set; }
        public string? CondicionVida { get; set; }
        public string? Sexo { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? EstadoCivil { get; set; }
        public string? Nacionalidad { get; set; }
    }
}
