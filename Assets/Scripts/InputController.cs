using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	public string rockButton;
	public string paperButton;
	public string stoneButton;
	public PlayerController player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton (rockButton)) {

		}
	}
}
