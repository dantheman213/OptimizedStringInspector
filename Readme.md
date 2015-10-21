# C# Optimized String Inspector #
This is a proof-of-concept project that includes a reusable static class that will allow you to efficiently find the most repeated character(s) in a given body of text such as articles, newspapers, etc.

The class was designed with optimization in mind and can search through millions of lines of text quickly and retrieve the result.

The paradigm used to achieve this result is to assume that all characters and text will be ASCII compliant (reducing all possible permutations) and assigning raw ASCII values to an integer array element index.
