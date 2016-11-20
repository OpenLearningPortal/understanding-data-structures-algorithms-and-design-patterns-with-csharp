
//we are going to use our first design pattern
//people are gonna confuse you with factory pattern
//I will try to clear this
//mainly there are two factory patterns
//      1.Abstract factory
//      2.Factory Method
//Here we have a class named Algorithm Factory,as the name implies ,this guy is going to 
//produce sorting algorithm for you/
//to be clear ,please don't think that we are going to chose an algorith,we are going to create a factory
//there are other ways to work with algprithm
//there is no hard and fast rule like this should be the way you do it.
//just think about only one thing
// OUR APPLICATION SHOULD BE EXTENSIBLE,MODULARIZED and EASY TO MAINTAIN
//YOU DON"T HAVE TO OVERARCHITECT THE HELL OUT OF ANYTHING :)

//So where were we ??? :)
//coming back to our factory we are going to write a class which should produce different alogrithms for you
//now who are you going to give the control to produce the algorithm
//how are you going to give the control to the guy who is going to use our algorithm
//One way is where he can simple call a specific method to create specifc algorithm
//e.g GiveMeInsertSort,GiveMeSelectionSort or better CreateSelectionSort
//other is specify the algorithm he wants and all the nitty gritty details  and he can mix and match as he wants
//where you see right below
using System;

public class SortProgram
{
    public void Sort(int[] array)
    {
        //here we are using polymorphism where sortAlgo variable can act as any SortingAlgorithm implementation
        ISort sortAlgo=new AlgorithmFactoryMethod().GetAlgorithm();
        //we are calling our sorting algorithm to sort the array.
        sortAlgo.Sort(array);

    }
}
//simplest factory pattern implementation
public class AlgorithmFactoryMethod
{
    public ISort GetAlgorithm()
    {
        //here we are using polymorphism where sortAlgo variable can act as any SortingAlgorithm implementation
        return new MergeSort();
        //notice that with just one line of code change,we can change the Algorithm and this is the easiest thing to  do with 
        //our implementation
        //return new BubbleSort(); can be used if you think BubbleSort is better

    }
}
//YOU JUST LEARNED A DESIGN PATTERN(factory method pattern to be exact) OR TWO :)
//so all in all  an abstract factory is used to create a family of classes
//in our case the family is ISort family


namespace  BasicsOfOOPS
{
//MORE BASICS UNDERSTANDING

//You see that we have ISort interface which is like a contract.

//So anyone wants to implement a sorting algorithm has to adheres to this contract
//So we could have written a base class like 
//our base class 
class SortBase { }

//derived class which implements Sort Function
class SelectionSort:SortBase{}

//what are the advantages of having an interface then ???

//An interface can be used to define a contract and no need to provide implementation
//but classes(whether abstact or not) ,people use to implement some basse logic and then derived classes can use some funcationality
//for e.g. In our case say we have a requirement where the array of numbers passed to us may or may not be valid
//now what will you do?
 //think about it and try to implement it,please do not look at the next section
 //to summarise,our requirement 
//BUILD A SET OF CLASSES WHICH SHOULD PROVIDE A SET OF SORTING ALGORITHMS TO SORT AN ARRAY OF NUMBERS
//THE ARRAY OF NUMBERS MAY OR MAY NOT BE VALID,WE HAVE TO CLEAN UP THE DATA BEFORE SORTING


//now lets revisit our class structures
namespace RevisitDesign
{

//our base class 
public abstract class SortBase 
{ 
//this method can validate the input
private void Validate(int[] arr)
{}
//we have our main sort method which will be called by all consumers(e.g. our AlgorithmFactory )
//this will internally call the SortArray which is where we have implemented our actual sorting logic.
public void Sort(int[] arr)
{
    //we are calling validate inside,this will apply the validate logic to all the derived classes and they only 
    //have to worry about the sorting implementations 
    Validate(arr);
    //we are calling actual implementation
    SortArray(arr);
}
protected abstract void SortArray(int[] arr);

}

        //derived class which implements Sort Function
        class SelectionSort : SortBase
        {
            protected override void SortArray(int[] arr)
            {
                //implement actual sorting here
                throw new NotImplementedException();
            }
        }

//now if you see we have an abstract class which is used to implement some base logic 
//and all the derived classes can inherently use that


//derived class which implements Sort Function
        class BubbleSort : SortBase
        {
            protected override void SortArray(int[] arr)
            {
                //implement actual sorting here
                throw new NotImplementedException();
            }
        }

//NOW LETS MOVE ON TO ACTUAL USAGE OF THESE CLASSES WE HAVE JUST IMPLEMENTED

public class SortProgram
{
    public void Sort(int[] array)
    {
        //here we are using polymorphism where sortAlgo variable can act as any SortingAlgorithm implementation
        SortBase sortAlgo=new AlgorithmAbstractFactory().GetBubbleSort();

        //we are calling our sorting algorithm to sort the array.
        sortAlgo.Sort(array);

    }
}

//simplest abstract factory pattern implementation
public class AlgorithmAbstractFactory
{
    public SortBase GetSelectionSort()
    {
        //here we are using polymorphism where sortAlgo variable can act as any SortingAlgorithm implementation
        return new SelectionSort();
        

    }
    public SortBase GetBubbleSort()
    {
        //here we are using polymorphism where sortAlgo variable can act as any SortingAlgorithm implementation
        return new BubbleSort();
        
    }
    
}
//NOW WE JUST IMPLEMENTED TWO TYPES OF FACTORY patterns
//THE QUESTION IS WHEN TO USE WHAT.IT PURELY BASED ON THE REQUIREMENT

//IF YOU DO NOT WANT TO GIVE EXPLICIT CONTROL OF WHAT KIND OF OBJECTS ARE CREATED,FACTORY METHOD IS A GOOD OPTION.
//WHEN USING ABSTRACT FACTORY,Clients can choose to create specific type of OBJECTS


    }

}