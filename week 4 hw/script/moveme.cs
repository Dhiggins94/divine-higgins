using UnityEngine;
using System.Collections;

public class moveme : MonoBehaviour {
	public Vector3 speed = new Vector3 (0f,0f,0f);
	public GameObject[] moveables;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	



		Debug.Log (GetComponent<Transform> ().position);

		//instead of doing GameObject.Getcomponent<Transform>().......
		//GetComponent<Transform> ().position += speed;


		//for (int i = 0; i < someNumber; i++){
		foreach (GameObject thingtomove in	 moveables) {
			thingtomove.transform.Translate(speed);
		}
	}
}
