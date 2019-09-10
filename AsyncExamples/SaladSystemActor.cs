using Akka.Actor;
using System.Collections.Generic;
using System.IO;

namespace AsyncExamples
{
    internal class SaladSystemActor : ReceiveActor
    {
        public SaladSystemActor(IActorRef saladActor)
        {
            var saladIngredients = new List<int>();
            var replies = string.Empty;

            Receive<string>(message =>
            {
                var typeOfSalad = message.Split(' ')[1].TrimStart();
                foreach(var letter in typeOfSalad)
                {
                    saladIngredients.Add(letter);
                }
                foreach (var saladIngredient in saladIngredients)
                {
                    saladActor.Tell(saladIngredient);
                }                           
            });
            Receive<char>(message =>
            {
                replies += message;
                File.AppendAllText("salad.txt", replies);            
            });
        }
    }
}