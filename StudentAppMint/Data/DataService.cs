using Dapper;
using System.Data;

namespace StudentAppMint.Data
{
    public class DataService
    {
        public void ExecWithoutReturn(string procedureName, object? param)
        {
            using (var connection = StartConfig._dbContext.CreateConnection())
            {
                connection.Open();
                connection.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
                connection.Close();
            }
        }
        public T ExecReturnScalar<T>(string procedureName, object? procedureParams)
        {
            using (var connection = StartConfig._dbContext.CreateConnection())
            {
                connection.Open();
                var result = connection.Query<T>(sql: procedureName,
                    param: procedureParams,
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
                connection.Close();
                return result;
            }
        }
        public IEnumerable<T> ExecReturnList<T>(string procedureName, object? param)
        {
            using (var connection = StartConfig._dbContext.CreateConnection())
            {
                connection.Open();
                connection.Close();
                return connection.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
