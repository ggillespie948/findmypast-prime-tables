# Findmypast - Prime Tables Coding Exercise
This application takes numeric input(N) from a user and outputs a multiplication table of N prime numbers.
This program is broken down into three specific modules: The prime number generator, the multiplication table output and a CLI to take and validate input in the program.

For this exercise I implemented a simple version of the Sieve of Eratosthenes.

## How to run

### Installation / Setup
First, ensure you have downloaded and installed the **.NET SDK**
- [Windows](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install?initial-os=windows)
- [Linux](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install?initial-os=linux)
- [macOS](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install?initial-os=macos)

After cloning or downloading the project, using the CLI tool of choice for your operating system navigate into the root /PrimeTables folder.

### Running the prime numbers multiplication table program
From this folder you can run the following command to output a multiplication table of N primes, with the number
following the '-n' flag being the desired number of primes to output.

```
 dotnet run --project primetables -n 15
```

### Running the unit tests for the project
There are 29 unit tests within this project. To run all of the tests and to receive a summary of output and results you can use the following CLI command:

```
 dotnet test
```

*Note: the length of this test may vary on slower machines. One of the stress unit tests generates an array of 100,000,000 prime numbers.*



## Performance Tests
From my own testing you can see that this implementation of simple sieve can calculate large numbers of prime numbers
at very fast speed. The real downfall of this approach comes through its memory usage. With the maximum single object size being around 
2GB this algorithm can only produce a list of around 100,000,000 prime numbers due to its reliance on a huge array of sieve flags. Due to the traversal time of the sieve flag array, performance degrades as the sample size increases.

| Sample Size (Primes)    | Execution Time   | Process Memory Usage        |
|:-------------:| :-----:| -----:|
| 50,000 | 11 ms | 8.1MB |
| 1,000,000  |   374 ms | 34.1MB |
| 10,000,000   |    4s 700 ms | 187.9Mb |
| 50,000,000   |    28s 62 ms | 994.6Mb |
| 100,000,000   |   1m 0s 462ms  | ~2Gb |

These test results are self generated using the diagnostic tool available in Visual Studio.


## Test Coverage

### CLI
- Tests giving all edge cases and invalid input parameters

### Prime Number Generator
- Expected output tests for returned values
- Stress tests to measure performance

### Multiplication Output Table
- Expected output tests to view the generated 2d array representation of the console output table


## What I'm pleased with
- I'm happy that I have created a solution that has found a balance of being both reasonably performant and highly readable.
- I'm happy with the project structure, I feel like the design is loosely coupled and cohesive
- I'm happy with my TDD approach during the development of this exercise.


## What I'd do if I had more time
- I'd write better test coverage for the multiplication table output. When writing the initial test I only checked if the method returns true which does not test the actual output of the table. I later went back and corrected this test. To take this a step further I could have even abstracted the console output stream and mocked this when testing so that I could compare console output with expected output to ensure the formatting was functioning correctly.
- I'd write this code exercise in Javascript, the reason for not doing so was my better knowledge of the unit testing frameworks in .net and wanting to show my ability in a very short space of time.
- I'd extract out a "Sieve Helper" class and implement alternative sieve algorithms like the Sieve of Atkin or a segmented sieve and test how much more performant they are when it comes to generating huge sets of prime numbers using a cache-optimised approach.
- I'd further optimise the current simple implementation to become more performant in terms of memory usage.
