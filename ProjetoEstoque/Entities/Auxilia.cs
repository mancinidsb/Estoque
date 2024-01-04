using System;

namespace ProjetoEstoque.Entities
{
    internal static class Auxilia
    {
        //Classe Que Auxilia Na Classe Program
        public static string CriaCnpj()
        {
            int[] arrayNumbers = new int[10];
            Random random = new Random();

            int number;
            for(int i = 0; i < arrayNumbers.Length; i++)
            {
                number = random.Next(0, 10);
                arrayNumbers[i] = number;
            }

            string? cnpj = "";
            for(int i=0;i<arrayNumbers.Length;i++)
            {
                switch (i)
                {
                    case 1 or 4:
                        cnpj += $"{arrayNumbers[i]}.";
                        break;
                    case 7:
                        cnpj += $"{arrayNumbers[i]}/0001-";
                        break;
                    default:
                        cnpj += $"{arrayNumbers[i]}";
                        break;
                }
            }
            return cnpj;
        }
    }
}
