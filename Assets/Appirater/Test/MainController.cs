using UnityEngine;
using UnityEngine.UI;


namespace Appirater.Test
{
	public class MainController : MonoBehaviour {
		public string AppId = "552035781";
		public int DaysUntilPrompt = 1;
		public int UsesUntilPrompt = 10;
		public int SignificantEventsUntilPrompt = -1;
		public int TimeBeforeReminding = 2;
		public bool Debug = true;
		
		// Use this for initialization
		void Start () {
			InitAppirater();
			GameObject.Find("InitButton").GetComponent<Button>().onClick.AddListener(InitAppirater);
			GameObject.Find("EventButton").GetComponent<Button>().onClick.AddListener(Appirater.DidSignificantEvent);
		}
	
		void InitAppirater()
		{
			Appirater.Init(AppId, DaysUntilPrompt, UsesUntilPrompt,
				SignificantEventsUntilPrompt, TimeBeforeReminding, Debug);
		}
	}
}
