using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCourse.Utils
{
    public class DB_JSON_TESTS
    {
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string sentence { get; set; }
    }


}

