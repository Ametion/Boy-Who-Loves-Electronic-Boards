using Components.Abstract;

namespace Components.Mechanic
{
    public class Mission : IMission
    {
        public string MissionName { get; }
        public int Reward { get; }
        public IBroken PieceToRepair { get; }

        public Mission(string missionName, int reward,  IBroken pieceToRepair)
        {
            MissionName = missionName;
            Reward = reward;
            PieceToRepair = pieceToRepair;
        }
    }
}