using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
	//Variables
	public Transform target;
	public Vector3 offset;
	public static PlayerCameraController mainCam;

	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		mainCam = this;
	}

	//LateUpdate is called once per frame
	//LateUpdate will move the camera position to the players position 
	void LateUpdate()
	{
		transform.position = target.position + offset;
	}
}
