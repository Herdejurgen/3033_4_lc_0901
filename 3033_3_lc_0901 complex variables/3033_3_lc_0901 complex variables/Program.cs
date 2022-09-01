// Jack Herdejurgen 113436899
// Lecture Code September 1, 2022
// Complex Data Types
// Array, list, dictionary
/*
double _stuWeightDbl; // Simple
// Gets room immediately ^^
_stuWeightDbl = 138; 

double _stuWeightDbl2;

_stuWeightDbl2 = _stuWeightDbl; // Each dbl has own room, copies the value from 1 to 2

string _stuNameStr; // Complex

_stuNameStr = new string("Jack"); // Doesn't get room until assignment
string _stuNameStr3 = "Dawson"; // Automaticallay calls new string() function to create string
string _stuNameStr2;
_stuNameStr2 = _stuNameStr; // 2 keys, share 1 room
*/

Person p1;
p1 = new Person();

Console.ReadLine();

//class NewDataTypeName
//{

//}

Console.WriteLine(p1.GetPersonInfo());

public class Person
{
    public string name;
    public int age;
    public double weight;

    public string GetPersonInfo()
    {
        string personInfoStr = string.Format($"The name is {name}\n The age is {age}\n The weight is {weight}");
        return personInfoStr;
    }
}