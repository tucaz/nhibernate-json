using NHibernate.SqlTypes;
using NpgsqlTypes;
using System.Data;

namespace NHibernate.Json
{
    public class NpgSqlType : SqlType
    {

        public NpgsqlDbType NpgDbType { get; }

        public NpgSqlType(DbType dbType, NpgsqlDbType npgDbType)
            : base(dbType)
        {
            NpgDbType = npgDbType;
        }

        public NpgSqlType(DbType dbType, NpgsqlDbType npgDbType, int length)
            : base(dbType, length)
        {
            NpgDbType = npgDbType;
        }

        public NpgSqlType(DbType dbType, NpgsqlDbType npgDbType, byte precision, byte scale)
            : base(dbType, precision, scale)
        {
            NpgDbType = npgDbType;
        }

    }
}
