string[] boissons = ["Coca", "Fanta", "Sprite"];
int[] stockBoissons = [1, 2, 1];
bool active = true;

while (stockBoissons[0] > 0 || stockBoissons[1] > 0 || stockBoissons[2] > 0)
{
    Console.WriteLine("Faites votre sélection parmis les boissons proposées : ");
    Console.WriteLine("1 : Coca");
    Console.WriteLine("2 : Fanta");
    Console.WriteLine("3 : Sprite");
    int choixBoisson = Convert.ToInt32(Console.ReadLine()) - 1;
    {
        switch(choixBoisson)

        {
            case 0:
                if (stockBoissons[0] > 0)
                {
                    Console.WriteLine("Voici votre Coca");
                    stockBoissons[0]--;
                    return;
                }
                Console.WriteLine("Plus de stock de Coca");
                return;
            case 1:
                if (stockBoissons[1] > 0)
                {
                    Console.WriteLine("Voici votre Fanta");
                    stockBoissons[1]--;
                    return;
                }
                Console.WriteLine("Plus de stock de Fanta");
                return;
            case 2:
                if (stockBoissons[2] > 0)
                {
                    Console.WriteLine("Voici votre Sprite");
                    stockBoissons[0]--;
                    return;
                }
                Console.WriteLine("Plus de stock de Spirte");
                return;
        }
    }
} 