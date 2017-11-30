using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Appirater
{
	public class Appirater
	{
	
		[DllImport("__Internal")]
		private static extern void _Init(string appId, int daysUntilPrompt, int usesUntilPrompt,
			int significantEventsUntilPrompt, int timeBeforeReminding, bool debug);
	
	
		public static void Init(string appId, int daysUntilPrompt, int usesUntilPrompt,
			int significantEventsUntilPrompt, int timeBeforeReminding, bool debug)
		{
			_Init(appId, daysUntilPrompt, usesUntilPrompt, significantEventsUntilPrompt, timeBeforeReminding, debug);
		}
	
		[DllImport("__Internal")]
		private static extern void _DidSignificantEvent();
	
		public static void DidSignificantEvent()
		{
			_DidSignificantEvent();
		}
	
		[DllImport("__Internal")]
		private static extern  void _AppGoesToBackground(bool idInBackground);
	
		public void AppGoesToBackground(bool isInBackground)
		{
			AppGoesToBackground(isInBackground);
		}
	}
}
