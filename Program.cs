namespace SistemaPostoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Álcool 2 - Gasolina \n3 - Diesel 4 - Fim");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int pedido = int.Parse(Console.ReadLine());

            while (pedido != 4)
            {
                if (pedido == 1)
                {
                    alcool += 1;
                }
                else if (pedido == 2)
                {
                    gasolina += 1;
                }
                else if (pedido == 3)
                {
                    diesel += 1;
                }

                pedido = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Obrigado!");

            Console.WriteLine("Álcool {0}", alcool);
            Console.WriteLine("Gasolina {0}", gasolina);
            Console.WriteLine("Diesel {0}", diesel);
        }
    }
}