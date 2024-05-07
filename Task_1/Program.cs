// Задача 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
// значения которых лежат в отрезке [20,90].

// Например:
// [10 21 14 93 23] => 2

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

int quantity = 0;
for(int i = 0; i < arr.Length; i++){
    if(arr[i] >= 20 && arr[i] <= 90){
        quantity++;
    }
}
System.Console.WriteLine(quantity);