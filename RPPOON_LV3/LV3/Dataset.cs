using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Dataset:Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
            new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            Dataset dataCopy =new Dataset();
            for(int i = 0; i< data.Count;i++)
            {
                dataCopy.data.Add(new List<string>(data.Count));
                for (int j=0; j < data[i].Count; j++)
                {
                    dataCopy.data[i].Add(data[i][j]);
                }
            }
            return dataCopy;
        }
    }
}
