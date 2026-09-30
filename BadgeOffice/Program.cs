/*
* Name: Your Full Name
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

// Part 1: The Name
Console.Write($"What is your name? ");
string? fullName = Console.ReadLine();
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string username = firstName[0] + lastName;
char firstNameInitial = firstName[0];
char lastNameInitial = lastName[0];

Console.WriteLine($"Name: {fullName.ToUpper()}");
Console.WriteLine($"Username: {username.ToLower()}");
Console.WriteLine($"Initials: {firstNameInitial}.{lastNameInitial}.");
Console.WriteLine($"Letters in last name: {lastName.Length}");
Console.WriteLine();

// Part 2: The Numbers
Random rng = new Random();

int studentID = rng.Next(10000, 999999);
int lockerNumber = rng.Next(1, 500);
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Locker {lockerNumber}");