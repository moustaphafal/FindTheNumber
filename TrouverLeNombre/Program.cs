internal class Program
{
    private static void Main(string[] args)
    {
        bool arret = false;
        int compteur = 10;
        int[] resultats = new int[10] ;

        while( compteur > 0 && arret == false)
        {
            codeSpaghetti :
            Console.WriteLine("Il vous reste "+compteur+" tentatives");
            Console.WriteLine("Hello, Veuillez entrer un nombre compris entre 1 et 10");
            if (resultats == null)
                Console.WriteLine("Le tableau est vide");
            else
            {
                Console.Write("Les dernieres reponses : ");
                foreach( int resultat in resultats)
                {
                    Console.Write(resultat+" ");
                }
                    Console.WriteLine();

            }
            string chaineInt = Console.ReadLine();
            int nbreChoisis ;
            int cp = 10 - compteur;

            if (int.TryParse(chaineInt, out nbreChoisis))
            {
                //resultats.Append(nbreChoisis);
                resultats[cp] = nbreChoisis;
                if (nbreChoisis.Equals(5))
                {
                    Console.WriteLine(" Vous avez gagné !");
                    arret= true;
                }
                else
                {
                    Console.WriteLine("Vous avez perdu !");

                }
            }
            else
            {
                --compteur;
                goto codeSpaghetti;
            }

            --compteur;

        } 
    }
        
}