using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инвентаризация_на_предприятии
{
    [Serializable]
     public class Tovar
    {
        public string Name { get; set; }
        public string Kolihestvo { get; set; }
        public DateTime Data { get; set; }
        public int Number { get; set; }
        public string Availability { get; set; }
    }
}
