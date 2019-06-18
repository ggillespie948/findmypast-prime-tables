# Findmypast - Prime Tables Coding Exercise
This application takes numeric input(N) from a user and outputs a multiplication table of N prime numbers.
This program is broken down into three specific modules: The prime number generator, the multiplicaiton table output and a CLI to take and validate input in the program.

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
There are 22 unit tests within this project. To run all of the tests and to receive a summary of output and results you can use the following CLI command:

```
 dotnet test
```

*Note: the length of this test may vary on slower machines. One of the stress unit tests generates an array of 50,000,000 prime numbers.*

## What I'm pleased with
- I'm happy that I have created a solution that has found a balance of being both reasonably performant and highly readable.
- I'm happy with the project structure, I feel like the design is loosely coupled and highly cohesive
- I'm happy with my TDD approach during the development of this exercise.

## What I'd do if I had more time
- I'd write better test coverage for the multiplication table output. When writing the intial test I only checked if the method returns true which does not test the actual output of the table. I later went back and corrected this test. To take this a step further I could have even abstracted the console output stream and mocked this when testing so that I could compare console output with expected output to ensure the formatting was functioning correctly.
- I'd write this code exercise in Javascript, the reason for not doing so was my better knowledge of the unit testing frameworks in .net and wanting to show my ability in a very short space of time.
- I'd implement alternative sieve algorithms like the Sieve of Atkin or a concurrency-based segmented sieve and test how much more performant they are compared to this simple sieve. As this sieve is not very performant when it comes to calculating huge sets of primes (50,000,000 primes took > 25 seconds on personal machine.)


