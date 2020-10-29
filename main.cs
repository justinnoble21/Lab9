using System;

class MainClass {

  public static void Main (string[] args) {
    Employee empty = new Employee();
    empty.Intro();

    Employee filled = new Employee("john", "smith", "1234", 45);
    filled.Intro();
  }

}