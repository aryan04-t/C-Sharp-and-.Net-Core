# Components of .Net Core Platform: 

1. CLI Tools  
    - A set of tools for development and deployment 

2. Roslyn  
    - Language compiler for C# and Visual Basic 

3. CoreFX  
    - Is a set of framework libraries 

4. CoreCLR  
    - A JIT (Just in Time) based CLR (Common Language Runtime) Environment 



# Who is the Code Compiled and Executed by the .Net Core Platform / Framework: 

> Any .Net Application which is written in C#, F#, or Visual Basic, that application is first converted into Intermediate Language (IL) Code by the Compiler  
> IL is a low level language that can be executed by the .Net runtime  
> And when that IL is executed by the .Net runtime, our application basically starts working  



# Note: 

- Roslyn is the C# and Visual Basic based compiler 
- and for F#, there is a F# Compiler (fsc.exe) which is used to compile F# code 
- CoreCLR provides features like: garbage collection, just-in-time compilation, and exception handling 
- CoreFX provides a wide range of libraries for functionalities like I/O, networking and collections 