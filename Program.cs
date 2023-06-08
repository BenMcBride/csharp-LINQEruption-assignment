#pragma warning disable CS8600
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
// Task 1
// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption firstChileEruption = eruptions.FirstOrDefault(c => c.Location == "Chile");
Console.WriteLine(firstChileEruption?.ToString() + "First Eruption in Chile.");
// Task 2
// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption firstHawaiiEruption = eruptions.FirstOrDefault(c => c.Location == "Hawaiian Is");
Console.WriteLine(firstHawaiiEruption?.ToString() + "First Eruption in Chile." ?? "No Hawaiian Is Eruption found.");
// Task 3
// Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."
Eruption firstGreenlandEruption = eruptions.FirstOrDefault(c => c.Location == "Greenland");
Console.WriteLine(firstGreenlandEruption?.ToString() + "First eruption in Greenland." ?? "No Greenland eruption found.");
// Task 4
// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption firstNewZealandEruption = eruptions.FirstOrDefault(c => c.Location == "New Zealand" && c.Year > 1900);
Console.WriteLine(firstNewZealandEruption?.ToString() + "First Eruption in New Zealand after 1900.");
// Task 5
// Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> highElevationEruptions = eruptions.Where(c => c.ElevationInMeters > 2000);
PrintEach(highElevationEruptions, "Eruptions with elevation over 2000m.");
// Task 6
// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> eruptionsStartingWithL = eruptions.Where(c => c.Volcano.StartsWith("L"));
PrintEach(eruptionsStartingWithL, " Eruptions with volcano names starting with 'L'.");
Console.WriteLine("Number of eruptions starting with 'L': " + eruptionsStartingWithL.Count());
// Task 7
// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max(c => c.ElevationInMeters);
Console.WriteLine("Highest elevation: " + highestElevation);
// Task 8
// Use the highest elevation variable to find and print the name of the Volcano with that elevation.
Eruption volcanoWithHighestElevation = eruptions.FirstOrDefault(c => c.ElevationInMeters == highestElevation);
Console.WriteLine("Volcano with highest elevation: " + volcanoWithHighestElevation?.Volcano);
// Task 9
// Print all Volcano names alphabetically.
IEnumerable<string> sortedVolcanoNames = eruptions.OrderBy(c => c.Volcano).Select(c => c.Volcano);
Console.WriteLine("Volcano names alphabetically:");
foreach (string name in sortedVolcanoNames)
{
  Console.WriteLine(name);
}
// Task 10
// Print the sum of all the elevations of the volcanoes combined.
int sumOfElevations = eruptions.Sum(c => c.ElevationInMeters);
Console.WriteLine("Sum of all elevations: " + sumOfElevations);
// Task 11
// Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)
bool anyEruptionsIn2000 = eruptions.Any(c => c.Year == 2000);
Console.WriteLine("Did any eruptions happen in the year 2000? " + (anyEruptionsIn2000 ? "Yes" : "No"));
// Task 12
// Find all stratovolcanoes and print just the first three (Hint: look up Take)
IEnumerable<Eruption> firstThreeStratovolcanoes = eruptions.Where(c => c.Type == "Stratovolcano").Take(3);
PrintEach(firstThreeStratovolcanoes, "First three stratovolcano eruptions.");
// Task 13
// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> eruptionsBefore1000 = eruptions.Where(c => c.Year < 1000).OrderBy(c => c.Volcano);
PrintEach(eruptionsBefore1000, "Eruptions before the year 1000 CE alphabetically by volcano name.");
// Task 14
// Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
IEnumerable<string> volcanoNamesBefore1000 = eruptionsBefore1000.Select(c => c.Volcano);
Console.WriteLine("\nVolcano names before the year 1000 CE:");
foreach (string volcanoName in volcanoNamesBefore1000)
{
  Console.WriteLine(volcanoName);
}
// Task 15
// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
  Console.WriteLine("\n" + msg);
  foreach (Eruption item in items)
  {
    Console.WriteLine(item.Volcano);
  }
}
