using System;
namespace LargestSumsOfATriangle 
{  
public class MaxmimumPathSum 
{   //To Get the Input Elements
    string[] InputElements = new string[100];
	//Formatting the InputElements as a Triangle
	int[,] TriangularArray = new int[100,100];
	int RowIndex,ColumnIndex,NumberOfRows;
	
  //To Get Input Elements From the User
   public  void GetInputValues() 
   {
	  NumberOfRows = -1;
	  Console.WriteLine("Enter the Number of Rows to be Printed:\t");
	  while( NumberOfRows<1)
	  { 
	     NumberOfRows = Convert.ToInt32(Console.ReadLine());
	     if(NumberOfRows<1)
		{
		 Console.WriteLine("Enter an Positive Integer between 0 to 100");
		}
      }
	     Console.WriteLine("Enter the Elements of an TriangularArray:");
		 for(RowIndex=0;RowIndex<NumberOfRows;RowIndex++)
		{
            InputElements[RowIndex] = Console.ReadLine();
			 for(ColumnIndex=0;ColumnIndex<=RowIndex;ColumnIndex++)
			{
			TriangularArray[RowIndex,ColumnIndex] =  Int32.Parse(InputElements[RowIndex].Split(' ')[ColumnIndex]);
			}
		} Console.WriteLine("");
    }
	//To Find the Largest Sum in a Path Of Triangle
	public void ToCalculateMaximumPathSum()
	{ 
		if(NumberOfRows > 1) 
		TriangularArray[1, 1] = TriangularArray[1, 1] + TriangularArray[0, 0]; 
		TriangularArray[1, 0] = TriangularArray[1, 0] + TriangularArray[0, 0]; 
	    for(int RowIndex = 2; RowIndex < NumberOfRows; RowIndex++) 
		{ 
			TriangularArray[RowIndex, 0] = TriangularArray[RowIndex, 0] + TriangularArray[RowIndex - 1, 0]; 
			TriangularArray[RowIndex, RowIndex] = TriangularArray[RowIndex, RowIndex] + TriangularArray[RowIndex - 1, RowIndex - 1]; 
            for (int ColumnIndex = 2; ColumnIndex < RowIndex; ColumnIndex++) 
			{  
				if (TriangularArray[RowIndex, ColumnIndex] + TriangularArray[RowIndex - 1, ColumnIndex - 1] >= TriangularArray[RowIndex, ColumnIndex] + TriangularArray[RowIndex - 1, ColumnIndex]) 
				
					TriangularArray[RowIndex, ColumnIndex] = TriangularArray[RowIndex, ColumnIndex] + TriangularArray[RowIndex - 1, ColumnIndex - 1]; 
				else
					TriangularArray[RowIndex, ColumnIndex] =TriangularArray[RowIndex, ColumnIndex] + TriangularArray[RowIndex - 1, ColumnIndex]; 
			} 
		} 
        int max = TriangularArray[NumberOfRows - 1, 0]; 
	    for(int RowIndex = 1; RowIndex < NumberOfRows; RowIndex++) 
		{ 
			if(max < TriangularArray[NumberOfRows - 1, RowIndex]) 
				max = TriangularArray[NumberOfRows - 1, RowIndex]; 
		} 
		Console.WriteLine("The Largest Sum In The Paths Of TriangluarArray is:\t ");
		Console.WriteLine(max); 
	} 
    
	public static void Main()
	{  
		MaxmimumPathSum m = new MaxmimumPathSum();
		int Iteration, IterationIndex;
		Iteration = -1;
		while(Iteration<1)
		{
		Console.WriteLine("Enter the Number of Testcases:");
		Iteration = Convert.ToInt32(Console.ReadLine());
		if(Iteration<1)
		 {
			Console.WriteLine("Enter an Positive Integer: ");
		 }
		}
		for(IterationIndex=1;IterationIndex<=Iteration;IterationIndex++)
		{
	    m.GetInputValues();
		m.ToCalculateMaximumPathSum();
		}
     }
}
}