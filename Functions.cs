using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsOnRandomPeopleDataset
{
    public static class Functions
    {
        public static List<Person> LoadPeopleFromCsv(string filePath)
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true,
                EnforceCsvColumnAttribute = true,
            };

            return cc.Read<Person>(filePath, inputFileDescription).ToList();
        }

        public static double CalculateAverageAge(IEnumerable<Person> people)
        {
            return people.Average(p => p.Age);
        }

        public static List<Person> FilterPeopleByWeight(IEnumerable<Person> people, int minWeight, int maxWeight)
        {
            return people.Where(p => p.Weight >= minWeight && p.Weight <= maxWeight).ToList();
        }
    }
}
