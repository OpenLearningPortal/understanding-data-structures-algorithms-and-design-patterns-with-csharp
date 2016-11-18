
/*
insertion algortihm works as the same implies
you insert the  element to the array at correct the position 
here are ethe steps
    1. look at the first element(if u only have one element it is always sorted :) 
    2.look at the first two elements
    3.insert the second element at the corrct position (sorting order) .so if second element is lower,then it has to come before the first element
    4.now look at the first 3 elements.as you know the first two elements are already in order.so if third element is higher than the second element
    we dont have to look at the first element as it is lower than that.
    5.repeat this procesdure and you will end up with elements in the sorted order :) 
*/
public class InsertionSort:ISort
{
    public void Sort(int[] A)
    {
        int tmp;
        //loop through all the elements
        /*
        
        1,3,2,6,3,3,3,7
        
        */
        for(int i=1;i<A.Length-1;i++)
        {
            int k=i;
            tmp=A[i];
            //check the elements
            while(k>0 && A[i]<A[k-1])
            { 
                A[k]=A[k+1];
                k--;     
            }
            A[k]=tmp;
        }
    }
}