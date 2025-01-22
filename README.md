# TrumpfMetamation\_Task1

## Overview

This project automates file handling tasks using C# and the FlaUI library. The automation simulates opening File Explorer, creating a folder and a text file, writing content to the file, verifying the content, and finally deleting the file and folder.

## Prerequisites

To successfully run this project, ensure you have the following tools and software installed:

### 1. **.NET SDK**

- Download and install the [.NET SDK](https://dotnet.microsoft.com/download/dotnet) (version 6.0 or higher).
- Verify the installation by running:
  ```bash
  dotnet --version
  ```

### 2. **Visual Studio**

- Install [Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/) or higher.
- During installation, select the following workloads:
  - **.NET Desktop Development**
  - **.NET Core Cross-Platform Development**

### 3. **FlaUI Library**

- FlaUI is a library for UI automation. It's installed using NuGet packages.

### 4. **NuGet Packages**

The following NuGet packages are required:

- `FlaUI.Core`
- `FlaUI.UIA3`
- `NUnit`
- `Microsoft.NET.Test.Sdk`

You can add these by running:

```bash
dotnet add package FlaUI.Core
dotnet add package FlaUI.UIA3
dotnet add package NUnit
dotnet add package Microsoft.NET.Test.Sdk
```

## Steps to Install and Run the Project

### 1. Clone the Repository

Clone this repository to your local system:

```bash
git clone <repository-url>
cd TrumpfMetamation_Task1
```

### 2. Restore Dependencies

Restore the required NuGet packages:

```bash
dotnet restore
```

### 3. Build the Project

Build the project to ensure everything is set up correctly:

```bash
dotnet build
```

### 4. Run the Automation

Execute the tests using:

```bash
dotnet test
```

The tests simulate the task steps and validate that each action is performed as expected.

## Tools Used

1. **C#**: Programming language for automation.
2. **FlaUI**: Library to automate interactions with the Windows UI.
3. **NUnit**: Testing framework for writing and running automated tests.
4. **Visual Studio**: Integrated Development Environment (IDE) for C# development.
5. **Git**: Version control system for managing the repository.

## Task Workflow

1. **Open File Explorer**: Simulated using FlaUI's automation capabilities.
2. **Create a Folder**: Create a folder named `TrumpfMetamation` using `Ctrl + Shift + N` or programmatically.
3. **Create a File**: Create a `Welcome.txt` file inside the folder.
4. **Write Content**: Write "Welcome to Trumpf Metamation!" to the file.
5. **Verify Content**: Read and assert the content matches the expected text.
6. **Delete the File and Folder**: Clean up by deleting the file and folder.
7. **Validation**: Ensure the file and folder have been deleted successfully.

## File Structure

```
TrumpfMetamation\_Task1/
├── Task1Automation.cs                 # Automation code
├── TrumpfMetamation_Task1.csproj      # Project configuration
├── README.md                          # Documentation file
└── bin/                               # Output binaries (created after build)
```

## Notes

- FlaUI uses UI Automation APIs, so ensure your Windows environment supports these features.
- Run the automation on a Windows machine.

## Troubleshooting

1. **Error: Missing .NET SDK**: Ensure the .NET SDK is installed and added to the system PATH.
2. **Error: Missing Dependencies**: Run `dotnet restore` to install NuGet packages.
3. **Environment Issues**: Run the automation on a Windows machine to ensure compatibility with File Explorer and UI Automation APIs.

## Conclusion

This project demonstrates file handling automation using C#. The tasks are implemented step by step with verification at each stage. By following the steps above, you can successfully run the project and validate the automation.

