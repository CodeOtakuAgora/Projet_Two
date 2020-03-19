//on définit toutes les librairies(assembly) dont on a besoins
// dans le fichiers en les important
using System;
using System.Windows.Forms;

// on encapsule toute notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité Program qui est le premier fichier à être chargé lorsqu'on lance le logiciel
     * elle permet de choisir quelle form démarré en premier
     * et d'accésibilité private afin qu'elle ne soit pas accesible depuis n'importe quel form 
     * à la différence des méthodes public
     *
     *
     *  on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
     *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe. 
     *  Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique 
     *  en utilisant le nom de classe lui-même
    */
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        // à une différence près : une classe statique ne peut pas être instanciée.En d’autres termes, 
        // vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
        // Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique 
        // en utilisant le nom de classe lui-même
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
        }
    }
}
