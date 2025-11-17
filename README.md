# Backend Introduction

![Sketches from intro](/docs/backend-introduction.excalidraw.png)

## Command shortlist

Run these in your terminal for:

- Generating a new console project

    ```sh
    dotnet new console
    ```

- Running your programm

    ```sh
    dotnet run
    ```

> [!NOTE]
> 
> If you don't get syntax highlighting
>
> 1. Ensure you have the C# Dev Kit extension installed
> 2. Ensure you have a solution file (*.sln) in your project. Usually this is generated, but not always

- Commands for adding a solution manually

    1. Add solution file

        ```sh
        dotnet new sln
        ```
        
    2. Add project to solution

        ```sh
        dotnet sln add <name-of-csproj-file>
        ```

## Notes

Ignore the following files:
- [.envrc](/.envrc)
- [flake.nix](/flake.nix)
- [flake.lock](/flake.lock)

These are for managing various toolchain installation when jumping between various languages (.NET, NodeJS, etc). And not something you need to know or understand now.