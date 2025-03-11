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

## คุณสมบัติ (Features)
- เพิ่มและแสดงรายละเอียดของนักศึกษา
- กำหนดอาจารย์ที่ปรึกษาให้กับนักศึกษา
- แสดงนักศึกษาที่มีเกรดสูงสุด
- จัดการรายชื่ออาจารย์ที่ปรึกษาแบบไดนามิก



