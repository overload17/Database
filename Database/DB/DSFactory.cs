using System;
using System.IO;

namespace Database
{
    public class DSFactory
    {
        public static IPersonDAO getInstance(string name)
        {
            IPersonDAO ds = null;
            string ext = name.ToUpper();
            switch (ext)
            {
                case "MSSQL": ds = new DS_MSSQL(); break;
                case "MYSQL": ds = new DS_MYSQL(); break;
                //case "MONGO": ds = new DS_CSV(file); break;
                default: throw new InvalidOperationException();
            }
            return ds;
        }
    }
}
