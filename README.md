# Uninitialized Property Usage in C#

This example demonstrates a common, yet subtle, error in C#: using properties before they've been initialized. While seemingly harmless, uninitialized properties can lead to unexpected behavior or exceptions in certain situations.

## The Problem
In C#, class properties, if not explicitly assigned a value, default to their type's default value (0 for int, null for strings, etc.).  If a property is accessed before it's assigned a value, you'll use this default value, which may not always be apparent or desirable. 

## The Solution
The solution is simple: Always ensure properties are initialized before use, either in the constructor or before any operations that use those properties.