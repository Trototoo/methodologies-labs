# methodologies-labs

[![.NET](https://github.com/Trototoo/methodologies-labs/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Trototoo/methodologies-labs/actions/workflows/dotnet.yml)

## Custom List

An application where I create CustomList class that can store any type of data, has variety of methods to access and change data inside it. In the final realization it is One Way Linked Ring List created using custom Node class.
My variant is 1222 mod 4 = 2
First realization was made using List class from C# and second realization was made using custom Node class.

**Link to commit on which tests faile**
https://github.com/Trototoo/methodologies-labs/commit/61b7e4f29e8eb7b988c001e66740b2d39d04e6d3

Conclusion: Tests really helped me, because when I wrote those function I didn't include some situation while doing them, but when I focused only on imagining this situation I found that some of my functions were failing them. And after fixing those issues I pushed fixed functions to my repo. 

# Instruction, how run .NET project

- Open a command prompt or terminal and navigate to the project directory. Ensure that you have .NET Core runtime and SDK installed on your machine.

- Clean the project by running the following command.

`dotnet clean`

This command will remove the executable and other build artifacts from the previous build.

- Restore the project dependencies by running the following command.

`dotnet restore`

This command will download and restore the dependencies specified in the project"s .csproj file.

- Build the project by running the following command.
    
`dotnet build`

This command will build the project and create the executable file.

- Run the project by running the following command.
    
`dotnet run`

This command will run the project and execute the entry point of the application. If the entry point is not specified in the project file, this command will not execute anything.
