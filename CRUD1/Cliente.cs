using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD1
{
    [Table("cliente")]
    public class Cliente
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombrecliente")]
        public string? NombreCliente { get; set; }

        [Column("movil")]
        public string? Movil { get; set; }

        [Column("email")]
        public string? Email
        {
            get; set;
        }
    }
}
