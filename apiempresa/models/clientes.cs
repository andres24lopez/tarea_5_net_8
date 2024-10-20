using System.ComponentModel.DataAnnotations;

namespace apiempresa.models;

    public class clientes {
    [Key]
     public Int32 id_clientes { get; set; }
    public string? nombres { get; set; }
     public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono{ get; set; }
    public DateTime? fecha_nacimiento { get; set; }

    

    }