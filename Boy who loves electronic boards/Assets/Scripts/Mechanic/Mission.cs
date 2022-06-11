using Components.Abstract;

namespace Components.Mechanic
{
    public class Mission : IMission
    {
        public string missionName { get; private set; }
        public int reward { get; private set; }
        public IBroken pieceToRepair { get; private set; }

        public Mission(string MissionName, int Reward,  IBroken PieceToRepair)
        {
            missionName = MissionName;
            reward = Reward;
            pieceToRepair = PieceToRepair;
        }
    }
}