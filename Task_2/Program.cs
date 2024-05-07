// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// Например:
// [6 7 19 34 3 1 4 7 9 1] => 3
// [1 8 43 4 55 60 3 2 1 3] => 4

int[] GenerateArray(int size, int leftRange, int rightRange){
    int [] tempArray = new int[size]; 
    Random rand = new Random(); 

    for( int i = 0; i < size; i++){
        tempArray[i] = rand.Next(leftRange, rightRange + 1); 
    }
    return tempArray;
}

void PrintArray(int[] array){
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] arr = GenerateArray(10, 1, 101);
PrintArray(arr);

int evenNum = 0;
for(int i = 0; i < arr.Length; i++){
    if(arr[i] % 2 == 0){
        evenNum++;
    }
}
System.Console.WriteLine(evenNum);