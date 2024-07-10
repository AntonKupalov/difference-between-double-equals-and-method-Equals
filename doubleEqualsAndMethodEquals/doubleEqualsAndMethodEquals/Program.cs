//Разница между == и .Equals()
// == сравнивает ссылки 
// .Equals() сравнивает значения 

//Созданим обьекты этого класса 

Person person1 = new Person("Tom");
Person person2 = new Person("Tom");

//Здесь ответ будет False потому чтто ссылки на обьекты в памяти разные  
Console.WriteLine(person1 == person2); //False
//Здесь ответом будет так же False потому что при вызове метода .Equals
//под капотом вызывается метод RefefenceEquals,а он так же как и == сравнивает ссыллки.
//Для того чтобы с помощью .Equals() сравнить значение нам нужно этот метод переопределить в классе нашего обьекта 
Console.WriteLine(person1.Equals(person2));//False


//Так работает метод ReferenceEquals() 
//public static bool ReferenceEquals (Object objA, Object objB) 
//{
//   return objA == objB;
//} 

//А это работает метод Equals() 
//public virtual bool Equals(Object obj)
//{
//    return RuntimeHelpers.Equals(this, obj);
//}

Console.WriteLine();

//Создадим обьекты класса в котором переопределили метод .Equals()
Employee employee = new Employee(400);
Employee employee1 = new Employee(400);

//Так же вернулось False 
Console.WriteLine(employee == employee1);//False
//Здесь уже вернулось True так как вызывался уже переопределнный метод который сравнивает значение 
Console.WriteLine(employee.Equals(employee1));//True

//Создадим класс с помощью которого будем находить разницу 
public class Person
{
    private string _name;
    public Person(string name)
    {
        _name = name;
    }
}

//Создадим класс в котором переопределим метод .Equals()
public class Employee
{
    private int _salary; 

    public Employee(int salary)
    {
        _salary = salary;
    }
    //Переопределение метода 
    public override bool Equals(object obj)
    {
        if (obj is Employee objectType)
        {
            return this._salary == objectType._salary;
        }
        return false;
    }
        
}