using Akka.Actor;
using System.Collections.Generic;
using System.IO;

namespace AsyncExamples
{
    internal class SaladSystemActor : ReceiveActor
    {
        public SaladSystemActor(IActorRef saladActor)
        {
            var replies = string.Empty;
            var saladIngredients = new int[] { 83, 65, 76, 65, 68 };
            Receive<string>(message =>
            {
                foreach(var saladIngredient in saladIngredients)
                {
                    saladActor.Tell(saladIngredient);
                }                           
            });

            Receive<char>(message =>
            {
                File.AppendAllText("salad.txt", replies);                
            });
        }
    }
}