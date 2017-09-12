using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3D : MonoBehaviour {

	public GameObject mover;
	public Vector3 mvtamount;

	// Use this for initialization
	void Start () {
	mvtamount =new Vector3 (1,0,0);
		
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.Space)) { Debug.Log ("true");
	mover.transform.position += mvtamount; } 

	if(Input.GetKeyDown(KeyCode.W))  { Debug.Log ("true");
	mover.transform.position -= mvtamount; } 


	else { Debug.Log ("false");}


	}
