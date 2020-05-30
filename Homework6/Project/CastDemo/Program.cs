using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastDemo {
  class Person { }
  class Student : Person { }
  class Teacher : Person { }

  class Program {
    static void Main(string[] args) {
      Person[] persons = new Person[2];
      persons[0] = new Student();
      persons[1] = new Teacher();

      for(int i=0;i<persons.Length;i++) {
        Student s =(Student) persons[i];//会产生异常
      }
      for(int i= 0; i < persons.Length; i++) {
        if (persons[i] is Student) {
          Student s1 = (Student)persons[i];
          //do something.
        }
      }
      for(int i= 0; i < persons.Length; i++) {
        Student s2 = persons[i] as Student;
        if(s2!=null) {
          //do something.
        }
      }

    }
  }
}
