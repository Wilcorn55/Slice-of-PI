using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
	public Transform target;
	public Vector3 offset;
	public static PlayerCameraController mainCam;

	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		mainCam = this;
	}

	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = target.position + offset;
	}
}
