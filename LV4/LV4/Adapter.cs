using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class Adapter
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> data = dataset.GetData();
            double[][] convertedData= new double[data.Count][];
            for (int i = 0; i < data.Count; i++)
            {
                convertedData[i] = new double[data[i].Count];
                for(int j = 0; j < data[i].Count; j++)
                {
                    convertedData[i][j] = data[i][j];
                }
            }
            return convertedData;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
