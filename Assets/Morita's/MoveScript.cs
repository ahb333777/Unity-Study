using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			GameObject.transform.position += new Vector3(1,0,0);
		}
	}
}
