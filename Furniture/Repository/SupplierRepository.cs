using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem.Repository
{
    public class SupplierRepository : BaseRepository<Supplier>
    {
        public SupplierRepository(string connectionString) : base(connectionString)
        {
        }

        protected override string TableName => "[FurnitureStore].[dbo].[Suppliers]";

        protected override string IdentificatorName => "SupplierID";

        protected override Dictionary<string, dynamic?> ConvertToParameters(Supplier item)
        {
            return new Dictionary<string, dynamic?>
            {
                { "SupplierName",  item.Name},
                { "ContactPerson",  item.ContactPerson},
                { "Phone",  item.Phone},
                { "Email",  item.Email},
                { "Address",  item.Adress}

            };
        }

        protected override Supplier ConvetFromReader(SqlDataReader reader)
        {
            return new Supplier
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                ContactPerson = reader.GetString(2),
                Phone = reader.GetString(3),
                Email = reader.GetString(4),
                Adress = reader.GetString(5),
            };
        }
    }
}
