using System;
using System.Collections.Generic;

namespace TradutorPostFix
{
    class Program
    {
       static void Main(string[] args)
        {
            string infix, postfix;
            while (1 == 1)
            {  
                Console.WriteLine("Por favor insira uma expressão infixada: ");
                infix = Console.ReadLine();
                postfix = Tradutor(infix);
                Console.WriteLine("Postfix: " + postfix);
            }
        }
    public static string Tradutor(string infix)
        {
            string aux = string.Empty;
            Stack<char> pilha = new Stack<char>();

            for (int i = 0; i<infix.Length; i++)
            {
                char digito = infix[i];

                if (char.IsLetterOrDigit(digito))
                {
                    aux += digito;
                }
                else if(digito == '(')
                {
                    pilha.Push(digito);
                }
                else if(digito == ')')
                {
                    while(pilha.Count != 0 && pilha.Peek() != '(')
                    {
                        aux += pilha.Pop();
                    }
                    if (pilha.Count != 0 && pilha.Peek() != '(')
                    {
                        return "Entrada invalida";
                    }
                    else
                    {
                        pilha.Pop();
                    }
                }
                else
                {
                    while (pilha.Count != 0 && Precedencia(digito) <= Precedencia(pilha.Peek()))
                    {
                      aux += pilha.Pop();                       
                    }
                    pilha.Push(digito);
                }
            }
            while(pilha.Count != 0)
            {
                aux += pilha.Pop();
            }
            return aux;
        }
        public static int Precedencia(char op)
        {
            switch (op)
            {
                case '+':
                    return 1;
                case '-':
                    return 1;

                case '*':
                    return 2;
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
    }
}
