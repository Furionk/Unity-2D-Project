using UnityEngine;
using System.Collections;

public class OtherScript : MonoBehaviour {

	public GameObject whichObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		whichObject.transform.Translate(0,1*Time.deltaTime,0);
	}
}
