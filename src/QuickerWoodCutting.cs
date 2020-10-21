using MelonLoader;
using System.IO;
using UnityEngine;


namespace QuickerWoodCutting
{
	internal class QuickerWoodCutting : MelonMod
	{

		public override void OnApplicationStart()
		{
			Debug.Log($"[{InfoAttribute.Name}] Version {InfoAttribute.Version} loaded!");
			Settings.OnLoad();
		}
	}
}