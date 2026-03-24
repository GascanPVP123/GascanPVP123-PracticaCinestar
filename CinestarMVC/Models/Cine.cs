
namespace CinestarMVC.Models
{
    public class Cine
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Descripcion { get; set; }
        public string Telefonos { get; set; }
        public int idDistrito { get; set; }
        public string Direccion { get; set; }
        public int Salas { get; set; }

        public Cine(DataRow dr) 
        {
            Id = int.Parse(dr["Id"].ToString());
            RazonSocial = dr["RazonSocial"].ToString();
            Salas = int.Parse(dr["Salas"].ToString());
            idDistrito = int.Parse(dr["IdDistrito"].ToString);
            Direccion = dr["Direccion"].ToString;
            Telefonos = dr["Telefonos"].ToString;
            Descripcion = dr["Descripcion"].ToString;

        }
    }
}
