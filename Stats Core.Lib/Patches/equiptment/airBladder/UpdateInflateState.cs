using HarmonyLib;
using UnityEngine;
using static Stats_Core.Stats.equiptment.AirBladder;

namespace Stats_Core.Patches.equiptment.airBladder
{
	[HarmonyPatch(typeof(AirBladder), nameof(AirBladder.UpdateInflateState))]
	internal class Airbladder_UpdateInflateState_Hook
	{
		private static AirBladder airBladder;
		
		[HarmonyPrefix]
		internal static bool Prefix(AirBladder __instance)
		{
			airBladder = __instance;
			Airbladder_UpdateInflateState_Hook patch = new Airbladder_UpdateInflateState_Hook();
			patch.ExecutePatch();
			return false;
		}


		private OxygenManager oxygenManager;
		private float amountTransfered;
		private void ExecutePatch()
        {
			oxygenManager = Player.main.GetComponent<OxygenManager>();
			amountTransfered = Time.deltaTime * O2TransferPerSecond;

			if (airBladder.inflating)
				HandleInflating();
			else if (airBladder.deflating)
				HandleDeflating();
		}

		private void HandleInflating()
        {
			if (airBladder.oxygen > MaxOxygenConsumption)
				return;


			float num = Mathf.Min(amountTransfered, MaxOxygenConsumption - airBladder.oxygen);
			if (num < 0f)
			{
				airBladder.inflating = false;
				return;
			}

			float num2 = oxygenManager.RemoveOxygen(num);
			airBladder.oxygen += num2;
			SafeAnimator.SetFloat(airBladder.animator, "inflate", airBladder.oxygen / MaxOxygenConsumption);
		}

		private void HandleDeflating()
        {
			float num3 = Mathf.Min(amountTransfered, airBladder.oxygen);
			if (num3 < 0f)
			{
				airBladder.deflating = false;
				return;
			}

			airBladder.oxygen -= num3;
			if (Player.main.IsUnderwater())
				Utils.PlayOneShotPS(airBladder.firstPersonBubbleParticlesPrefab, airBladder.bubblesExitPoint.transform.position, Quaternion.identity, null);

			SafeAnimator.SetFloat(airBladder.animator, "inflate", airBladder.oxygen / MaxOxygenConsumption);
		}
	}
}