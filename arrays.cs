//Да се създаде двумерен масив по няколко начина:

//Начин 1:
int[,] matrix = new int[3, 3];

matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

//Начин 2: 

int [,] matrixx = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

//Масивите могат да се обхождат с цикък for

for(int i= 0; i<matrix.GetLength(0);i++){
    for (int j = 0; j < matrix.GetLength(1); j++){
        Console.WriteLine(matrix[i,j]);
    }
}