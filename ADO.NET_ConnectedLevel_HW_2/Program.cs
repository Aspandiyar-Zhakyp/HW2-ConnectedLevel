using ADO.NET_ConnectedLevel_HW_2.Data;
using System;

namespace ADO.NET_ConnectedLevel_HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var gruppa = new GroupDataAccess())
            {
                gruppa.Table();
            }
        }
    }
}
