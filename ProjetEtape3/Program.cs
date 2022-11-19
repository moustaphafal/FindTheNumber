internal class Program
{
    public static void main(String[] args)
    {
            Console.WriteLine("Donnez la borne inferieur");
            String borne_inf = Console.ReadLine();
            Console.WriteLine("Donnez la borne superieur");
            String borne_sup = Console.ReadLine();
            Console.WriteLine("Donnez le nombre de possibilite");
            String Possibilite = Console.ReadLine();
            int bf = 0, bs = 0, p = 0, choix = 0;
            if (int.TryParse(borne_inf, out bf) && int.TryParse(borne_sup, out bs) && int.TryParse(Possibilite, out p))
            {
                Random rd = new Random();
                int rand_num = rd.Next(bf, bs);
                int tentative = 0;
                do
                {
                    Console.WriteLine("Choississez un entre " + bf + " et " + bs);
                    String nombre = Console.ReadLine();
                    if (int.TryParse(nombre, out choix))
                    {
                        if (choix == rand_num)
                        {
                            Console.WriteLine("Vous avez gagnés");
                            break;
                        }
                        else if (choix > rand_num)
                        {
                            Console.WriteLine("Le nombre est plus petit");
                        }
                        else if (choix < rand_num)
                        {
                            Console.WriteLine("le nombre est plus grand");
                        }
                        tentative++;

                    }
                    else
                    {
                        Console.WriteLine("Choississez un nombre  !");

                    }

                } while (tentative < p);
                int note = (p / tentative);
                Console.WriteLine("Jeu Terminé ,Votre note est : " + note);
            }
            else
            {
                Console.WriteLine("Les valeurs renseignés sont incorrectes (bornes,possibilite)");
            }
            Console.Read();

    }

}

