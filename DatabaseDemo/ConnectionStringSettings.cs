using System.Collections.Generic;
using System.Linq;
using LinqToDB.Configuration;

namespace DatabaseDemo
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class Linq2DbSettings : ILinqToDBSettings
    {
        public string StrConnectionStrings;

        public Linq2DbSettings(string connectionStrings)
        {
            StrConnectionStrings = connectionStrings;
        }

        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "DbConn";
        public string DefaultDataProvider => "Npgsql";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "DbConn",
                        ProviderName = "Npgsql",
                        ConnectionString = StrConnectionStrings
                    };
            }
        }
    }
}