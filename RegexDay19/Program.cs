// See https://aka.ms/new-console-template for more information
using RegexDay19;

Console.WriteLine("Hello, World!");
RegexUC obj = new RegexUC();
Console.WriteLine(obj.validateFirstName("Milan"));
Console.WriteLine(obj.validateLastName("Biranwar"));
Console.WriteLine(obj.validateEmail("abc.xyz@bl.co.in"));
Console.WriteLine(obj.validateMobileNumber("91 9919819801"));
Console.WriteLine(obj.validatePassword("MILANbiranwar"));
Console.WriteLine(obj.validatePassword6("MilanBHGYUIiranwar"));
Console.WriteLine(obj.validatePassword7("Milanbiranwar123"));
Console.WriteLine(obj.validatePassword8("Milanbiranwar123@"));
Console.WriteLine(obj.validateEmail9("abc@yahoo.com"));



