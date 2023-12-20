using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project.V15.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.Default);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = line_r[j];
                }
            }
            return arrayValues;
        }
        public int Sum(string path)
        {
            string[,] array = LoadFromFileData(path);
            int rows = array.GetUpperBound(0) + 1;
            int summ = 0;
            for (int i = 0; i < rows; i++)
            {
                summ += Convert.ToInt32(array[i, 5]);
            }
            return summ;
        }

        public int Count(string path)
        {
            string[,] array = LoadFromFileData(path);
            int rows = array.GetUpperBound(0) + 1;
            return rows;
        }
        public double Srednee(string path)
        {
            string[,] array = LoadFromFileData(path);
            int rows = array.GetUpperBound(0) + 1;
            double summ = 0;
            for (int i = 0; i < rows; i++)
            {
                summ += Convert.ToInt32(array[i, 5]);
            }
            return Math.Round((summ / rows), 1);
        }
    }
}

