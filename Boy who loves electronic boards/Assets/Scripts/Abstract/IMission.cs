namespace Components.Abstract
{
    public interface IMission
    {
        string MissionName { get; }
        int Reward { get; }
        IBroken PieceToRepair { get; }
    }
}