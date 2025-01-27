Person person = new("erdem","buzluk",30000,26,Department.DepartmentB);
Person cPerson = person.Clone();
cPerson.Age = 27;

Person2 person2 = new("test","test2",200,21,Department2.DepartmentC);
person2.Department2 = Department2.DepartmentB;

interface IPersonCloneable
{
    Person Clone();
}
class Person : IPersonCloneable
{
    public Person(string name, string surname, int salary, short age, Department department)
    {
        Name = name;
        Surname = surname;
        Salary = salary;
        Age = age;
        Department = department;
    }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Salary { get; set; }
    public short Age { get; set; }
    public Department Department { get; set; }

    public Person Clone()
    {
       return (Person)base.MemberwiseClone();
    }
}
enum Department
{
    DepartmentA, DepartmentB, DepartmentC
}


#region 2.Yöntem IClonable built-in
class Person2 : ICloneable
{
    public Person2(string name, string surname, int salary, short age, Department2 department)
    {
        Name = name;
        Surname = surname;
        Salary = salary;
        Age = age;
        Department2 = department;
    }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Salary { get; set; }
    public short Age { get; set; }
    public Department2 Department2 { get; set; }

    object ICloneable.Clone()
    {
        return (Person2)base.MemberwiseClone();
    }
}
enum Department2
{
    DepartmentA, DepartmentB, DepartmentC
}
#endregion