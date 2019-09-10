using Akka.Actor;
using Akka.Routing;
using System;

namespace AsyncExamples
{
    public class Salad
    {
        public static void Make(string typeOfSalad = "")
        {
            var saladSystem = ActorSystem.Create("SaladSystem");
            var saladIngredientActor = saladSystem.ActorOf(Props.Create(() => new SaladIngredientActor()).WithRouter(new RoundRobinPool(5)));
            var saladSystemActor = saladSystem.ActorOf(Props.Create(() => new SaladSystemActor(saladIngredientActor)));
            saladSystemActor.Tell($"Make {typeOfSalad}Salad");
        }
    }
}
