# README: Array Operations in C#

## Overview
This project demonstrates the usage of arrays in C# by implementing four distinct tasks. The program performs the following operations:

1. Creates an array to hold 10 integers.
2. Populates the array using a `for` loop and displays the values with a `foreach` loop.
3. Adds a new element to the array (making it the 11th element).
4. Sorts the array in descending order and displays the result.

## Instructions

### Prerequisites
- A working installation of the .NET SDK.
- A code editor such as Visual Studio Code or Visual Studio.

### How to Run the Program
1. Save the program in a file named `Program.cs`.
2. Open a terminal in the directory containing `Program.cs`.
3. Compile the program using the command:
   ```
   dotnet build
   ```
4. Run the program using the command:
   ```
   dotnet run
   ```

### Program Workflow

#### 1. Initialize an Array
The program starts by creating an array named `sayilar` with a fixed size of 10 to store integer values.
```csharp
int[] sayilar = new int[10];
```

#### 2. Populate the Array and Display Values
A `for` loop prompts the user to input values for each of the 10 array elements. After populating the array, a `foreach` loop displays the entered values.

```csharp
for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
    sayilar[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Girdiğiniz sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
```

#### 3. Add a New Element
To add an 11th element, the program creates a new array with one additional slot, copies existing elements, and appends the new value entered by the user.

```csharp
Console.Write("Diziye eklemek istediğiniz yeni bir değer giriniz: ");
int yeniDeger = int.Parse(Console.ReadLine());

int[] genisletilmisSayilar = new int[sayilar.Length + 1];
for (int i = 0; i < sayilar.Length; i++)
{
    genisletilmisSayilar[i] = sayilar[i];
}
genisletilmisSayilar[genisletilmisSayilar.Length - 1] = yeniDeger;
```

#### 4. Sort and Display in Descending Order
The program sorts the array in ascending order using `Array.Sort` and then reverses the order using `Array.Reverse`.

```csharp
Array.Sort(genisletilmisSayilar);
Array.Reverse(genisletilmisSayilar);

Console.WriteLine("Büyy\u00fkten küçüe sıralı dizi:");
foreach (int sayi in genisletilmisSayilar)
{
    Console.WriteLine(sayi);
}
```

### Sample Output
```text
Lütfen 1. sayıyı giriniz: 5
Lütfen 2. sayıyı giriniz: 8
Lütfen 3. sayıyı giriniz: 3
Lütfen 4. sayıyı giriniz: 7
Lütfen 5. sayıyı giriniz: 2
Lütfen 6. sayıyı giriniz: 9
Lütfen 7. sayıyı giriniz: 1
Lütfen 8. sayıyı giriniz: 6
Lütfen 9. sayıyı giriniz: 4
Lütfen 10. sayıyı giriniz: 0
Girdiğiniz sayılar:
5
8
3
7
2
9
1
6
4
0
Diziye eklemek istediğiniz yeni bir değer giriniz: 10
Büyükten küçüğe sıralı dizi:
10
9
8
7
6
5
4
3
2
1
0
```

## Key Concepts Demonstrated
- **Array Declaration and Initialization**: Creating arrays with fixed sizes.
- **For Loop**: Iterating through array indices to populate values.
- **Foreach Loop**: Iterating through elements to display values.
- **Dynamic Array Resizing**: Simulating resizing by creating a new array and copying elements.
- **Sorting and Reversing**: Using built-in methods to manipulate array order.

---

## Further Exploration
- Modify the program to work with other data types (e.g., `float`, `string`).
- Implement error handling for invalid user inputs.
- Use a `List<int>` instead of an array to avoid manual resizing.

---

### Author
This program and documentation were created as part of a C# learning exercise.

