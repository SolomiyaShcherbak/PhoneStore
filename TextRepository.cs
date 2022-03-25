using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhoneStore
{
    public class TextRepository<T> : Repository<T> where T : IDevice
    {
        bool sync = true;
        string sourceFileName = "C:/Users/Private/source/repos/PhoneStore/PhoneStore/phones.json";

        public TextRepository()
        {
            ReadFromFile();
        }

        void SyncWrite()
        {
            if (sync)
                WriteToFile();
        }

        void SyncRead()
        {
            if (sync)
            {
                entities.Clear();
                ReadFromFile();
            }
        }

        public override void Add(T entity)
        {
            base.Add(entity);
            SyncWrite();
        }

        public override void Remove(int idx)
        {
            base.Remove(idx);
            SyncWrite();
        }

        public override void Replace(T entity, int idx)
        {
            base.Replace(entity, idx);
            SyncWrite();
        }

        public override void Print()
        {
            SyncRead();
            base.Print();
        }

        public override void Sort(IComparer<T> comp)
        {
            base.Sort(comp);
            SyncWrite();
        }

        public override T this[int i]
        {
            get
            {
                SyncRead();
                return base[i];
            }
            set
            {
                base[i] = value;
                SyncWrite();
            }
        }

        public void ReadFromFile()
        {
            var json = File.ReadAllText(sourceFileName);
            this.entities = JsonConvert.DeserializeObject<List<T>>(json);
        }

        public void WriteToFile()
        {
            var json = JsonConvert.SerializeObject(entities);
            File.WriteAllText(sourceFileName, json);
        }
    }
}
