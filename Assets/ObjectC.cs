using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Communicatio method C
// Delegate from Event Manager with data.
// This example illustrates how to dispatch a string (data) and event from one objects script to another.

public class ObjectC : MonoBehaviour {

	void OnEnable()
	{
		EventManager.DispatchCustomEventWithData += LogCustomEventC;
	}

	void OnDisable()
	{
		EventManager.DispatchCustomEventWithData -= LogCustomEventC;
	}

	void LogCustomEventC(string str)
	{
		Debug.Log(str + " Object C");
	}

}
