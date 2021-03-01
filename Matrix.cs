//Accept and store values from rectangular and jagged array
//display the values in both jagged and rectangular array 
//using normal for loop and for each loop
using System;  

class Program {  
    static void Main(string[] args) { 
        Console.WriteLine("enter the no of rows");
        int row = Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine("enter the no of columns");
        int col = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[row, col];

        Console.WriteLine("enter values in matrix ");
        for (int i = 0; i<row; i++){
            for (int j = 0; j<col; j++){
                Console.WriteLine("a({0},{1}) = ",i,j);
                matrix[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }

        string roww ="";
        string line ="";
        string lastline ="";

        Console.WriteLine("\nthe matrix is");
        for (int i = 0; i<row; i++){
            for (int j = 0; j<col; j++){
                roww  = roww + Convert.ToString(matrix[i,j]) +"\t|\t";
                line = line + "----------------";
            }
            roww  = "|\t" + roww;
            Console.WriteLine(line);
            Console.WriteLine(roww);
            roww = "";
            lastline = line;
            line = "";
        }
        Console.WriteLine(lastline);

    }
}  

