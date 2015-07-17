using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	public string rockButton;
	public string paperButton;
	public string stoneButton;
	private PlayerController player;

	// Use this for initialization
	void Start () {
		player = GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton (rockButton)) {
			player.selectMove (Move.ROCK);
		} else if (Input.GetButton (paperButton)) {
			player.selectMove (Move.PAPER);
		} else if (Input.GetButton (paperButton)) {
			player.selectMove (Move.SCISSOR);
		}
	}
}
