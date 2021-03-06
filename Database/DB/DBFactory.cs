﻿using System;

namespace Database
{
    public class DBFactory
    {
        public static IPersonDAO getInstance(string name)
        {
            IPersonDAO ds = null;
            var ext = name.ToUpper();
            switch (ext)
            {
                case "MSSQL":
                    ds = new DS_MSSQL();
                    break;
                case "MYSQL":
                    ds = new DS_MYSQL();
                    break;
                case "MONGODB":
                    ds = new DS_MONGODB();
                    break;
                case "CASSANDRA":
                    ds = new DS_CASSANDRA();
                    break;
                case "NEO4J":
                    ds = new DS_NEO4J();
                    break;
                case "REDIS":
                    ds = new DS_REDIS();
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return ds;
        }
    }
}