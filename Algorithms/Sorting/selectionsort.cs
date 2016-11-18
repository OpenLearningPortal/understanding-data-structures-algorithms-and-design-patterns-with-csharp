
//Selectionsort is an easy way to sort and understand
/*
SelectionSort works like this 
    1. in an Array find the first minmum element
    2.swap this minimum element with the first element of the Array
    3.now find the minimum of the rmaining elements(we have to find minimum from 2nd to Last elements)
    4.Now swap this element at the second position of the array
    5.Repeat this process till the end of the array 
*/
public class SelectionSort:ISort
{
    public void Sort(int[] A)
    {
        //this variable will hold the minimum element index
        int iMin,temp;
        for(int i=0;i<A.Length-1;i++)
        {
            //first consider the minimum element's index as first element
            iMin=i;
            //loop through each item in the array
            for(int k=i;k<A.Length-1;k++)
            {
                //if we find any element less than the first element
                //get that element's index 
                if(A[k]<A[iMin])
                    iMin=k;
            }
            //swap the min with the ith element
            temp=A[i];
            A[i]=A[iMin];
            A[iMin]=temp;
        }
        

    }
}
