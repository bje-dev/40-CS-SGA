﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tools
{
    internal static class SqlHelper
    {
        readonly static string conString;

        static SqlHelper()
        {
            //Configuration Manager llama a a los valores de conexion de App.config - VERIFICAR SIEMPRE EL NOMBRE
            //conString = ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString;
        }
        public static Int32 ExecuteNonQuery(String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                CheckNullables(parameters);

                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect 
                        // type is only for OLE DB.  
                        cmd.CommandType = commandType;
                        cmd.Parameters.AddRange(parameters);



                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void CheckNullables(SqlParameter[] parameters)
        {
            foreach (SqlParameter item in parameters)
            {
                if (item.SqlValue == null)
                {
                    item.SqlValue = DBNull.Value;
                }
            }
        }

        /// <summary>
        /// Set the connection, command, and then execute the command and only return one value.
        /// </summary>
        public static Object ExecuteScalar(String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Set the connection, command, and then execute the command with query and return the reader.
        /// </summary>
        public static SqlDataReader ExecuteReader(String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(conString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                // IDataReader is closed.
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }
    }
}
