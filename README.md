# roga-company-home-work
# Random People Dataset Analysis

## Project Overview
This project involves creating and analyzing a dataset of 1000 randomly generated individuals. The dataset includes first name, last name, age, weight (in lbs), and gender. The application performs the following analyses on the dataset:
- Calculates the average age of all individuals.
- Counts the total number of people weighing between 120lbs and 140lbs.
- Determines the average age of individuals weighing between 120lbs and 140lbs.

## Prerequisites
- .NET Core SDK (Version 7.0 or later)
- Visual Studio or a similar IDE that supports C# development
- Basic understanding of C# and console applications

## Setting Up the Project
1. Clone the repository to your local machine.
2. Open the solution file (`*.sln`) in Visual Studio or your preferred IDE.
3. Ensure that all NuGet packages are restored (this should happen automatically).

## Generating the Dataset
The dataset is a CSV file named `people_dataset.csv` generated with the following structure:
```
FirstName,LastName,Age,WeightLbs,Gender
John,Doe,25,135,Male
...
```

## Running the Application
To run the application:
1. Navigate to the project directory in your terminal or command prompt.
2. Execute `dotnet run` to start the application.
3. The application will perform the analyses and display the results in the console.

## Output
The console output will display:
- The average age of all people in the dataset.
- The total number of people with weights between 120lbs and 140lbs.
- The average age of people with weights between 120lbs and 140lbs.

## Contributing
This project is a homework assignment and may not require contributions. However, suggestions for improvements or bug reports are always welcome.
