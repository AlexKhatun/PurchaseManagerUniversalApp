using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess
{
    public class JsonSerializer
    {
        private DataContractJsonSerializer ser;

        public JsonSerializer()
        {
            ser = new DataContractJsonSerializer(typeof(PouchModel));
        }

        public void SerializePouch(PouchModel pouch)
        {
            MemoryStream stream = new MemoryStream();
            ser.WriteObject(stream, pouch);
            stream.Dispose();
        }

        public PouchModel DeserializePouch()
        {
            MemoryStream stream = new MemoryStream();
            return (PouchModel) ser.ReadObject(stream);
        }
    }
}
