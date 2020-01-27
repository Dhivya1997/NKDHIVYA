using System;
namespace LargestSumsOfATriangle 
{  
public class MaxmimumPathSum 
{ 
	   //First getting input elements as a string
	     string[] RowElements = new string[100];
	   //Formatting the input elements as a triangularArray
          int[,]TriangularArray = new int[100,100];
	      int RowIndex,ColumnIndex,NumberOfRows;

   public  void GetInputValues() 
   {
	     Console.WriteLine("Enter the Number of Rows to be Printed:\t");
	     NumberOfRows = Convert.ToInt32(Console.ReadLine());
	     Console.WriteLine("Enter the Elements of an TriangularArray:");
		 
	     for(RowIndex=0;RowIndex<NumberOfRows;RowIndex++)
		 {
            RowElements[RowIndex] = Console.ReadLine();
			 for(ColumnIndex=0;ColumnIndex<=RowIndex-2;ColumnIndex++)
			{
				TriangularArray[RowIndex,ColumnIndex] =  Int32.Parse(RowElements[RowIndex].Split(' ')[ColumnIndex]);
			}
		} Console.WriteLine("");
    }
            
		
    public void ToCalculateMaximumPathSum()
    {
     for ( RowIndex = NumberOfRows - 1; RowIndex >= 0; RowIndex--) 
        { 
            for ( ColumnIndex = 0; ColumnIndex <= RowIndex; ColumnIndex++) 
            { 
                // for each element,  
                // check both elements 
                // just below the number 
                // and below right to 
                // the number add the 
                // maximum of them to it 
                if (TriangularArray[RowIndex + 1,ColumnIndex] > TriangularArray[RowIndex + 1,ColumnIndex + 1]) 
                    TriangularArray[RowIndex,ColumnIndex] += TriangularArray[RowIndex + 1,ColumnIndex]; 
                else
                    TriangularArray[RowIndex,ColumnIndex] +=  TriangularArray[RowIndex + 1,ColumnIndex + 1]; 
				
            } 
        } Console.WriteLine("The Largest Sums Of A TriangluarArray is:\t ");
	      Console.WriteLine(TriangularArray[0,0]);
      
        // return the top element 
        // which stores the maximum sum 
    
    } 
	public static void Main()
	{  
		MaxmimumPathSum m = new MaxmimumPathSum();
	    m.GetInputValues();
		m.ToCalculateMaximumPathSum();
	}
}
}
