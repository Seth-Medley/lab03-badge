/*
* Name: Seth Medley
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: October 1, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
Random rng = new Random();

////////////////////////////////////////////////////////////////////
///  Part 1: The Name
/// ////////////////////////////////////////////////////////////////
Console.Write($"Full name: ");
string? fullName = Console.ReadLine();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
fullName = fullName.Trim();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string username = firstName[0] + lastName;
string firstNameInitial = Convert.ToString(firstName[0]);
string lastNameInitial = Convert.ToString(lastName[0]);

Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
Console.WriteLine($"Username: {username.ToLower()}");
Console.WriteLine($"Initials: {firstNameInitial.ToUpper()}.{lastNameInitial.ToUpper()}.");
Console.WriteLine($"Letters in last name: {lastName.Length}");
Console.WriteLine();

////////////////////////////////////////////////////////////////////
///  Part 2: The Numbers
/// ////////////////////////////////////////////////////////////////
int studentID = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Locker: {lockerNumber}");
Console.WriteLine();

////////////////////////////////////////////////////////////////////
///  Part 3: The Walk
/// ////////////////////////////////////////////////////////////////
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
Console.WriteLine();
double distance = Math.Sqrt( Math.Pow(classroomX - dormX, 2) + Math.Pow(classroomY - dormY, 2));
Console.WriteLine($"Distance: {Math.Round(distance, 1)} feet");

double totalSecondsDouble = distance / walkingSpeed;
int totalSeconds = (int)totalSecondsDouble;

int walkMinutes = totalSeconds / 60;
int walkSeconds = totalSeconds % 60;
Console.WriteLine($"Walk time: {walkMinutes} minutes {walkSeconds} seconds");
Console.WriteLine();
Console.WriteLine();

////////////////////////////////////////////////////////////////////
///  Part 4: Badge
/// ////////////////////////////////////////////////////////////////
Console.WriteLine("==================================");
Console.WriteLine("        ETSU STUDENT BADGE        ");
Console.WriteLine("==================================");
Console.WriteLine($"{"NAME".PadRight(10)}{fullName.ToUpper()}");
Console.WriteLine($"{"USERNAME".PadRight(10)}{username.ToLower()}");
Console.WriteLine($"{"ID".PadRight(10)}{studentID.ToString() + "-" + studentID % 9}");
Console.WriteLine($"{"LOCKER".PadRight(10)}{lockerNumber.ToString()}");
Console.WriteLine($"{"WALK".PadRight(10)}{walkMinutes} min {walkSeconds} sec");
Console.WriteLine("==================================");