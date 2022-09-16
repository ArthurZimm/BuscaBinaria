using System;
class Program
{
    public static void Main(string[] args)
    {

        int[] vet = new int[100];
        int achou;

        for (int i = 0; i < vet.Length; i++)
        {

            vet[i] = i;
        }

        achou = busca(vet, 50, 0, vet.Length - 1);
        Console.WriteLine(achou);

        Console.ReadKey();

        int busca(int[] vet1, int valor, int posIni, int posFim)
        {

            int posMeio;
            posMeio = (posIni + posFim) / 2;

            if (valor == vet1[posMeio])
            {

                return posMeio;

            }
            else if ((posFim - posIni) <= 0)
            {

                return -1;

            }
            else if (valor > vet1[posMeio])
            {

                return busca(vet1, valor, posMeio + 1, posFim);

            }
            else
            {

                return busca(vet1, valor, posIni, posMeio - 1);

            }

        }

    }
}

