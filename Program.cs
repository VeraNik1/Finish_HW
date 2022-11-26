while(true){
    Console.WriteLine("Введите размер массива (натуральное число): ");
    string n = Console.ReadLine()!;
    if (int.TryParse(n, out var x)){
        int N = int.Parse(n);
        string [] Arr = GetArray(N);
        string [] ArrResult = FilterArray(Arr);
        Console.WriteLine($"[{String.Join(", ", Arr)}] -> [{String.Join(", ", ArrResult)}]");
        break;}
    else{
        Console.WriteLine("Введено не натуральное число!");
        Console.WriteLine("Попробуйте еще раз!");}
        }

//метод заполнения пользователям массива размером N
string[] GetArray(int n){
    string [] arr = new string[n];
    for(int i = 0; i < n; i++){
        Console.WriteLine($"Введите {i+1}-й элемент массива: ");
        string elem = Console.ReadLine()!;
        arr[i] = elem;
    }
    return arr;
}

//метод фильтрации массива с длиной элементов меньше либо равной 3
string[] FilterArray(string[] arr){
    string [] res = new string [0];
    for(int i = 0; i < arr.Length; i++){
        if (arr[i].Length < 4){
        Array.Resize(ref res, res.Length + 1);
        res[res.Length - 1] = arr[i];}
    }
    return res;
}



