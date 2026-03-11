using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

namespace OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01

            #region Q1
            // Abstraction is the process of exposing only what the user needs and hiding how it is implemented

            // Abstraction -> focuses on what the object does
            // Encapsulation -> focuses on protecting the data and controlling access to it

            // real-word example: Samrtphons
            // abstraction -> when you tap an app to sent meesages or make a call without knowing how the internal software or processor work, the phone only shows the functions you need
            // encapsulation -> the internal data like system fils are hidden and protected insid the OS ,users can't access or modify them directly 
            #endregion
            #region Q2
            // 1- inheritance :
            // a class can implement multiple interfaces , but can inherit from only one abstract class

            // 2- implementation:
            // abstract Class can contain both implemented methods and abstract methods , but
            // interface can contains only method declarations

            // 3- fields and constructors:
            // abstract calss can have fields and constructors ,but,interface  can't have constructors or normal fields

            // 4- purpose:
            // interface represents a capability or behavior, abstract class represent an "is-a hierarchy"

            //  When would you choose one over the other? 
            // use interface when you need loose coupling, extensibility, or multiple inheritance
            // use abstract class when classes share common code or represent the same hierarchy
            #endregion
            #region Q3
            // a) 
            // no , bc this a abstract class it used only as base class for inheritance

            // b)
            // PowerConsumption(): is an abstracts method, has no implementaion in the base class,
            // every child class must by override it and write his own implementaion

            // Status(): is a virtual method, has default implementaion ,
            // child classes can overrid it if they want

            // Label(): is a concrete method , has a complete implementaion and isn't meant be overridden

            // the designer used:
            // abstract -> when every subclass must define it's own behavior
            // virtual -> when subclasses may change the behavior
            //concrete -> when the same behavior works for all subclasses

            // c)
            // it will return "Standby" , bc the Toaster() class doesn't overrid Status() method , so it uses the default implementaion

            #endregion
        #endregion
        }
    }
}
