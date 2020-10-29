using System;

class Employee {

  public string firstName;
  public string lastName;
  public string id;
  public int age;
  public string address;
  public string phoneNumber;
  public string title;
  public double yearlySalary;
  public string employmentStatus;

  public Employee() {
    this.firstName = "Unknown";
    this.lastName = "Unknown";
    this.id = "Unknown";
    this.age = 0;
    this.employmentStatus = "Active";
  }

  public Employee(string firstName, string lastName, string id, int age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.id = id;
    this.age = age;

    this.employmentStatus = "Active";
  }

  public void Intro() {
    Console.WriteLine("Full Name: " + firstName + " " + lastName);
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Age: " + age);
    Console.WriteLine("Employment Status: " + employmentStatus);
  }

}