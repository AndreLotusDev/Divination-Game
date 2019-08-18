using System;

namespace Jogo_da_Adivinhação
{
    class Program
    {
        static void Main(string[] args)
        {

            void printSomeStuff(int points)
            {
                Console.WriteLine("Seu numero de tentativas foi: " + points);
                Console.WriteLine("---------------------------------");
            }

            int numberIchoose()
            {
               return  Convert.ToInt32(Console.ReadLine());
            }

            int attempts = 1; //numero de tentativas 
            int number_of_plays = 0; //Numero de vezes jogada
            bool loop = true;
            while (loop == true) {
                Random random = new Random();

                int pickedNumber = random.Next(0, 25);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Eu escolhi um número de 0 a 25, tente adivinhar!");
                Console.WriteLine("Escolha um numero !");

                int number_i_choose = Convert.ToInt32(Console.ReadLine());

                while (number_i_choose != pickedNumber) {
                    if (number_i_choose > pickedNumber)
                    {
                        Console.WriteLine("Tente Novamente, seu numero é maior que o escolhido");
                        number_i_choose = numberIchoose();
                        attempts += 1;
                    }
                    else if (number_i_choose < pickedNumber)
                    {
                        Console.WriteLine("Tente Novamente, seu numero é menor que o escolhido");
                        number_i_choose = numberIchoose();
                        attempts += 1;
                    }
                }

                if(number_i_choose == pickedNumber)
                {
                    Console.WriteLine("Parabens voce acertou o numero !");
                    printSomeStuff(attempts);
                    attempts = 1;
                    Console.WriteLine("Deseja jogar novamente? S/N");
                    number_of_plays += 1;
                    string leitura = Console.ReadLine();
                    switch (leitura)
                    {
                        case "S":
                            loop = true;                           
                            break;                          
                        case "s":
                            loop = true;
                            break;
                        case "N":
                            loop = false;
                            break;
                        case "n":
                            loop = false;
                            break;
                    }

                }

                
            }
            //termina o While
            if (loop == false)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Muito obrigado por jogar !");
                Console.WriteLine("Numero de vezes jogada(s): " + number_of_plays);
            }
        }
    }
}
