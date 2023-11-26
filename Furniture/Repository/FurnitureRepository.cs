using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem.Repository
{
    public class FurnitureRepository : BaseRepository<Furniture>
    {
        private readonly SupplierRepository _supplierRepository;
        public FurnitureRepository(string connectionString, SupplierRepository supplierRepository) : base(connectionString)
        {
            _supplierRepository = supplierRepository;
        }

        protected override string TableName => "[FurnitureStore].[dbo].[Furniture]";

        protected override string IdentificatorName => "FurnitureID";

        protected override Dictionary<string, dynamic?> ConvertToParameters(Furniture item)
        {
            return new Dictionary<string, dynamic?>
            {
                { "Name",  item.Name},
                { "Category",  item.Category},
                { "Price",  item.Price.Value.ToString().Replace(",",".")},
                { "StockQuantity",  item.StockQuantity},
                { "Description",  item.Description},
                { "ManufactureDate",  item.ManufactureDate},
                { "SupplierID",  item.SupplierID?.Id},

            };
        }

        protected override Furniture ConvetFromReader(SqlDataReader reader)
        {
            var result = new Furniture
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Category = reader.GetString(2),
                Price = reader.GetDecimal(3),
                StockQuantity = reader.GetInt32(4),
                Description = reader.GetString(5),
                ManufactureDate = reader.GetDateTime(6)
            };

            var supplierID = reader.GetInt32(7);

            result.SupplierID = _supplierRepository.Get(supplierID);
            return result;
        }
    }
}
