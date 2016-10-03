using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject playerReference;
    private Vector3 offsetValue;
	// Use this for initialization
	void Start () {
        offsetValue = transform.position - playerReference.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = playerReference.transform.position + offsetValue;
	}
}
