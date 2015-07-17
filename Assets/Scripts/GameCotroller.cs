using UnityEngine;
using System.Collections;

public class GameCotroller : MonoBehaviour {

	public PlayerController player1;
	public PlayerController player2;

	// time between beats
	public float beat = 1;
	// time after the sweetspot until
	// ----------x------------|
	//    beat ideal offset missed
	public float offset = 0.1f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("pullMoves",beat + offset,beat);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void pullMoves() {
		MoveSelection move1 = player1.getSelectedMove ();
		if (move1 != null) {
			float beatTime = Time.time - offset;
			float timeDifferenz = move1.timing - beatTime;
			Debug.Log (move1.move + " " + timeDifferenz);
		} else {
			Debug.Log ("skipped beat");
		}
	}
}
