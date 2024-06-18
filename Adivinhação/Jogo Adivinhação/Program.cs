class Program
{
    static void Main(){

        Random random = new Random();
        int aleatorio = random.Next(0,20);

        Console.Write($"Tente acertar um número entre 0 e 20 (3 chances) : ");
        int num = Convert.ToInt16(Console.ReadLine());

        for (int i=0; i<2; i++){
            if (num == aleatorio){

                Console.WriteLine($"Você acertou! O número era {num}");
                break;
                
            }
            else{
                Console.Write("Errou! Tente outro número : ");
                num = Convert.ToInt16(Console.ReadLine());
                if (num == aleatorio){
                    Console.WriteLine($"Você acertou! O número era {num}");
                 break;
                }
            }
        }
        Console.Write("Acabou!");

        

    }
}
