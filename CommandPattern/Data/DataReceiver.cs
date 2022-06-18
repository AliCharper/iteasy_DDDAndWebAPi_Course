using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Data
{
    public class DataReceiver
    {
        private readonly Dictionary<string, string> data;
        public DataReceiver()
        {
            data = new Dictionary<string, string>();
        }

        public void Upsert(string key, string value)
        {
            data[key] = value;
            Console.WriteLine($"Upserted: {key} - {value}.");
        }

        public void Delete(string key)
        {
            if (data.ContainsKey(key))
            {
                data.Remove(key);
                Console.WriteLine($"Removed: {key}.");
            }
        }
    }
}
