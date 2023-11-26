using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem.Repository
{
    public class SalesRepository : BaseRepository<Sales>
    {
        private readonly OrdersRepository _ordersRepository;
        private readonly FurnitureRepository _furnitureRepository;
        public SalesRepository(string connectionString, OrdersRepository ordersRepository, FurnitureRepository furnitureRepository) : base(connectionString)
        {
            _ordersRepository = ordersRepository;
            _furnitureRepository = furnitureRepository;
        }

        protected override string TableName => "[FurnitureStore].[dbo].[Sales]";

        protected override string IdentificatorName => "SaleID";

        protected override Dictionary<string, dynamic?> ConvertToParameters(Sales item)
        {
            return new Dictionary<string, dynamic?>
            {
                { "OrderID",  item.OrderID.Id},
                { "SaleDate",  item.SaleDate},
                { "FurnitureID",  item.FurnitureID.Id},
                { "QuantitySold",  item.QuantitySold}

            };
        }

        protected override Sales ConvetFromReader(SqlDataReader reader)
        {
            var result = new Sales
            {
                Id = reader.GetInt32(0),
                SaleDate = reader.GetDateTime(2),
                QuantitySold = reader.GetInt32(4),
            };
            var orderID = reader.GetInt32(1);
            var furnitureID = reader.GetInt32(3);

            result.OrderID = _ordersRepository.Get(orderID);
            result.FurnitureID= _furnitureRepository.Get(furnitureID);
            return result;
        }
    }
}
