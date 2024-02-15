using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// basic WASD-style movement control
// commented out line demonstrates that transform.Translate instead of charController.Move doesn't have collision detection

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour {
	public const float baseSpeed = 6.0f;

	public float speed = 6.0f;
	public float gravity = -9.8f;
	public float jumpForce = 12.0f;

	private CharacterController charController;

	void OnEnable() {
		Messenger<float>.AddListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);
	}
	void OnDisable() {
		Messenger<float>.RemoveListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);
	}

	void Start() {
		charController = GetComponent<CharacterController>();
	}
	
	void Update() {
		//transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude(movement, speed);

		//if (charController.isGrounded)
		//{
        //    gravity += Physics.gravity.y * Time.deltaTime;
        //}
		//else
		//{
		//	gravity = -0.5f;
		//}

		if (Input.GetKeyDown(KeyCode.E))
		{
			Debug.Log("Jump!"); 
			Vector3 jp = new Vector3(0, jumpForce, 0);
			transform.Translate(jp);
            Vector3 jump = new Vector3(0, 10, 0);
            jump = Vector3.ClampMagnitude(jump, speed);
            jump *= Time.deltaTime;
            jump = transform.TransformDirection(jump);
            charController.Move(jump);

        }

		if (Input.GetKeyDown(KeyCode.Q))
		{
			   Debug.Log("Drop!");
			Vector3 jp = new Vector3(0, -jumpForce, 0);
			transform.Translate(jp);
			Vector3 jump = new Vector3(0, -10, 0);
			jump = Vector3.ClampMagnitude(jump, speed);
			jump *= Time.deltaTime;
			jump = transform.TransformDirection(jump);
			charController.Move(jump);
		}

        movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		charController.Move(movement);
	}

	private void OnSpeedChanged(float value) {
		speed = baseSpeed * value;
	}

	public bool IsJumpingAllowed()
	{
        return charController.isGrounded;
    }
}
