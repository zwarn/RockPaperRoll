using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private MoveSelection selectedMove;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void selectMove (Move move)
	{
		if (selectedMove == null) {
			selectedMove = new MoveSelection(move, Time.time);
			Debug.Log ("selected : " + move);
		}
	}

	public MoveSelection getSelectedMove() {
		MoveSelection result = selectedMove;
		selectedMove = null;
		return result;
	}
}
