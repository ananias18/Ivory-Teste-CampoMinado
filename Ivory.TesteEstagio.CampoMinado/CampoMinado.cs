using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        public static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!


            int linha, coluna, m, l, x, y;

            Console.WriteLine(9);
            linha = int.Parse(Console.ReadLine());

            Console.WriteLine(9);
            coluna = int.Parse(Console.ReadLine());
            {

                Minado[,] casa = new Minado[linha, coluna];

                int[,] jogo = new int[linha, coluna];
                for (int a = 0; a < linha; a++)
                {
                    for (int c = coluna - 1; c >= 0; c--)
                    {
                        casa[a, c] = new Minado(); //* inicialmente todos os valores do tabuleiro são 0//*
                    }
                }

                Random bomba = new Random(); //*declaração de um número randômico//* 

                for (int b = 0; b < (linha * coluna) / 6;) //*bombas aleatórias em um sexto do campo minado//*
                {
                    m = bomba.Next(0, linha);
                    l = bomba.Next(0, coluna);  //*bomba.Next = declaração na forma Random//*

                    if (casa[m, l].getBombas() == false)
                    {
                        casa[m, l].setBombas();
                        b++;
                    }

                    for (x = 0; x < linha; x++)
                    {
                        for (y = 0; y < coluna; y++)
                        {
                            if (casa[x, y].getBombas() == true)
                                Console.Write(" X ");
                            else
                            {

                                if (casa[x, y].getBombas() == false)
                                    Console.Write(" * ");
                            }
                        }
                        Console.Write("\n"); //* comando para pular linha e deixar na forma de tabuleiro//*

                        while (casa[x, y].getBombas() == false)
                        {
                            //Canto superior esquerdo
                            if (x == 0 && y == 0)
                            {

                                if ((casa[x, y + 1].getBombas() == true))
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x + 1, y + 1].getBombas() == true))
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x + 1, y].getBombas() == true))
                                {
                                    casa[x, y].setValor();
                                }
                                casa[x, y].getValor();

                            }
                            //canto inferior esquerdo
                            if (x == linha - 1 && y == 0)
                            {

                                if ((casa[x - 1, y].getBombas() == true))
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x - 1, y + 1].getBombas() == true))
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x, y + 1].getBombas() == true))
                                {
                                    casa[x, y].setValor();
                                }
                                casa[x, y].getValor();
                            }

                            //Canto superior direito
                            if (x == 0 && y == coluna - 1)
                            {

                                if ((casa[x, y - 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x + 1, y - 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x + 1, y].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                casa[x, y].getValor();

                            }

                            //Canto inferior direito
                            if (x == linha - 1 && y == coluna - 1)
                            {
                                if ((casa[x - 1, y].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x - 1, y - 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x, y - 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                casa[x, y].getValor();


                            }
                            //Campos na parte superior do campo
                            for (int j = 1; j < coluna - 1; j++)
                            {

                                if (x == 0 && y == j)
                                {
                                    if ((casa[x, (y - 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x + 1), (y - 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x + 1), y].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x + 1), (y + 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[x, (y + 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    casa[x, y].getValor();



                                }
                            }

                            //Campos na parte inferior do campo
                            for (int j = 1; j < coluna - 1; j++)
                            {

                                if (x == linha - 1 && y == j)
                                {
                                    if ((casa[x, (y - 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x - 1), (y - 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x - 1), y].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x - 1), (y + 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[x, (y + 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    casa[x, y].getValor();



                                }
                            }

                            //Valores na lateral esquerda do campo

                            for (int j = 1; j < linha - 1; j++)
                            {
                                if (y == 0 && x == j)
                                {
                                    if ((casa[(x - 1), y].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x - 1), (y + 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[x, (y + 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x + 1), y].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x + 1), (y + 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    casa[x, y].getValor();

                                }
                            }

                            //Valores na lateral direita do campo

                            for (int j = 1; j < linha - 1; j++)
                            {
                                if (y == coluna - 1 && x == j)
                                {
                                    if ((casa[(x - 1), y].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x - 1), (y - 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[x, (y - 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x + 1), (y - 1)].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    if ((casa[(x + 1), y].getBombas()) == true)
                                    {
                                        casa[x, y].setValor();
                                    }
                                    casa[x, y].getBombas();

                                }
                            }


                            //Campos restantes

                            if (x > 0 && x < linha - 1 && y > 0 && y < coluna - 1)
                            {
                                if ((casa[x - 1, y - 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x, y - 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x + 1, y - 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x + 1, y].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x + 1, y + 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x, y + 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x - 1, y + 1].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                if ((casa[x - 1, y].getBombas()) == true)
                                {
                                    casa[x, y].setValor();
                                }
                                casa[x, y].getValor();

                            }
                        }
                    }



                    while (casa[m, l].getBombas() == false)

                        Console.WriteLine("Digite a linha:");
                    int lin = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a coluna:");
                    int col = int.Parse(Console.ReadLine());


                    if (lin < linha && col < coluna)
                    {
                        if (linha >= 0)
                        {
                            if (casa[lin - 1, col - 1].getBombas() == true)
                            {
                                Console.WriteLine("BUUMMM! GAME OVER");
                                casa[lin - 1, col - 1].setBombas();
                            }
                            else
                            {
                                Console.WriteLine("Não tem bomba! Jogue novamente!");
                                Console.WriteLine("");
                            }
                        }
                    }
                    else
                    {

                        Console.WriteLine("A linha ou a coluna está saindo da matriz");
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}





