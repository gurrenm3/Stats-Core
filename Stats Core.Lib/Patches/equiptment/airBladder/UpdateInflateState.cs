using HarmonyLib;
using UnityEngine;
using static Stats_Core.Stats.equiptment.AirBladderData;

namespace Stats_Core.Patches
{
	/// <summary>
	/// This patch is basically a duplicate of the original <see cref="AirBladder.UpdateInflateState"/>. Needed to modify hardcoded values
	/// </summary>
	[HarmonyPatch(typeof(AirBladder), nameof(AirBladder.UpdateInflateState))]
	internal class Airbladder_UpdateInflateState
	{
		private static Airbladder_UpdateInflateState instance = new Airbladder_UpdateInflateState();
		private static AirBladder airBladder;

		[HarmonyPrefix]
		internal static bool Prefix(AirBladder __instance)
		{
			airBladder = __instance;
			instance.ExecutePatch();
			return false;
		}


		private OxygenManager oxygenManager;
		private float amountToConsume;
		private void ExecutePatch()
        {
			oxygenManager = Player.main.GetComponent<OxygenManager>();
			amountToConsume = Time.deltaTime * O2PerSecond;

			if (airBladder.inflating)
				HandleInflating();
			else if (airBladder.deflating)
				HandleDeflating();
		}

		private void HandleInflating()
        {
			if (airBladder.oxygen > MaxOxygen)
				return;

			float amountToRemove = Mathf.Min(amountToConsume, MaxOxygen - airBladder.oxygen);
			if (amountToRemove < 0f)
			{
				airBladder.inflating = false;
				return;
			}

			float remainingO2 = oxygenManager.RemoveOxygen(amountToRemove);
			airBladder.oxygen += remainingO2;
			SafeAnimator.SetFloat(airBladder.animator, "inflate", airBladder.oxygen / MaxOxygen);
		}

		private void HandleDeflating()
        {
			float num3 = Mathf.Min(amountToConsume, airBladder.oxygen);
			if (num3 < 0f)
			{
				airBladder.deflating = false;
				return;
			}

			airBladder.oxygen -= num3;
			if (Player.main.IsUnderwater())
				Utils.PlayOneShotPS(airBladder.firstPersonBubbleParticlesPrefab, airBladder.bubblesExitPoint.transform.position, Quaternion.identity, null);

			SafeAnimator.SetFloat(airBladder.animator, "inflate", airBladder.oxygen / MaxOxygen);
		}
	}
}