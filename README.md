# Test Practice

Notetaking and pracice what I learned from [Mosh Hamedani's Unit Testing for C# Developers](https://www.udemy.com/unit-testing-csharp/).

# Three types of tests
1. Unit test
1. Integration test
1. End-to-end test

# How to install NUnit packages on VisualStudio
1. Open Package Manager Console
1. `Install-Package NUnit -Version 3.8.1`
1. `Install-Package NUnit3TestAdapter -Version 3.8.0`

# The Foundation of TDD(Test-driven Development)
1. Write a failing test.
1. Write the simplest code to make the test pass.
1. Refactor it necessary.

# Benefits of TDD
1. Your source code will be testable right from the get go; You don't have to make changes to your code to make it testable.
1. Every line of your production code is fully covered by tests; You can refactor and deploy with confidence.
1. It often results in a simpler implementation; Lower the change of over-engineering.

# Conditions for Good Unit Tests
1. First-class citizens
1. Clean, readable and maintainable (Less than 10 lines of codes)
1. No logic
1. Isolated (as if it's the only test in the world)
1. Not too specific/general

# Two Types of Functions
1. Query
1. Command

# Don't Test
1. Language features
1. 3rd-party code

So, only test your codes.

# Test methods naming convention
- [MethodName]_[Scenario]_[ExpectedBehaviour]

# Cost of a Software Bug
1. Found in **Requirements Gathering** is $100
1. Found in **QA Testing** is $1,500
1. Found in **Production** is $10,000

The later we catch bugs, the more costly it gets to fix them.

