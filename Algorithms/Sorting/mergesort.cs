


using System;

//merge sort is a divide and conquer algorithm
// here is the way it works 
//  think we have two sorted arrays
// now all we have to merge the two arrays,isnt it ?
//[1 2 3]  and [4 5 6]
//we can merge these two arrays to  [1 2 3 4 5 6]
//now let's simplify this a bit we have one array which is of 2 elements
// [3 2]
//we can divide this into [3] and [2]. and now we have two arrays of one element each and an array of one element is always sorted,isnt it ?
//now  when we merge these two arrays,we can merge it to  [2 3]
//we will discuss a simply ways to merge later in the MergeArray method
//now you understood that a simply array of two elements can be sorted like this
//  1. divide the array
//  2.merge the array
//now thinkfo a an array of 3 elements
//[3 2 1]
//we will divide this into  [3] and [2 1]
//now we the right side we can again make it into [2] and [1]
//now we can merge the right side to [1 2].
//then go back to [1 2 3] merging []3 and [1 2]. 
//we will acheive this by recursion.
//simple code will be in our method SortImpl
public class MergeSort : ISort
{
    public void Sort(int[] A)
    {
        //calling the helper function
        SortImpl(A,0,A.Length-1);
    }
    //here is our divide and conquer main method
    //here we will split our arrays into half and we go on dividing until it becomes just one element
    private void SortImpl(int[] A,int start,int end)
    {
        if(A.Length<2) return;

        int[] arr=new int[A.Length];
        if(start<end)
        {
            int mid=(start+end)/2;
            int[] left,right;
            
            SortImpl(A,start,mid-1);
            SortImpl(A,mid,end);
            MergeArray(left,right,arr);
        }
        
        
    }

    private void MergeArray(int[] left, int[] right,int [] A)
    {
        int i=0,j=0,k=0;
        

        //int[] arr=new int[right.Length+left.Length];

        while (i<left.Length&&j<right.Length)
        {
            if(right[i]<left[j])
            {
                A[k]=right[i];
                i++;
            }
            else 
            {
                A[k]=left[j];
                j++;
            }
            k++;
        }
        while(i<=left.Length)
        {
            A[k]=left[i];
            i++;
            k++;
        }
        while(j<=right.Length)
        {
            A[k]=right[j];
            j++;
            k++;
        }
        
    }
}