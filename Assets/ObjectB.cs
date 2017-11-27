using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Communicatio method B
// Event recieved via broadcast from event manager

public class ObjectB : MonoBehaviour {

	void ChatBotMessageEvent(string str) {
		Debug.Log (str + "Object B");
	}

}
