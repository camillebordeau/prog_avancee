using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Poetus
{
    class Program
    {
        //-------------DEFINITION DES CLASSES------------------
        class Entite
        {
            public string pseudo ;
            public int energie ;
            public int ligne ;
            public int colonne ;
        }

        //-------------DEFINITION DES FONCTIONS------------------

        static int generer_coor()
        // fonction qui génère les coordonnees du joueur et du point d'arrivee au hasard
        {
            return new Random().Next(1, 21);
        }

        //-----------------------------------------
       
        static bool test_bouger(string dep, int ligne, int colonne)
        // fonction qui renvoit si le mouvement est possible
        {
            bool resultat = false;
            if (dep == "h" || dep == "b" || dep == "g" || dep == "d")
            {
                if (dep == "h" & ligne > 0)
                    {resultat = true;}
                else if (dep = "b" & ligne < 19)
                    {resultat = true;}
                else if (dep == "g" & colonne > 0)
                    {resultat = true;}
                else if (dep == "d" & colonne < 19)
                    {resultat = true;}
            }
            return resultat;
        }

        //-----------------------------------------

        static string[] deplacer_plateau(int ligne, int colonne, string[,] plateau, string dep)
        // fonction qui renvoie le plateau modifié après le déplacement
        {
            string val = "";
            if (dep == "h")
            {
                val = plateau[ligne-1, colonne];
                plateau[ligne-1 , colonne] = plateau[ligne , colonne];
                plateau[ligne , colonne] = "-";

            }

            else if (dep == "b")
            {
                val = plateau[ligne+1, colonne];
                plateau[ligne+1 , colonne] = plateau[ligne , colonne];
                plateau[ligne , colonne] = "-";
            }
               
            else if (dep == "d")
            {
                val = plateau[ligne, colonne+1];
                plateau[ligne , colonne+1] = plateau[ligne , colonne];
                plateau[ligne , colonne] = "-";
            }
            else
            {
                val = plateau[ligne, colonne-1];
                plateau[ligne , colonne-1] = plateau[ligne , colonne];
                plateau[ligne , colonne] = "-";
            }               
        }

        return plateau;

         //-----------------------------------------

        static void int[,] trouver_case(joueur.ligne, joueur.colonne, dep, plateau)
        {
            string val = ""; 
            if (dep == "h")
            {
                val = [ligne+1, colonne];
            }
            else if (dep == 'b')
            {
                val = [ligne+1, colonne];
            }
            else if (dep == 'g')
            {
                val = [ligne, colonne-1];
            }
            else 
            {
                val = [ligne, colonne+1];
            }

            return val; 
        }

         //-----------------------------------------
        
        static void proverbe()
        // fonction qui donne au hasard un gentil proverbe
        {
            int a = new Random().Next(1, 21);
            if (a==1)
            {
                string p1 = "Un(e) de perdu(e), 10 de retrouvé(e)s";
            }
            else if (a==2)
            {
                string p2 = "Demain est un jour meilleur qu'aujourd'hui";
            }
            else if (a==3)
            {
                string p3 = "Après la pluie, vient le beau temps";
            }
            else if (a==4)
            {
            string p4 = "L'espoir maintient la vie";
            }
            else if (a==5)
            {
                string p5 = "Rien ne vaut la vie";
            }
            else if (a==6)
            {
                string p6 = "Ne regarde pas en arrière, c'est fait";
            }
            else if (a==7)
            {
                string p7 = "Ne te mets pas de barrières, fais";
            }
            else if (a==8)
            {
                string p8 = "Profitez la vie ";
            }
            else if (a==9)
            {   
                string p9 = "Carpe Diem !";
            }
            else if (a==10)
            {
                string p10 = "La plus perdue de toutes les journées est celle où l'on n'a pas ri";
            }
            else if (a==11)
            {
                string p11 = "Il n'y a pas de mauvaise vie, mais des mauvais jours";
            }
            else if (a==12)
            {
                string p12= "Vivons d'amour et de café";
            }
            else if (a==13)
            {
                string p13= "";
            }
            else if (a==14)
            {
                string p14= "";
            }
            else if (a==15)
            {
                string p15= "";
            }
            else if (a==16)
            {
                string p16= "";
            }
            else if (a==17)
            {
                string p17= "";
            }
            else if (a==18)
            {
                string p18= "";
            }
            else if (a==19)
            {
                string p19= "";
            }
            else if (a==20)
            {
                string p20= "";
            }
            Console.WriteLine(a);
           
        }


        //-----------------------------------------

        static void string gentil()
        // fonction qui donne au hasard une gentille réplique
        {
            int a = new Random().Next(1, 9);
            if (a==1)
            {
                string g1 = "Tu as bonne mine aujourd'hui";
            }
            else if (a==2)
            {
                string g2 = "Tu sens bon";
            }
            else if (a==3)
            {
                string g3 = "J'aime bien comment tu es habillé(e)";
            }
            else if (a==4)
            {
                string g4 ="Je suis content de te voir";
            }
            else if (a==5)
            {
                string g5 = "Tu es très élégant(e)";
            }
            else if (a==6)
            {
                string g6 = "Je t'apprécie beaucoup tu sais";
            }
            else if (a==7)
            {
                string g7 = "Il me tarde d'aller me balader avec toi";
            }
            else if (a==8)
            {
                string g8 = "Ton teint est très joli";
            Console.WriteLine(a);
        }

        //------------CORPS PRINCIPAL DU PROGRAMME-------------------
        static void Main()
        {
            string[,] plateau = string[20,20]; // un tableau de chaîne de caractères
            int l = 0;
            int c = 0;
            while (l <20)
            {
                while (c < 20)
                {
                    plateau[l,c] = "-";
                    c +=1;
                }
                l +=1;
            }

            
            int compteur = 0;
            int ligne = 0;
            int colonne = 0;

            while (compteur < 40)
            {
                ligne = generer_coor();
                colonne = generer_coor();
                plateau[ligne,colonne] = "N";
                compteur += 1;
            }
            compteur = 0;

            while (compteur < 20)
            {
                ligne = generer_coor();
                colonne = generer_coor();
                plateau[ligne,colonne] = "P";
                compteur += 1;
            }
            compteur = 0;

            while (compteur < 10)
            {
                ligne = generer_coor();
                colonne = generer_coor();
                plateau[ligne,colonne] = "G";
                compteur += 1;
            }
            compteur = 0;

            while (compteur < 5)
            {
                ligne = generer_coor();
                colonne = generer_coor();
                plateau[ligne,colonne] = "M";
                compteur += 1;
            }

            Entite joueur = new Entite();
            joueur.energie = 10; //initialisation à 10 points d'énergie
            joueur.ligne = generer_coor();
            joueur.colonne = generer_coor();
            Console.WriteLine("Comment appelez vous votre personnage?");
            joueur.pseudo = Console.ReadLine();
            Console.Write("Bienvenue " + joueur.pseudo + ", c'est parti !");
            plateau[joueur.ligne , joueur.colonne] = "J";
            
            Entite arrivee = new Entite();
            arrivee.ligne = generer_coor();
            arrivee.colonne = generer_coor();
            plateau[arrivee.ligne , arrivee.colonne] = "A";
           
            Console.ReadKey();
            // le plateau est défini et rempli.

            while (joueur.ligne != arrivee.ligne || joueur.colonne != arrivee.colonne)
            { // tant que le joueur n'est pas arrivé, la partie continue

                // AFFICHER LE PLATEAU
                
                string dep = ""; // haut, bas, gauche ou droite (h, b, g ou d)
                bool bouger_possible = false;
                while (bouger_possible == false)
                {
                    Console.Write(plateau);
                    Console.WriteLine("Quel déplacement voulez vous faire " + joueur.pseudo+" ? 'b' pour en bas, 'h' pour en haut, 'g'pour gauche et 'd' pour droite");
                    dep = Console.ReadLine();
                    bouger_possible = test_bouger(dep, joueur.ligne, joueur.colonne);
                }
                val = trouver_case(joueur.ligne, joueur.colonne, dep, plateau);
                string[,] nv_plateau = string[20,20]; // un tableau de chaîne de caractères
                nv_plateau = deplacer_plateau(joueur.ligne,joueur.colonne, plateau, dep);
                
                if (val == "N")
                {
                    joueur.energie +=1;
                    Console.WriteLine("Miam miam, du cassoulet !");
                }
                else if (val == "P")
                {
                    Console.WriteLine("Voici un gentil proverbe");
                    proverbe();
                    energie -=1;
                }
                
                else if (val = "G")
                {
                    Console.WriteLine("Oh un habitant qui vous veut du bien ! Ecoutez le...");
                    gentil();
                    
                }

                else if (val == "M")
                {
                    Console.WriteLine("Oh un habitant qui vous veut du mal.. N'écoutez pas ce qu'il vous dit..");
                    energie -=1;
                }

                else if (val == "A")
                {
                    Console.WriteLine("Bravo ! Vous êtes arrivé(e) au sommet du bonheur ! Profitez de la vue.");
                }


                Console.ReadKey();


            }

        }

    }

}



    