using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ecommerce
{
    class Utils
    {
        public static SqlParameter dbProcReturnValue(SqlCommand cmd)
        {
            SqlParameter returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            return returnParameter;
        }

        public static int paramIntValue(SqlParameter intParam)
        {
            return (int)intParam.Value;
        }
    }
}
