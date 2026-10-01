/*
* Name: Your Full Name
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
Random rng = new Random();
// Part 1: The Name
Console.Write($"What is your name? ");
string? fullName = Console.ReadLine();
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string username = firstName[0] + lastName;
string firstNameInitial = Convert.ToString(firstName[0]);
string lastNameInitial = Convert.ToString(lastName[0]);

Console.WriteLine($"Name: {fullName.ToUpper()}");
Console.WriteLine($"Username: {username.ToLower()}");
Console.WriteLine($"Initials: {firstNameInitial.ToUpper()}.{lastNameInitial.ToUpper()}.");
Console.WriteLine($"Letters in last name: {lastName.Length}");
Console.WriteLine();

// Part 2: The Numbers
int studentID = rng.Next(10000, 1000000);
int lockerNumber = rng.Next(1, 501);
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Locker: {lockerNumber}");
Console.WriteLine();

// Part 3: The Walk
Console.Write("Dorm x: ");
int dormX = Convert.ToInt16(Console.ReadLine());
Console.Write("Dorm y: ");
int dormY = Convert.ToInt16(Console.ReadLine());
// Class X
Console.Write("Class x: ");
int classroomX = Convert.ToInt16(Console.ReadLine());
// Class Y
Console.Write("Class y:  ");
int classroomY = Convert.ToInt16(Console.ReadLine());
// Speed
Console.Write("Walking speed in feet per second: ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt( Math.Pow(classroomX - dormX, 2) + Math.Pow(classroomY - dormY, 2));
Console.WriteLine($"Distance: {Math.Round(distance, 1)} feet");

double totalSecondsDouble = distance / walkingSpeed;
int totalSeconds = (int)totalSecondsDouble;

int walkMinutes = totalSeconds / 60;
int walkSeconds = totalSeconds % 60;
Console.Write($"Walk time: {walkMinutes} minutes and {walkSeconds} seconds ");