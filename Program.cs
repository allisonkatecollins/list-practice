using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };

      //1. Add() Jupiter and Saturn at the end of the list.
      planetList.Add("Jupiter");
      planetList.Add("Saturn");

      //2. Create another List that contains that last two planet of our solar system.
      List<string> lastPlanets = new List<string>();
      lastPlanets.Add("Uranus");
      lastPlanets.Add("Neptune");

      //3. Combine the two lists by using AddRange().
      planetList.AddRange(lastPlanets);

      //4. Use Insert() to add Earth, and Venus in the correct order.
      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");

      //5. Use Add() again to add Pluto to the end of the list.
      planetList.Add("Pluto");

      //6. Now that all the planets are in the list, slice the list using GetRange() 
      //in order to extract the rocky planets into a new list called rockyPlanets. 
      //The rocky planets will remain in the original planets list.
      //rocky planets are: Mercury, Venus, Earth, Mars
      string[] rockyPlanets = planetList.GetRange(0, 4).ToArray();
      /* foreach (string planet in rockyPlanets)
      {
        Console.WriteLine($"rocky planets: {planet}");
      } */

      //7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
      planetList.RemoveAt(8);
      /* foreach (string planet in planetList)
      {
        Console.WriteLine($"all planets: {planet}");
      }
 */

//1. Use the following code to create a list of random numbers. Each number will be between 0 and 9.
      Random random = new Random();
      List<int> numbers = new List<int> {
          random.Next(10),
          random.Next(10),
          random.Next(10),
          random.Next(10),
          random.Next(10),
      };
  
  //2. Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
      for(int i=0; i <= numbers.Count - 1; i++){
        Console.WriteLine($"any number[{i}]: {i}");
      }
  //3. Inside the body of the for loop determine if the current loop index is contained inside of the numbers list.
  //Print a message to the console indicating whether the index is in the list.
      for(int i=0; i <= numbers.Count - 1; i++){
        if(numbers.Contains(i)){
          Console.WriteLine($"Numbers list contains {i}");
        } else {
          Console.WriteLine($"Numbers list does not contain {i}");
        }
      }
    }
  }
}
