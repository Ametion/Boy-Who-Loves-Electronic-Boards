using Components.Mechanic;
using UnityEngine;

namespace Components
{
    public class ControllerForTest : MonoBehaviour
    {
        private void Awake()
        {
            Stuff videoCard = new Stuff("VideoCard", 1000);
            BrokenStuff brokenStuff = new BrokenStuff(videoCard, 250);

            Mission newMision = new Mission("Repair Video Card", 400, brokenStuff);
        }
    }
}