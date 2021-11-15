using Stats_Core.Events;
using Stats_Core.Extensions;
using Stats_Core.Stats.player;
using UnityEngine;
using static Stats_Core.Stats.equiptment.BuilderTool;


using UWE;
using System.Collections;

namespace Stats_Core
{
    internal class TempMod : MonoBehaviour
    {
        public void PlayerUpdated(object sender, Player_Events.PlayerEventArgs e)
        {
            bool shiftPressed = Input.GetKeyDown(KeyCode.LeftShift);
            if (!shiftPressed)
                return;


        }
    }
}
