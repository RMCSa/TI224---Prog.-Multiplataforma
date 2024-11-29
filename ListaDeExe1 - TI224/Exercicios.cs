/*
- Exe 1
- Resposta: [83,48,5,14,48,97]

- Exe 2 
- Resposta: 9

- Exe 3
- Resposta: O Problema se encontra na estrutura de repetição While, A[j] > chave nunca permitirá a execução do while da forma correta, portanto, deve-se corrigir para A[j] < chave.

- Exe 4
- Resposta: 
- a) 6 - 6
- b) Sim. Busca1 consegue trazer o resultado correto. O Busca2 otimiza o seu processo ao dividir a lista em 2 a cada iteração, enquanto o Busca1 percorre a lista de forma linear.
*/

using System.ComponentModel;

public class Exercicios
{

    private static int Busca2(int[] A, int k)
    {
        int inicio = 0, fim = A.Length;
        while (inicio < fim)
        {
            int meio = (inicio + fim) / 2;
            if (A[meio] == k)
                return meio;
            if (A[meio] < k)
                inicio = meio + 1;
            else
                fim = meio - 1;
        }
        return -1;

    }

    public static int[] Ordena(int[] A)
    {
        int i, j, chave;
        for (i = 1; i < A.Length; i++)
        {
            chave = A[i];
            j = i - 1;
            while (j >= 0 && A[j] < chave)
            {
                A[j + 1] = A[j];
                j = j - 1;
            }

            A[j + 1] = chave;
        }
        return A;
    }
    public static int[] Exe5(int[] A)
    {
        Random random = new Random();
        for (int i = A.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        return A;
    }

    public static string Exe6(int[] A, int k)
    {
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[i] + A[j] == k)
                {
                    return $"{A[i]} - {A[j]}";
                }
            }
        }
        return "Não encontrado";
    }

    public static string Exe7(string[] A)
    {
        int numElementosUnicos = 0;

        foreach ()

        // Verificar as diferentes
        // Separar todas as diferentes
        // retornar uma lista com todas elas
        return String.Join(",", A);
    }

    public static void Main(String[] args)
    {
        int[] A = { 20, 18, 16, 13, 12, 907, 36, 5, 80, 1105 };

        Console.WriteLine(Busca2(A,1105));
    }
    
}





