using Akka.Actor;

namespace AsyncExamples
{
    internal class SaladIngredientActor : ReceiveActor
    {
        public SaladIngredientActor()
        {
            Receive<int>(message =>
            {
                Sender.Tell((char)message);
            });
        }
    }
}