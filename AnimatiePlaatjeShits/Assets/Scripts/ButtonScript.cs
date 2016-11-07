using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
    private Button previous;
    private Button next;

	// Use this for initialization
	void Start ()
    {
        Button previous = GetComponent<Button>();
        Button next = GetComponent<Button>();
	}
	
	void Update ()
    {
        //previous.onClick.AddListener();
	}
}
