using System;
using Celeste;
using Celeste.Mod;
using Microsoft.Xna.Framework;
using Monocle;

namespace SSUnlimited.RandomDeath
{
	public class RandomDeathModule : EverestModule
	{
		public static RandomDeathModule Instance;

		public override Type SettingsType => typeof(RandomDeathSettings);
		public static RandomDeathSettings Settings => (RandomDeathSettings)Instance._Settings;

		public RandomDeathModule()
		{
			Instance = this;
		}

		public override void Load()
		{
			On.Celeste.Player.Update += PlayerUpdate;
			On.Celeste.Player.Added += PlayerAdded;
		}

		public override void Unload()
		{
			On.Celeste.Player.Update -= PlayerUpdate;
			On.Celeste.Player.Added -= PlayerAdded;
		}

		private void PlayerAdded(On.Celeste.Player.orig_Added orig, Player self, Scene scene)
		{
			orig.Invoke(self, scene);
			if (RandomDeathModule.Settings.Enabled)
			{

			}
		}

		private void PlayerUpdate(On.Celeste.Player.orig_Update orig, Player player)
		{
			orig.Invoke(player);
			bool invincible = RandomDeathModule.Settings.KillEvenIfInvincible;
			Calc.PushRandom((int)(SaveData.Instance.Time % 2147483647L));
			int num, num2;
			if (player != null && RandomDeathModule.Settings.Enabled)
			{
				switch (Settings.Randomness)
				{
					case RandomDeathSettings.DeathRandomness.ExtremelyRare:
						num = Calc.Random.Next(0, 100000);
						num2 = Calc.Random.Next(0, 101000);

						if (num == num2)
						{
							player.Die(Vector2.Zero, invincible, false);
						}
						break;

					case RandomDeathSettings.DeathRandomness.Rare:
						num = Calc.Random.Next(0, 35000);
						num2 = Calc.Random.Next(0, 35250);

						if (num == num2)
						{
							player.Die(Vector2.Zero, invincible, false);
						}
						break;

					default:
					case RandomDeathSettings.DeathRandomness.Normal:
						num = Calc.Random.Next(0, 15000);
						num2 = Calc.Random.Next(0, 15250);

						if (num == num2)
						{
							player.Die(Vector2.Zero, invincible, false);
						}
						break;
					
					case RandomDeathSettings.DeathRandomness.SemiCommon:
						num = Calc.Random.Next(0, 4500);
						num2 = Calc.Random.Next(0, 4525);

						if (num == num2)
						{
							player.Die(Vector2.Zero, invincible, false);
						}
						break;

					case RandomDeathSettings.DeathRandomness.MoreCommon:
						num = Calc.Random.Next(0, 2000);
						num2 = Calc.Random.Next(0, 2050);

						if (num == num2)
						{
							player.Die(Vector2.Zero, invincible, false);
						}
						break;

					case RandomDeathSettings.DeathRandomness.Unplayable:
						num = Calc.Random.Next(0, 250);
						num2 = Calc.Random.Next(0, 275);

						if (num == num2)
						{
							player.Die(Vector2.Zero, invincible, false);
						}
						break;
				}
			}
		}
	}
}