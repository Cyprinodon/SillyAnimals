/* la directive using permet de spécifier les espaces de noms que l'on veut omettre d'écrire dans le reste du fichier.
 * C'est également un bon moyen de savoir quels "groupes" d'objets sont utilisés tout au long du fichier.*/

// La déclaration d'une directive using se fait avec le mot-clé 'using' suivi du nom de l'espace de noms
using System;

/* Il est également possible de créer un alias lors de la déclarationd'une directive using. 
 * C'est utile si l'on souhaite raccourcir un espace de nom.
 * Pour déclarer un alias, il faut utiliser le mot-clé 'using' suivi de l'alias que l'on veut donner 
 * suivi du signe '=' suivi du nom de l'espace de noms auquel on veut appliquer l'alias.
 */
using UnAlias = UnEspace.DeNoms;

/* Un espace de noms permet d'éviter que deux éléments de syntaxe pourvu du même nom n'entrent en conflit.
 * Tous ce qui se trouve entre les accolades se verra considéré comme faisant partie de l'espace de noms défini.
 * Pour définir un espace de nom, il faut utiliser le mot-clé 'namespace' suivi du nom que l'on veut lui donner.
 */
namespace UnEspace.DeNoms
{
    /* Une classe permet de définir un nouveau Type d'objet : ses propriétés, son comportement, et son instanciation.
     * Pour définir une nouvelle classe d'objets, il faut utiliser le mot-clé 'class' suivi du nom 
     * que l'on veut attribuer au Type d'objet. Le nom d'une classe commence toujours par une Majuscule.
     */
    public class Exemple
    {
        /* Une propriété est une variable spéciale capable de stocker une donnée et de la rendre accessible dans
         * toute la classe et, selon son accès (public, protected, private) aux classes filles ainsi qu'à l'exterieur.
         * Une propriété se définit par son mot-clé d'accès suivi du type de données que la propriété est capable de stockée
         * suivi du nom que l'on veut donner à la propriété.
         * Usuellement, les propriétés définissent ce qu'est un objet ou encore ce qui le compose.
         */
        public int Propriété;
        public string AutrePropriété;

        /* Un constructeur est une méthode spéciale appellée à l'instanciation d'un nouvel objet de cette classe.
         * Cette méthode se démarque des autres méthodes par l'absence d'un type de retour (elle ne retourne rien) et le fait
         * qu'elle porte le même nom que la classe qui la contient.
         * Usuellement, un constructeur est utilisé pour initialiser l'état d'un objet au moment de son instanciation.
         * Pour définir un constructeur, il faut toujours commencer par le mot-clé public, suivi du nom de la classe
         * puis d'une paire de parenthèses. Entre parenthèses peut figurer la déclaration de paramètres, qui permettront
         * au constructeur d'utiliser des valeurs sous les noms de ces paramètres lorsqu'il sera appellé et que des 
         * valeurs lui seront données.
         * Un paramètre se déclare en commençant par le type de données qu'il peut contenir suivi de son nom.
         * Pour définir plusieurs paramètres, il faut les séparer d'une virgule.
         */
        public Exemple(int paramètre, string autreParamètre)
        {
            /* Une instruction est un ensemble d'éléments syntaxique se terminant par une virgule.
             * Ici, cette instruction assignera la valeur stockée par le paramètre 'paramètre' à la propriété 'Propriété' 
             * lors de la création d'un nouvel objet de type 'Exemple'.
             */
            Propriété = paramètre;
            AutrePropriété = "Une chaîne de caractères";
        }

        /* Une méthode est une construction de langage capable d'accepter des paramètres, 
         * d'exécuter une série d'instructions contenue entre accolades et de retourner un résultat.
         * usuellement, les méthodes définissent les comportements d'un objet et portent des noms commençant par un verbe.
         * Pour définir une méthode, il faut commencer par son mot-clé d'accès suivi de son type de retour suivi de son nom
         * suivi de parenthèses. à l'intérieur des parenthèses peuvent être déclarés des paramètres.
         */
        public int FaireUnTruc(int encoreUnAutreParamètre)
        {
            /* Le mot-clé 'var' permet de déclarer une variable dont le type de donnée sera déterminé 
             * par le compilateur durant l'exécution selon le type de l'instruction qui sera assigné à la variable.
             * Ici le résultat de 'propriété + encoreUnAutreParamètre' sera un entier car ces valeurs sont des entiers.
             * donc, au moment de l'exécution, le compilateur déterminera que la variable 'résultat' 
             * ne peut stocker que des nombres entiers.
             */
            var résultat = Propriété + encoreUnAutreParamètre;

            /* Le mot clé 'return' permet de définir une instruction qui sera retournée comme valeur par la méthode à la fin de son exécution. 
             * La valeur retournée doit être du même type que le type de retour indiqué dans l'en-tête de la méthode.
             */
            return résultat;
        }
    }
}

namespace UnEspace.Principal
{
    class Programme
    {
        /* Cette méthode sert de point d'entrée pour l'exécution du programme. Elle sera toujours écrite de cette manière.
         * Le mot-clé 'static' permet d'utiliser la méthode directement depuis la classe plutôt que de devoir instancier un objet.
         * Une méthode ou une classe 'static' ne peut pas utiliser de propriétés non statiques ni le mot-clé 'this' (qui représente l'objet courant)
         * Utilisé sur une classe, ce mot-clé indique que la classe ne peut pas être utilisée pour instancier des objets (et ne possède donc pas de constructeur).
         */
        static void Main()
        {
            /* Cette instruction effectue plusieurs opérations en une seule ligne.
             * Une variable 'exemple' dynamiquement typée grâce au mot-clé 'var' est déclarée.
             * Un nouvel objet Exemple provenant de 'UnAlias' qui est un alias pour l'espace de Nom 'UnEspace.DeNom' est instancié
             * avec la valeur 5 pour le premier paramètre et "une valeur" pour le second paramètre.
             * l'objet 'Exemple' est assigné à la variable 'exemple'.
             */
            var exemple = new UnAlias.Exemple(5, "une valeur");

            /* Ici, l'instruction appelle la méthode 'FaireUnTruc()' de l'objet exemple en lui fournissant la valeur '3' et
             * utilise la valeur qu'elle retourne comme paramètre pour appeller la méthode 'WriteLine()' de la classe statique Console.
             * La méthode WriteLine() affiche dans la console ce qui lui est passé comme paramètre.
             */
            Console.WriteLine(exemple.FaireUnTruc(3));
        }
    }
}
