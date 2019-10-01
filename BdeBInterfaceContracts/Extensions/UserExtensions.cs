using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Services;
using System;

namespace BdeBInterfaceContracts.Extensions
{
    public static class UserExtensions
    {
        public static IPriceCalculator GetPriceCalculator(this User user)
        {
            #region EX 4.3

            // EX 4.3
            // Ajoutez ici la logique nécessaire pour retourner le bon
            // IPriceCalculator, selon l'utilisateur donné en paramètre.
            // Comme vous savez que les utilisateurs ayant le UserRole
            // "Membre Avantages" devraient recevoir leur rabais, vous devriez
            // pouvoir implémenter cette fonctionnalité à l'aide d'un switch
            // ou encore de if/else-if/else, selon votre préférence. D'autres
            // designs sont acceptés!

            // ATTENTION! "user" peut être NULL! C'est le cas lorsqu'un client
            // qui n'est pas membre du programme Avantages achète un produit
            // au Café!

            // Nous sommes ici dans une "méthode d'extension", une
            // fonctionnalité de C#. Si vous n'avez jamais écrit une telle
            // méthode, concentrez-vous uniquement sur le scénario (on
            // reçoit un User en paramètre, on veut retourner un
            // IPriceCalculator selon le UserRole du User), et ne vous laissez
            // pas affecter par l'étrangeté des signatures.
            // Une fois fait, allons à EX 4.4.

            #endregion

            throw new NotImplementedException(); // Enlevez cette ligne une fois l'implémentation faite!
        }
    }
}
