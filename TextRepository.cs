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
        string filePath = "C:/Users/Private/source/repos/PhoneStore/PhoneStore/phones.json";

        public TextRepository()
        {
            ReadFromFile(filePath);
        }

        public TextRepository(string filePath)
        {
            if (new FileInfo(filePath).Length == 0)
                entities = new List<T>();
            else
                ReadFromFile(filePath);
            sync = false;
        }

        void SyncWrite()
        {
            if (sync)
                WriteToFile(filePath);
        }

        void SyncRead()
        {
            if (sync)
            {
                entities.Clear();
                ReadFromFile(filePath);
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

        public void ReadFromFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            this.entities = JsonConvert.DeserializeObject<List<T>>(json);
        }

        public void WriteToFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(entities);
            File.WriteAllText(filePath, json);
        }
    }
}
