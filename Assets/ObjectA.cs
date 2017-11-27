using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Communicatio method A
// Delegate from Event Manager.

public class ObjectA : MonoBehaviour {

	void OnEnable()
	{
		EventManager.DispatchCustomEvent += LogCustomEventA;
	}
		
	void OnDisable()
	{
		EventManager.DispatchCustomEvent -= LogCustomEventA;
	}

	void LogCustomEventA()
	{
		Debug.Log("Hello World from Object A");
	}

}
	