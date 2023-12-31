using Microsoft.Extensions.Configuration;
using StatisticsOnRandomPeopleDataset;

var FILEPATH = "../../../random_people_dataset.csv";

try
{
    var people = Functions.LoadPeopleFromCsv(FILEPATH);

    double averageAge = Functions.CalculateAverageAge(people);
    Console.WriteLine($"Average Age: {averageAge}");

    var peopleInWeightRange = Functions.FilterPeopleByWeight(people, 120, 140);
    Console.WriteLine($"Total Number of People Weighing Between 120lbs and 140lbs: {peopleInWeightRange.Count}");

    double averageAgeInWeightRange = Functions.CalculateAverageAge(peopleInWeightRange);
    Console.WriteLine($"Average Age of People Weighing Between 120lbs and 140lbs: {averageAgeInWeightRange}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: File not found - {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

