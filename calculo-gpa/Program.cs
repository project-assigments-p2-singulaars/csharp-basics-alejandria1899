// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string nameStudent = "Sophia Johnson";

string course1 = "English 101";
string course2 = "Algebra 101";
string course3 = "Biology 101";
string course4 = "Computer Science I";
string course5 = "Psuchology 101";

int courseCredit1 = 3;
int courseCredit2 = 3;
int courseCredit3 = 4;
int courseCredit4 = 4;
int courseCredit5 = 3;

int gradeA = 4;
int gradeB = 3;

int gradeCourse1 = gradeA;
int gradeCourse2 = gradeB;
int gradeCourse3 = gradeB;
int gradeCourse4 = gradeB;
int gradeCourse5 = gradeA;

int totalCreditHours = 0;

totalCreditHours += courseCredit1;
totalCreditHours += courseCredit2;
totalCreditHours += courseCredit3;
totalCreditHours += courseCredit4;
totalCreditHours += courseCredit5;

int totalGradePoints = 0;

totalGradePoints += courseCredit1 * gradeCourse1;
totalGradePoints += courseCredit2 * gradeCourse2;
totalGradePoints += courseCredit3 * gradeCourse3;
totalGradePoints += courseCredit4 * gradeCourse4;
totalGradePoints += courseCredit5 * gradeCourse5;

Console.WriteLine($"{totalCreditHours} {totalGradePoints}");



float gradePointAverage = (float) totalGradePoints / totalCreditHours;

gradePointAverage = (float)Math.Round(gradePointAverage, 3);

// int leadingDigit = (int) gradePointAverage;
// int firstDigit = (int) (gradePointAverage * 10) % 10;
// int secondDigit = (int) (gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {nameStudent}");
Console.WriteLine("\nCourse\t\t\tGrade\tCredit hours");
Console.WriteLine($"{course1}\t\t{gradeCourse1}\t{courseCredit1}");
Console.WriteLine($"{course2}\t\t{gradeCourse2}\t{courseCredit2}");
Console.WriteLine($"{course3}\t\t{gradeCourse3}\t{courseCredit3}");
Console.WriteLine($"{course4}\t{gradeCourse4}\t{courseCredit4}");
Console.WriteLine($"{course5}\t\t{gradeCourse5}\t{courseCredit5}");
Console.WriteLine($"\nFinal GPA:\t\t{gradePointAverage}");
