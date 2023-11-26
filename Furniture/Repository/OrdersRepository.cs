using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureItem.Repository
{
    public class OrdersRepository : BaseRepository<Order>
    {
        public OrdersRepository(string connectionString) : base(connectionString)
        {
        }

        protected override string TableName => "[FurnitureStore].[dbo].[Orders]";

        protected override string IdentificatorName => "OrderID";

        protected override Dictionary<string, dynamic?> ConvertToParameters(Order item)
        {
            return new Dictionary<string, dynamic?>
            {
                { "CustomerName",  item.Name},
                { "OrderDate",  item.OrderDate},
                //{ "TotalAmount",  item?.TotalAmount.Value.ToString().Replace(",",".")},

            };
        }

        protected override Order ConvetFromReader(SqlDataReader reader)
        {
            return new Order
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                OrderDate = reader.GetDateTime(2),
                //TotalAmount = reader.GetDecimal(3),
            };
        }
    }
}
