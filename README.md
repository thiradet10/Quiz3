## จัดทำโดย
- ชื่อ: นาย ธีรเดช ประสารสุข
- รหัสนักศึกษา:673450195-4

## โครงสร้างโปรแกรม
1. `Student` Class - บันทึกข้อมูลนักศึกษา
2. `Advisor` Class - บันทึกอาจารย์ที่ปรึกษา
3. `main.py` - ทดสอบการทำงานของระบบ

## หลักการ OOP ที่ใช้
✅ **Encapsulation**: ใช้ตัวแปร `__` ป้องกันการแก้ไขค่าจากภายนอก  
✅ **Abstraction**: ซ่อนรายละเอียดการทำงานของคลาส  
✅ **Polymorphism**: ใช้ `getInfo()` ให้ทุกคลาสแสดงข้อมูลในรูปแบบเดียวกัน  
✅ **Inheritance**: (หากมีการเพิ่มคลาสย่อย สามารถใช้การสืบทอดคลาสได้)
 
![image](https://github.com/user-attachments/assets/ef32e88a-e2fd-4ba8-a3ef-1b80e5472670)

# Student-Advisor Management System

This project is a simple Student-Advisor management system using Object-Oriented Programming (OOP) principles such as Encapsulation, Abstraction, Polymorphism, and Inheritance.

## Class Diagram

```mermaid
classDiagram
    class Person {
        +string Name
        +string Major
        +Person(string name, string major)
    }

    class Student {
        +string ID
        +double Grade
        +Advisor Advisor
        +Student(string id, string name, string major, double grade, Advisor advisor)
    }

    class Advisor {
        +List~Student~ Students
        +Advisor(string name, string major)
        +void AddStudent(Student student)
    }

    class Form1 {
        -List~Student~ students
        -List~Advisor~ advisors
        +Form1()
        +void LoadAdvisors()
        +void btn_addStd_Click()
        +void btnShowstd_Click()
        +void UpdateStudentList()
        +void lstStuden_SelectedIndexChanged()
        +void button1_Click()
    }

    Person <|-- Student
    Person <|-- Advisor
    Advisor "1" *-- "many" Student
    Form1 --> Advisor
    Form1 --> Student
```

## Features
- Add and display student details
- Assign advisors to students
- Show the top student based on grades
- Manage advisor list dynamically

## Getting Started
1. Clone the repository
2. Open the project in Visual Studio
3. Run the application and manage student-advisor relationships

## Technologies Used
- C#
- Windows Forms (WinForms)
- Object-Oriented Programming (OOP)

## License
This project is licensed under the MIT License.

