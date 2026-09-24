using Microsoft.Agents.AI;

namespace Contoso.ChatHub
{
    public interface IAgentInitializer
    {
        AIAgent? AIAgent { get; }
        void Inilitialize(string agentIdentifier);
    }
}
