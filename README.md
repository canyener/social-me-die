![.NET Core](https://github.com/canyener/social-me-die/workflows/.NET%20Core/badge.svg)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/canyener/social-me-die?label=latest-release)
![GitHub](https://img.shields.io/github/license/canyener/social-me-die)
# social-me-die
A social media experiment with .net core, react and mobx

# build and run
- Restore dependencies first, by `dotnet restore`
- To build, run `dotnet build` command on terminal.
- To run project,
  - run `dotnet run -p API/`. 
  - or navigate to API directory by `cd API/` and run `dotnet run` command.
- To run in watch mode
  - You must navigate to API directory by `cd API/` to be able to use watch mode.
  - run `dotnet watch run` in API directory.

# Ef Core
- To install globally (which I recommend), type `dotnet tool install -g dotnet-ef` on your terminal.
- Simply run `dotnet ef` to see options and commands you can use.
