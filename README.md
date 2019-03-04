# Practice: Planet and Spaceships

## Setup

```
mkdir -p ~/workspace/csharp/exercises/lists && cd $_
dotnet new console
```

## Instructions

In the `Main` method, place the following code

```cs
List<string> planetList = new List<string>(){"Mercury", "Mars"};
```

1. `Add()` Jupiter and Saturn at the end of the list.
1. Create another `List` that contains that last two planet of our solar system.
1. Combine the two lists by using `AddRange()`.
1. Use `Insert()` to add Earth, and Venus in the correct order.
1. Use `Add()` again to add Pluto to the end of the list.
1. Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`. The rocky planets will remain in the original planets list.
1. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.

# Practice: Random Numbers


## Instructions
1. Use the following code to create a list of random numbers. Each number will be between 0 and 9.
    ```cs
    Random random = new Random();
    List<int> numbers = new List<int> {
        random.Next(10),
        random.Next(10),
        random.Next(10),
        random.Next(10),
        random.Next(10),
    };
    ```
1. Use a `for` loop to iterate over all numbers between `0` and `numbers.Count - 1`. 
1. Inside the body of the `for` loop determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

#### Example Output in the Terminal
```sh
numbers list contains 0
numbers list does not contain 1
numbers list does not contain 2
numbers list contains 3
numbers list contains 4
```
**NOTE:** Each run will produce different output.
