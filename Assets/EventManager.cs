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

    private void Start()
    {
        // Broadcast event to ObjectB (this can be to any gameObject within the EventManager gameObject)
        BroadcastMessage("ChatBotMessageEvent", "Hello World from ");
        if (DispatchCustomEvent != null)
            DispatchCustomEvent();
        string str = "Hello World from";
        if (DispatchCustomEventWithData != null)
            DispatchCustomEventWithData(str);
    }

    /*
     * For debugging - GUI  
    */
    
    /* void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if (DispatchCustomEvent != null)
                DispatchCustomEvent();
        }
    }*/

}
