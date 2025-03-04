// fields and properties
// what is the field ? << is a variable that is decalred directly in a class

/*class Person
{
    private string _name;  // {1} declaring a field in a class

    *//*public void Whome()
    {
        this._name = "john"; // so the this here is just saying selecting field from this class
    }*//*
}*/


/*// {2}intialise the field inside the class
//also we can intialise the field inside the class
class person2
{
    //private access modifier specifies that something accessible only within the class
    private string _name = "koko";
}*/


//person3 p3 = new person3();

/*Console.WriteLine(p3._name); // if we try here to print the name koko will give use
                             // "'person3._name' is inaccessible due to its protection level"*/

/*Console.WriteLine($"enter new name and the name now is --> {p3.Getname()}");

string NewName = Console.ReadLine();
p3.setname(NewName);
Console.WriteLine($"so this the new name --> {p3.Getname()}");*/

//writng classes using getter and setter in another way


person4 kokowithproperty = new person4();

Console.WriteLine($"so this from name --> {kokowithproperty.name}");
Console.WriteLine($"so this from Name2 --> {kokowithproperty.Name2}");
//Console.WriteLine($"so this from Name3 --> {kokowithproperty.Name3}");


Console.WriteLine("setting the name");
kokowithproperty.MutableName = "soso with koko";
Console.WriteLine($"name after setting is --> {kokowithproperty.MutableName}");
Console.WriteLine($"so this from Name3 --> {kokowithproperty.Name3}");





class person4
{
    private string _name = "koko";

    //(1)
    public string name
    {
        //this method is for more than one process
        get
        {
            return _name;
        }
    } // instad of all of this 

    //(2)
    public string Name2 => _name;
    //(3)
    public string Name3 { get; } = "koko :)"; // and here the only way to access Name3 is from Name3 only
                                           // but the other ways you can access with in all the class
    //(4)
    public string MutableName
    {
        get { return _name; }
        set { _name = value; }
    }
}




//class person3
//{
//    private string _name = "koko";

//    public string Getname()
//    {
//        return _name;
//    }

//    public string setname(string name)
//    { 
//        this._name = name;
//        return _name;
//    }
//}


