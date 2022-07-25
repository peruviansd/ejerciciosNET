using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosNET
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
            Console.ReadLine();


        }

        public static string PascalCase(string text)
        {
            string pascalCasePhrase = "";
            if (text.Length > 0)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != ' ' && i == 0)
                    {
                        pascalCasePhrase += text[i].ToString().ToUpper();
                    }
                    else if (text[i] != ' ' && text[i - 1] == ' ')
                    {
                        pascalCasePhrase += text[i].ToString().ToUpper();
                    }
                    else if (text[i] != ' ')
                    {
                        pascalCasePhrase += text[i];
                    }
                }

            }

            return pascalCasePhrase;
        }
        public static bool IsPalindromo(string word)
        {
            word = word.ToLower();
            string wordWithOutSpace = "";
            string wordReverse = "";

            if (word.Contains(""))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != ' ') wordWithOutSpace += word[i];
                }
            }

            for (int i = wordWithOutSpace.Length - 1; i >= 0; i--)
            {
                wordReverse += wordWithOutSpace[i];
            }

            return wordReverse == wordWithOutSpace;

        }
        public static bool IsLaboral(string day)
        {
            bool result = false;

            switch (day)
            {
                case "monday":
                    result = true;
                    break;
                case "tuesday":
                    result = true;
                    break;
                case "wednesday":
                    result = true;
                    break;
                case "thursday":
                    result = true;
                    break;
                case "friday":
                    result = true;
                    break;
                case "saturday":
                    result = false;
                    break;
                case "sunday":
                    result = false;
                    break;

                default:
                    Console.WriteLine("you haven't intruced a correct day");
                    break;
            }

            return result;
        }
        public static string CheckPassword()
        {
            string correctPass = "MyPassword";
            string userPass;
            int attempts = 0;
            do
            {
                Console.WriteLine("Introduce your password");
                userPass = Console.ReadLine();
                attempts++;

                if (attempts == 3) return "Try next year"; ;


            } while (userPass != correctPass);



            return "Enhorabuena";
        }
        public static void CalculadoraInversa()
        {
            double result = 0;
            Console.Write("Intrudoce the first number: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce the second number: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce an Operation");
            Console.WriteLine(" + : Addition");
            Console.WriteLine(" - : Subtraction");
            Console.WriteLine(" * : Multiplication");
            Console.WriteLine(" / : Division");
            Console.WriteLine(" ^ : Pow(n1 for base n2  pow)");
            Console.WriteLine(" %  : Modulus of division");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("You have introduced a wrong option");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The result is: " + result);
        }

        public static void TicTacToe()
        {

            string jugadorAposiciones = "";
            string jugadorBposiciones = "";
            int limiteJugadas = 9;
            char turno = 'A';
            bool existeGanador = false;

            char[] poscicionesTotales = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


            do
            {

                if (turno == 'A')
                {
                    string posicion = PosicionEscogida(turno, poscicionesTotales);
                    jugadorAposiciones += posicion;

                    if (jugadorAposiciones.Length >= 3)
                    {

                        if (CheckWinnerCombination(jugadorAposiciones))
                        {
                            Console.WriteLine("ganador A ha ganado");
                            DibujaMatriz(poscicionesTotales);
                            existeGanador = true;
                            break;
                        }
                    }

                    limiteJugadas--;
                    turno = 'B';
                }
                else
                {

                    string posicion = PosicionEscogida(turno, poscicionesTotales);
                    jugadorBposiciones += posicion;

                    if (jugadorBposiciones.Length >= 3)
                    {

                        if (CheckWinnerCombination(jugadorBposiciones))
                        {
                            Console.WriteLine("ganador B ha ganado");
                            DibujaMatriz(poscicionesTotales);
                            existeGanador = true;
                            break;
                        }
                    }

                    limiteJugadas--;
                    turno = 'A';
                }

            } while (limiteJugadas > 0);


            if (existeGanador)
            {
                VolverAjugar();
            }
            else
            {
                Console.WriteLine("empate");
                VolverAjugar();
            }


        }

        public static bool CheckWinnerCombination(string jugadas)

        {
            string[] combinacionGanadoras = new string[] { "123", "456", "789", "147", "258", "369", "159", "357" };

            bool existeGanador = false;

            foreach (var combinacion in combinacionGanadoras)
            {
                if (jugadas.Contains(combinacion[0]) && jugadas.Contains(combinacion[1]) && jugadas.Contains(combinacion[2]))
                {
                    existeGanador = true;
                    break;
                }
                else
                {
                    existeGanador = false;
                }
            }
            return existeGanador;
        }
        public static void DibujaMatriz(char[] posciciones)
        {


            Console.WriteLine();
            Console.WriteLine("     |     |    ");
            Console.WriteLine($"  {posciciones[1]}  |  {posciciones[2]}  |  {posciciones[3]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine($"  {posciciones[4]}  |  {posciciones[5]}  |  {posciciones[6]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine($"  {posciciones[7]}  |  {posciciones[8]}  |  {posciciones[9]}  ");
            Console.WriteLine("     |     |    ");


        }
        public static string PosicionEscogida(char turno, char[] posciciones)
        {
            string posicion;
            int indexPosicion;

            DibujaMatriz(posciciones);
            Console.Write($"Jugador {turno} es tu turno, elige una posicion : ");
            posicion = Console.ReadLine();



            bool success = int.TryParse(posicion, out indexPosicion);
            while (success == false)
            {
                Console.WriteLine("escriba un numero");
                posicion = Console.ReadLine();
                success = int.TryParse(posicion, out indexPosicion);

            }
            // indexPosicion = Convert.ToInt32(posicion);

            while (indexPosicion <= 0 || indexPosicion >= 10 || posciciones[indexPosicion] == 'X' || posciciones[indexPosicion] == 'O')
            {
                Console.WriteLine(" Posicion ya elegida o no existe, eliga otra posicion");
                posicion = Console.ReadLine();
                indexPosicion = Convert.ToInt32(posicion);
            }

            posciciones[indexPosicion] = (turno == 'A') ? 'X' : 'O';

            return posicion;

        }
        public static void VolverAjugar()
        {

            string respuesta = "";
            Console.Write("desea volver a jugar? (y/n)");
            respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "y")
            {
                TicTacToe();
            }
            else
            {
                Console.WriteLine("Adios");
                return;
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Choose one method to use");
            Console.WriteLine("1. PascalCase ");
            Console.WriteLine("2. Palindromo ");
            Console.WriteLine("3. Check if a day is Laboral ");
            Console.WriteLine("4. CheckPassword ");
            Console.WriteLine("5. Calculadora Inversa");
            Console.WriteLine("6. TicaTacToe");


            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Intruduce a phrase");
                string text = Console.ReadLine();
                Console.WriteLine(PascalCase(text));
            }
            else if (answer == 2)
            {
                Console.WriteLine("Introduce the word that you want to check if its palidromo");
                string text = Console.ReadLine();
                Console.WriteLine(IsPalindromo(text));
            }
            else if (answer == 3)
            {
                Console.WriteLine("Introduce the day ");
                string text = Console.ReadLine();
                Console.WriteLine(IsLaboral(text));

            }
            else if (answer == 4)
            {
                CheckPassword();
            }
            else if (answer == 5)
            {
                CalculadoraInversa();
            }
            else if(answer == 6)
            {
                TicTacToe();
            }
            else
            {
                Console.WriteLine("You have intruced a wrong option");
            }


        }
    }
}
