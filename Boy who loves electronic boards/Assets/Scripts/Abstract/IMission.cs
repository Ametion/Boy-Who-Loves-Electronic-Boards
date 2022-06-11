namespace Components.Abstract
{
    public interface IMission
    {
        string missionName { get; }
        int reward { get; }
        IBroken pieceToRepair { get; }
    }
}