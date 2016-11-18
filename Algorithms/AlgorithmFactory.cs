
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
public class AlgorithmFactory
{
    public void Sort(int[] array)
    {
        ISort sortAlgo=new SelectionSort();
        sortAlgo.Sort(array);

    }
}
//YOU JUST LEARNED A DESIGN PATTERN OR TWO :)