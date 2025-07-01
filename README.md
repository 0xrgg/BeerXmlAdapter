# BeerXML recipe to JSON adapter

A small utility that can be used to parse BeerXML files or strings into a C# recipe object, with the option of serializing into JSON. 

The standard recipes schema will deserialize perfectly.
Recipes complete with the extensions (display options) should parse correctly, but there are limited examples where they are all in use to confirm.

Enhancements to follow include:
- mapping some object field data types from string to more applicable data types, int, float, enum, etc.
