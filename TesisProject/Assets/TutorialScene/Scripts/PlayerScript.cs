using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public Vector2 speed = new Vector2(50, 50);
	private Vector2 movement;

	void Update(){
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
	}
	
	void FixedUpdate(){
		var position = rigidbody2D.position;
		print (position);
		//if (position.x >= -9.0 && position.x < 9.0) {
			rigidbody2D.velocity = movement;
		//} else 
		if (position.x < -9.2) {
			rigidbody2D.position = new Vector2(-9.2f, 0.8f);
		} else if (position.x >= 9.2) {
			rigidbody2D.position = new Vector2(9.2f, 0.8f);
		}
	}
}
