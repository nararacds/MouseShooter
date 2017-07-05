using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour {

	Vector3 velocity;
	Rigidbody myRigidBody;

	void Start () {
		myRigidBody = GetComponent<Rigidbody> ();

	}
	
	public void Move(Vector3 _velocity){
		velocity = _velocity;
	}

	public void LookAt(Vector3 LookPoint){
		Vector3 heightCorrectedPoint = new Vector3 (LookPoint.x, transform.position.y, LookPoint.z);
		transform.LookAt (heightCorrectedPoint);
	}

	public void FixedUpdate(){
		myRigidBody.MovePosition (myRigidBody.position + velocity * Time.fixedDeltaTime);
	}

}
