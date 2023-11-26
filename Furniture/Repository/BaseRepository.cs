
using Baseess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace FurnitureItem.Repository
{
    //public abstract class BaseRepository<T> where T : Basess, new()
    //{
    //    private readonly string _connectionString = "";

    //    /*protected abstract string SelectCommand { get; }
    //    protected abstract string InsertCommand { get; }
    //    protected abstract string DeleteCommand { get; }*/

    //    private readonly string _selectCommand;
    //    private readonly string _insertCommand;
    //    private readonly string _deleteCommand;
    //    private readonly string _updateCommand;

    //    protected abstract string TableName { get; }
    //    protected abstract string IdentificatorName { get; }
    //    public BaseRepository(string connectionString)
    //    {
    //        _connectionString = connectionString;

    //        _selectCommand = $"SELECT * FROM {TableName}";
    //        _insertCommand = $"INSERT INTO {TableName} VALUES(<values>) SELECT SCOPE_IDENTITY()";
    //        _deleteCommand = $"DELETE FROM {TableName} WHERE {IdentificatorName} = ";
    //        _updateCommand = $"UPDATE {TableName} SET <values> WHERE {IdentificatorName} = ";
    //    }

    //    protected abstract T ConvetFromReader(SqlDataReader reader);
    //    protected abstract Dictionary<string, dynamic?> ConvertToParameters(T item);
    //    public List<T> Select()
    //    {
    //        var result = new List<T>();
    //        using (var connection = new SqlConnection(_connectionString))
    //        {
    //            connection.Open();   // открываем подключение

    //            SqlCommand command = new SqlCommand(_selectCommand, connection);
    //            using (var reader = command.ExecuteReader())
    //            {

    //                if (reader.HasRows)
    //                {
    //                    while (reader.Read())
    //                    {
    //                        result.Add(this.ConvetFromReader(reader));
    //                    }

    //                }
    //            }
    //        }
    //        return result;
    //    }

    //    public T? Get(int Id)
    //    {

    //        using (var connection = new SqlConnection(_connectionString))
    //        {
    //            connection.Open();   // открываем подключение

    //            SqlCommand command = new SqlCommand(_selectCommand + $" WHERE {IdentificatorName} = {Id}", connection);
    //            using (var reader = command.ExecuteReader())
    //            {

    //                if (reader.HasRows)
    //                {
    //                    reader.Read();
    //                    return this.ConvetFromReader(reader);
    //                }
    //            }
    //        }
    //        return null;
    //    }

    //    public int Insert(T item)
    //    {
    //        using (var connection = new SqlConnection(_connectionString))
    //        {
    //            connection.Open();   // открываем подключение


    //            var parameters = this.ConvertToParameters(item);
    //            var values = "";
    //            foreach (var key in parameters.Keys)
    //                values += key + ",";
    //            values = values.TrimEnd(',');

    //            SqlCommand command = new SqlCommand(_insertCommand.Replace("<values>", values), connection);
    //            foreach (var parameter in parameters)
    //            {
    //                command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
    //            }
    //            return Convert.ToInt32(command.ExecuteScalar());
    //        }
    //    }

    //    public void Delete(int id)
    //    {
    //        using (var connection = new SqlConnection(_connectionString))
    //        {
    //            connection.Open();   // открываем подключение

    //            SqlCommand command = new SqlCommand(_deleteCommand + id, connection);
    //            command.ExecuteNonQuery();
    //        }
    //    }

    //    public void Update(T item)
    //    {
    //        using (var connection = new SqlConnection(_connectionString))
    //        {
    //            connection.Open();   // открываем подключение

    //            var parameters = this.ConvertToParameters(item);
    //            var values = "";
    //            foreach (var param in parameters)
    //            {
    //                values += $"{param.Key.Replace("@", "")} = '{param.Value}',";
    //            }
    //            values = values.TrimEnd(',');

    //            SqlCommand command = new SqlCommand(_updateCommand.Replace("<values>", values) + item.Id, connection);
    //            command.ExecuteNonQuery();
    //        }

    //    }

    //}

    public static class BasicExtensions
    {
        public static string TrimEnd(this string source, string value)
        {
            if (!source.EndsWith(value))
                return source;

            return source.Remove(source.LastIndexOf(value));
        }
    }
    public abstract class BaseRepository<T> where T : Basess, new()
    {
        private readonly string _connectionString = "";

        protected readonly string _selectCommand;
        protected readonly string _insertCommand;
        protected readonly string _deleteCommand;
        protected readonly string _updateCommand;

        protected abstract string TableName { get; }
        protected virtual string IdentificatorName => "Id";
        public BaseRepository(string connectionString)
        {
            _connectionString = connectionString;

            _selectCommand = $"SELECT * FROM {TableName}";
            _insertCommand = $"INSERT INTO {TableName} (<keys>) VALUES(<values>) SELECT SCOPE_IDENTITY()";
            _deleteCommand = $"DELETE FROM {TableName} WHERE {IdentificatorName} = ";
            _updateCommand = $"UPDATE {TableName} SET <values> WHERE {IdentificatorName} = ";
        }

        protected abstract T ConvetFromReader(SqlDataReader reader);
        protected abstract Dictionary<string, dynamic?> ConvertToParameters(T item);
        private Dictionary<string, dynamic> GetParameters(T item) =>
            this.ConvertToParameters(item).Where(x => x.Value != null).ToDictionary(x => x.Key, x => x.Value!);

        private string? GetParametersFromFilter(T? filterItem)
        {
            if (filterItem == null) return null;
            var parameters = this.GetParameters(filterItem);
            //var result = "";

            var result = string.Join(" AND ", parameters.Keys.Where(x => parameters[x] != null)
                .Select(x => $"{x} = {parameters[x]}")).TrimEnd(" AND").Trim();

            /*foreach (var parameter in parameters)
            {
                if (parameter.Value != null)
                    result += $"{parameter.Key.Replace("@", "")} = {parameter.Value} AND ";
            }*/
            if (string.IsNullOrEmpty(result)) return null;
            return $" WHERE {result}";
        }
        public List<T> Select(T? filterItem = null)
        {
            var result = new List<T>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();   // открываем подключение

                var comText = _selectCommand + GetParametersFromFilter(filterItem);

                SqlCommand command = new SqlCommand(_selectCommand, connection);
                using (var reader = command.ExecuteReader())
                {

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(this.ConvetFromReader(reader));
                        }

                    }
                }
            }
            return result;
        }

        public T? Get(int Id)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();   // открываем подключение

                SqlCommand command = new SqlCommand(_selectCommand + $" WHERE {IdentificatorName} = {Id}", connection);
                using (var reader = command.ExecuteReader())
                {

                    if (reader.HasRows)
                    {
                        reader.Read();
                        return this.ConvetFromReader(reader);
                    }
                }
            }
            return null;
        }

        public int Insert(T item)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();   // открываем подключение


                var parameters = this.GetParameters(item);
                /*var values = "";
                foreach (var key in parameters.Keys)
                    values += key + ",";
                values = values.TrimEnd(',');*/
                var values = string.Join(",", parameters.Keys.Select(x => $"@{x}")).TrimEnd(',');
                var keys = string.Join(",", parameters.Keys.Select(x => $"[{x}]")).TrimEnd(',');

                SqlCommand command = new SqlCommand(_insertCommand.Replace("<keys>", keys).Replace("<values>", values), connection);
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(new SqlParameter($"@{parameter.Key}", parameter.Value));
                }
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();   // открываем подключение

                SqlCommand command = new SqlCommand(_deleteCommand + id, connection);
                command.ExecuteNonQuery();
            }
        }

        public void Update(T item)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();   // открываем подключение

                var parameters = this.GetParameters(item);
                var values = string.Join(",", parameters.Keys.Where(x => x != "Id").Select(x => $"{x} = '{parameters[x]}'")).TrimEnd(',');
                /*var values = "";
                foreach (var param in parameters)
                {
                    values += $"{param.Key.Replace("@", "")} = '{param.Value}',";
                }
                values = values.TrimEnd(',');*/

                SqlCommand command = new SqlCommand(_updateCommand.Replace("<values>", values) + item.Id, connection);
                command.ExecuteNonQuery();
            }

        }
    }
}
