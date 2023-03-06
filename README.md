# Simple Payroll Software 

## Overview
this is a C# console application that generates payroll slips and salary information for a small company.

The idea and general guidelines for this project is from the last section of the book *Learn C# in one day and learn it well* by Jamie Chan, but I've made changes of my own.

## Company Payroll requirements - Staff, Admin, Manager
The company contains 3 types of staff members. Ordinary staff members, Managers, and Administrators. All staff members have their names in the payroll system and are paid hourly wages. 

Ordinary staff members will be paid $20 an hour, with no eligibility for overtime or any bonuses.

Administrators will be paid $30 an hour and are eligible for overtime, gaining them an extra $15 an hour (time and a half) when they work past 160 hours a month. Administrators do not have any bonuses.

Managers will be paid $50 an hour and do not make overtime pay, but instead are granted a $1000 bonus when they work past 160 hours a month.

To reflect these requirements in the program, there are 3 classes to represent staff, called "Staff", "Admin", and "Manager". Since managers and administrators are staff members just like ordinary staff members, it's a good idea to have "Manager" and "Admin" classes inherit functionality from the "Staff" class.

![screenshot showing declaration of staff class](Images/Staff%20signature.PNG)
![screenshot showing declaration of Admin class](Images/Admin%20signature.PNG)

![screenshot showing declaration of Manager class](Images/Manager%20signature.PNG)


Since all staff members have an hourly rate, but the value for this hourly rate depends on what kind of staff member is instantiated, all staff members share the same "hourlyRate" field and the constructor of the class is responsible for initializing the field with the right value. 

![screenshot showing constructor of Staff class](Images/Staff%20constructor.PNG)
![screenshot showing constructor of Admin class](Images/Admin%20constructor.PNG)
![screenshot showing constructor of Manager class](Images/Manager%20constructor.PNG)

Furthermore, since the child classes are accessing the field "hourlyRate" declared in a parent class, the field has the "protected" access modifier.

![screenshot showing hourlyRate field](Images/hourlyRate%20declaration.PNG)

## Gathering Staff Information - FileReader class 
The company could have any number of staff members and this number can change quickly. Instead of hardcoding the information of each staff member, it's a much better idea to have the names and staff positions of each staff member in a text file. The FileReader class will read this text file to gather the staff information for the rest of the program to use. This information will be returned as a list of the staff members in the company.

![Screenshot of FileReader Class](Images/FileReader%20class.PNG)

The data input text file is "Staff.txt" and has the following format:

![screenshot of staff.txt](Images/staff%20input%20file.PNG)

## Generating the Pay Cheque - PayCheque class
The program needs to be able to generate and send out pay cheques, and it is the job of the PayCheque class to generate the pay cheque of every staff member in the form of a .txt file. For example, If there is a staff member named Joel, his pay cheque will be contained in Joel.txt.

![Image of a staff pay cheque](Images/pay%20cheque%201.PNG)
![Image of a Admin pay cheque](Images/pay%20cheque%202.PNG)
![Image of a Manager pay cheque](Images/pay%20cheque%203.PNG)

## Running the Program
Although C#10 and .NET 6 remove the need for an explicitly defined Main() method, I still added one just to keep things clean and organized (at least to me). The Main() method will be responsible for taking user input for the pay month, pay year, hours worked, etc. to generate the pay cheque information. The method takes input using a while loop so it will repeatedly prompt the user until valid values are given.

![Looping code screenshot](images/while%20loop%20input.PNG)
