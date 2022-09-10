using Celeste.Mod;

namespace SSUnlimited.RandomDeath
{
	public class RandomDeathSettings : EverestModuleSettings
	{
		[SettingName("MODOPTIONS_RANDOMDEATH_ENABLED")]
		public bool Enabled { get; set; } = false;
		
		[SettingName("MODOPTIONS_RANDOMDEATH_RANDOMNESS"),SettingSubText("MODOPTIONS_RANDOMDEATH_RANDOMNESS_SUBTEXT")]
		public DeathRandomness Randomness { get; set; } = DeathRandomness.Normal;
		
		[SettingName("MODOPTIONS_RANDOMDEATH_KILLEVENIFINVINCIBLE"),SettingSubText("MODOPTIONS_RANDOMDEATH_KILLEVENIFINVINCIBLE_SUBTEXT")]
		public bool KillEvenIfInvincible { get; set; } = false;

		public enum DeathRandomness
		{
			ExtremelyRare,
			Rare,
			Normal,
			SemiCommon,
			MoreCommon,
			Unplayable
		}
	}
}
