using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsOnRandomPeopleDataset
{
    using LINQtoCSV;

    public class Person
    {
        [CsvColumn(Name = "FirstName", FieldIndex = 1)]
        public string? FirstName { get; set; }

        [CsvColumn(Name = "LastName", FieldIndex = 2)]
        public string? LastName { get; set; }

        [CsvColumn(Name = "Age", FieldIndex = 3)]
        public int Age { get; set; }

        [CsvColumn(Name = "Weight", FieldIndex = 4)]
        public int Weight { get; set; }

        [CsvColumn(Name = "Gender", FieldIndex = 5, OutputFormat = "G")]
        public Gender Gender { get; set; }
    }

}
