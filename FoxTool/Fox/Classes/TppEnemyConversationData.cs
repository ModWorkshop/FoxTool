using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppEnemyConversationData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxPath ConversationListDataPath { get; set; }
    }
}