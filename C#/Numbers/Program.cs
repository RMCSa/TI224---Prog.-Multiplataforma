///Tuplas
//Inicializar
using System.Runtime.CompilerServices;

(int, int, string) a = (12, 1, "numero");

//Atribuir
a = (60, 60, "A");
long c = checked(a.Item1 + a.Item2); // checked verifica se ultrapassou o 

// Retornar valores em um método
(bool, int) GetSameOrBigger(int num1, int num2)
{
    return (num1 == num2, num1 > num2 ? num1 : num2);
}



// Parâmetros de um método
int Add((int num1, int num2) operands)
{
    int x = operands.num1; //só de exemplo
    int y = operands.num2;
    return x + y;
}
(int, int) b = (5, 4);

///IF's e Switch
int p = 10;
switch (p)
{
    case < 5:
        break;
    case >= 10:
        break;
    default:
        break;
}

///WHILE
int counter = 0;

while (counter < 5)
{
    counter++;
}

///do-while
int count = 0;
do
{
    count++;
} while (count < 5);

///for
for (int i = 0; i < 5; i++)
{
    //System.Console.WriteLine(i);
}

///arranjo 1-dimensão
int[] array1 = new int[5];
int[] array2 = [1, 2, 3, 4, 5];

///arranjo 2-dimensão
int[,] array3 = new int[2, 3];
int[,] array4 = {{1,2,3},
                 {4,5,6}};

for(int i = 0; i<array2.Length; i++){
    //System.Console.WriteLine(array2[i]);
}

foreach(int value in array2){
    //System.Console.WriteLine(value);
}

//List Classe
var names = new List<string> {
    "Rafael",
    "Marcelo",
    "Vitor"
};
names.Reverse();
foreach(var name in names){
    System.Console.WriteLine($"Cria {names.IndexOf(name) + 1}:{name.ToUpper()}");
}
System.Console.WriteLine($"Quantidade de crias: {names.Count}");







