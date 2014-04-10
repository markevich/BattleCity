using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	private int _speed = 5;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var velocity = new Vector3(0, 0, 0);


		if(Input.GetButton("Up")){

			transform.localRotation = Quaternion.Euler(0, 0, 0);
			transform.localScale = new Vector3(1, 1, 1);
			velocity.y += _speed * Time.deltaTime;
		}
		else if(Input.GetButton("Down")){
			transform.localRotation = Quaternion.Euler(0, 0, 0);
			transform.localScale = new Vector3(1, -1, 1);
			velocity.y -= _speed * Time.deltaTime;
		}


		if(Input.GetButton("Right")){
			transform.localScale = new Vector3(1, 1, 1);
			transform.localRotation = Quaternion.Euler(0, 0, 270);
			velocity.y = 0;
			velocity.x += _speed * Time.deltaTime;
		}
		else if(Input.GetButton("Left")){
			transform.localRotation = Quaternion.Euler(0, 0, 90);
			velocity.y = 0;
			velocity.x -= _speed * Time.deltaTime;
		}


		transform.position += new Vector3(velocity.x, velocity.y, 0);
	}
}
