using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        speed = 10.0F;
        rb = GetComponent<Rigidbody>();
    }
	// Update is called once per frame
	void FixedUpdate () {
        float moveHoizontal = Input.GetAxis("Horizontal");
        float moveVertical= Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHoizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
    }
}
