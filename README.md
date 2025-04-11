![Build Status](https://github.com/KenHSo/CIDemo-Kenneth/actions/workflows/build-test.yml/badge.svg)
![Code Coverage](https://img.shields.io/badge/coverage-dynamic-lightgrey?labelColor=grey&color=blue&label=Coverage)
![Version](https://img.shields.io/github/v/tag/KenHSo/CIDemo-Kenneth?label=version)


# Calculator CLI & Library

A C#-based calculator project with:

- Class library (`CalculatorLib`) containing reusable math functions
- Console application (`Calculator`) with interactive menu
- Unit tests with xUnit
- CI/CD pipeline via GitHub Actions
- Platform-specific publishing and NuGet packaging

## Getting Started

```bash
git clone https://github.com/KenHSo/CIDemo-Kenneth.git
cd CIDemo-Kenneth
dotnet build
dotnet run --project ./src/Calculator
```

## Features

Library functions:
- Add, Subtract, Multiply, Divide
- Power, SquareRoot
- Sin, Cos, Tan, Log
- Factorial
- DegreesToRadians, RadiansToDegrees

Console app:
- Menu-based interface
- Input validation
- Result output with error handling

## Tests

```bash
dotnet test ./tests/CIDemoTest
```

## CI/CD

- Build, test, and format on push (main and develop)
- Publish console app for Windows, Linux, and macOS
- Create and upload NuGet package from `CalculatorLib`
- Automatic GitHub Release with changelog on tag
- Slack failure notifications (simulated)

## Releases

Releases are versioned and generated from tags:

```bash
git tag v1.0.1
git push origin v1.0.1
```

Artifacts and release notes are available in the [Releases](https://github.com/KenHSo/CIDemo-Kenneth/releases) tab.

## Weekly assignment at UCL about CI/CD completed by

Kenneth Haagen Sørensen
