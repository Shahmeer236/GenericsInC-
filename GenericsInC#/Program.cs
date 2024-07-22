

//when we talk about c# so it is strict type checking language and it is rich in its datatype
// for example we have a fucntion which contain some value as an parameter so we have to define the
//type of paramerter that is that parameter is string ,float or int but what happen happen when we
//dont know the type of parameter or i want two int and string both so typically we should create 
//two different fucntion or take two different parameter
//so basically generic solved that problem so when we required mysterious (not known type) variable 
//we can use generics so the type of generics is for list <T> ,for dictionary <TKey, TValues>

//we can use generics classes with syntax" class xyzClass <T>{} "


//ITS helps us to write reUsable code


using System;
// define a generics class named Student
public class Student<T>
{
    // define a variable of type T 
    public T data;

    // define a constructor of the Student class 
    public Student(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }
}

class Program
{
    static void Main()
    {
        // create an instance with data type string 
        Student<string> studentName = new Student<string>("Avicii");

        // create an instance with data type int
        Student<int> studentId = new Student<int>(23);
    }
}