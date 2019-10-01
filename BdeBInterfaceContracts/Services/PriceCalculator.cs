using BdeBInterfaceContracts.Models;

namespace BdeBInterfaceContracts.Services
{
    public interface IPriceCalculator
    {
        #region EX 4.0 (Sprint 3) (Aller un peu plus loin)

        // EX 4.0
        // Pour notre troisième Sprint, notre client veut que l'on implémente
        // une fonctionnalité de rabais pour les clients membres du programme
        // Avantages, qui devraient recevoir un rabais de 10% sur tous leurs
        // achats.
        // Commençons par ajouter une méthode à cette interface, afin de pouvoir
        // définir deux implémentations différentes : une pour les clients
        // membres du programme, et l'autre pour les autres clients.

        // La méthode peut s'appeller "GetPrice", devrait prendre un Product
        // en paramètre, et retourner un decimal.

        // Une fois fait, sautez à EX 4.1.

        #endregion
    }

    public class DefaultPriceCalculator : IPriceCalculator
    {
        #region EX 4.1

        // EX 4.1
        // Écrivez l'implémentation pour le contrat de l'interface
        // IPriceCalculator. Comme il s'agit du prix régulier, ici, ça ne
        // devrait pas être trop compliqué.
        // Une fois fait, sautez à EX 4.2.

        #endregion
    }

    public class AdvantagesMemberPriceCalculator : IPriceCalculator
    {
        private const decimal StandardPriceMultiplier = 0.9m;

        #region EX 4.2

        // EX 4.2
        // Écrivez l'implémentation pour le contrat de l'interface
        // IPriceCalculator. Par contre, cette fois-ci, il faut ajouter le
        // rabais au prix! Utilisez la constante plus haut pour y arriver.
        // Allez ensuite à EX 4.3.

        #endregion
    }

    #region EX 5.0 (Sprint 4) (Avancé)

    // EX 5.0
    // Dans le sprint 5, notre client voudrait qu'on ajoute les fonctionnalités
    // de rabais pour les Caissiers et les Gestionnaires.
    // Pour l'instant, commençons par les Caissiers : ceux-ci auront 20% de
    // rabais sur leurs achats.
    // Il faudra faire le même changement dans les UserExtensions, mais tout
    // devrait normalement fonctionner une fois fait.
    // Commencez par créer la classe "CashierPriceCalculator" et assurez-vous
    // qu'elle implémente l'interface IPriceCalculator.
    // Une fois fait, dirigez-vous vers les UserExtensions pour y ajouter le
    // code nécessaire pour que le bon IPriceCalcultator soit retourné selon
    // le rôle du User.

    #endregion

    #region EX 6.0 (Sprint 4) (Avancé)

    // EX 6.0
    // Pour finir le Sprint 5, il nous reste à implémenter la fonctionnalité
    // de rabais pour les Gestionnaires. Comme le rabais est en dollars,
    // plutôt qu'en pourcentage, l'implémentation sera différente.
    // Cela montre la grande flexibilité d'un patron Stratégie : la façon
    // dont la Stratégie fonctionne est isolée, et pourtant, à peu près aucun
    // changement en-dehors de la classe n'est nécessaire.
    // Utilisez tout ce que nous avons vu jusqu'à présent pour implémenter
    // cette classe, qui implémente le contrat de l'interface IPriceCalculator.
    // Une fois que vous aurez fini avec le Sprint 5, faites un test de votre
    // Sprint! Assurez-vous que tout fonctionne correctement, y compris pour
    // les clients qui ne sont pas des membres Avantages.
    // Vous êtes prêts pour votre dernière démo au client!

    #endregion

    // EX 7.0 (Sprint 5) (Pour les téméraires)
    // Il est maintenant temps de se pencher sur un injecteur de dépendances.
    // Il s'agit d'une classe qui possède une méthode statique nous permettant
    // de lui demander de nous donner l'instance d'une interface.
    // Comme il peut y avoir plus d'une classe pour une même interface,
    // l'injecteur doit préalablement configuré par les développeurs.
    // Pour cet exercice, utilisez un Dictionary pour associer une interface
    // avec la classe qui devrait être utilisée pendant l'exécution du
    // programme.
    // Les deux avantages principaux d'un tel système sont de pouvoir remplacer
    // l'implémentation d'une interface par une autre, par exemple pour des
    // des raisons de performance ou de sécurité, dans le cadre d'un
    // refactoring, et de pouvoir substituer les implémentations originales par
    // de fausses implémentations dans le cadre de tests unitaires, par exemple
    // pour éviter d'envoyer de vrais courriels à de vrais utilisateurs...
    // Votre classe devrait avoir deux méthodes : "RegisterDependency" et
    // "GetDependency". Vous devriez idéalement utiliser un type générique
    // pour profiter pleinement des fonctionnalités de C#, mais libre à vous
    // d'en gérer l'implémentation. Créez ensuite une interface pour tous les
    // services dans l'application, et assurez-vous d'obtenir l'instance de ce
    // service par le biais de votre injecteur de dépendances, plutôt que de
    // faire des "new SortingService()" un peu partout!

    // EX 8.0+ (Wow)
    // Vous avez tout fini?!
    // Amusez-vous! Cet exercice n'est qu'une excuse à vous pratiquer à faire
    // de la programmation de niveau entreprise.
    // Par exemple, vous voyez le projet "Tests"? Allez écrire des tests
    // unitaires pour chaque méthode publique du projet principal!
    // Ou encore, ajoutez la capacité à votre injecteur de dépendances de
    // retourner la bonne implémentation du IPriceCalculator selon un UserRole.
    // Vous aurez sans doute à changer votre implémentation initiale.
    // Pourquoi ne pas écrire une implémentation à la main du SortingService?
    // Pour l'instant, on utilise LINQ, on pourrait s'amuser à écrire un tri
    // différent, et à le remplacer dans l'injecteur de dépendances.
    // Etc.
    // Mais surtout, amusez-vous!
}
