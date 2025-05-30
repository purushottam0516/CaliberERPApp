using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber_Components.GlobalVariables
{

    public class KeyValue
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
    public static class ConnectionStrings
    {
        public static List<KeyValue> ConnectionStringList = new();

        public static string GetConnectionString(string key)
        {
            try
            {
                return ConnectionStringList.Single(a => a.Key == key).Value;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
    public static class LoadConnectionStrings
    {
        public static void SetConnectionStr(IConfiguration configuration)
        {
            var connections = configuration.GetSection("ConnectionStrings").GetChildren().AsEnumerable();
            ConnectionStrings.ConnectionStringList = new List<KeyValue>();
            foreach (var obj in connections)
            {
                ConnectionStrings.ConnectionStringList.Add(new KeyValue
                {
                    Key = obj.Key,
                    Value = obj.Value ?? ""
                }
                );
            }
        }
    }
}
