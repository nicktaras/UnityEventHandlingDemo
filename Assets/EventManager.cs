using UnityEngine;
using System.Collections;

// This is an example to show how you can send data and events between objects
// when you are not specifically targeting game component parameters you may wish to dispatch
// data to different game objects so they can uniquely act upon the event.

// The examples provided here cover:
// - Delegate events with and without data
// - The use of broadcast (emit data to a game component that is inline or a child of the EventManager parent script).

public class EventManager : MonoBehaviour 
{

	public delegate void CustomAction();
	public static event CustomAction DispatchCustomEvent;

	public delegate void CustomActionWithData(string str);
	public static event CustomActionWithData DispatchCustomEventWithData;

	void OnEnable()
	{   
		// Broadcast event to ObjectB (this can be to any gameObject within the EventManager gameObject)
		BroadcastMessage("ChatBotMessageEvent", "Hello World from ");
		DispatchCustomEvent();
		string str = "Hello World from";
		DispatchCustomEventWithData (str);
	}
		
}