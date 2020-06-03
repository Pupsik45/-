using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Инвентаризация_на_предприятии
{
     public class DB
    {
        public List<Tovar> tovars = new List<Tovar>();
        public List<User> users = new List<User>();
        static BinaryFormatter BF = new BinaryFormatter();
        public DB()
        {
            if (!File.Exists("db.db"))
                return;
            using (FileStream fs = new FileStream("db.db", FileMode.Open, FileAccess.Read))
            {
                users = ((List<User>)BF.Deserialize(fs));
                tovars = ((List<Tovar>)BF.Deserialize(fs));
            }
        }
        public void Save()
        {
            using (FileStream fs = new FileStream("db.db", FileMode.Create, FileAccess.Write))
            {
                BF.Serialize(fs, users);
                BF.Serialize(fs, tovars);
            }
        }
    }
}
