using ModSettings;

namespace QuickerWoodCutting
{
	internal class QuickerWoodCuttingSettings : JsonModSettings
	{
		[Name("Time multiplier when breaking branches")]
        [Description("Time multiplier when chopping or breaking branches - recommened 0.5")]
        [Slider(0.1f, 3f)]
        public float BreakBranchTimeMultiplier = 0.5f;

        [Name("Speed multiplier when chopping limbs")]
        [Description("Speed multiplier when chopping limbs - recommened 0.5)")]
        [Slider(0.1f, 3f)]
        public float BreakLimbTimeMultiplier = 0.5f;
		
	}
	internal static class Settings
	{
		public static QuickerWoodCuttingSettings options;
		public static void OnLoad()
		{
			options = new QuickerWoodCuttingSettings();
			options.AddToModSettings("Quicker Wood Cutting Settings");
		}
	}
}