using UnityEngine;


public class Bat : MonoBehaviour
{

	Vector3 PrevPos;
	Vector3 NewPos;
	public Vector3 ObjVelocity;

	Vector3 rotationLast;
	Vector3 rotationDelta;
	public Vector3 AngVelocity;

	public void Start()
	{
		PrevPos = transform.position;
		rotationLast = transform.rotation.eulerAngles;
	}
	private void Update()
	{
		NewPos = transform.position;
		var media = (NewPos - PrevPos);
		ObjVelocity = media / Time.deltaTime;
		PrevPos = NewPos;
		NewPos = transform.position;

		rotationDelta = transform.rotation.eulerAngles - rotationLast;
		rotationLast = transform.rotation.eulerAngles;
		AngVelocity = rotationDelta;
	}

	// void Start()
	//{
	//        PrevPos = transform.position;
	//        NewPos = transform.position;
	//}

	//private void OnCollisionEnter(Collision other)
	//{
	//    Debug.Log(other);
	//    if (!other.gameObject.CompareTag("Ball")) return;
	//    Debug.Log("Hit the bat");


	//    Rigidbody rigidbody = GetComponent<Rigidbody>();
	//    Vector3 direction = rigidbody.velocity;
	//    Debug.Log(direction);
	//    Debug.Log(-transform.forward);

	//    var colliderGameObject = other.collider.gameObject;
	//    colliderGameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * 10000f, ForceMode.Impulse);


	//}


	//void FixedUpdate()
	//{
	//     Rigidbody rb = GetComponent<Rigidbody>();
	//     NewPos = transform.position;  // each frame track the new position
	//     rb.velocity  = (NewPos - PrevPos) / Time.fixedDeltaTime;  // velocity = dist/time
	//     PrevPos = NewPos;  // update position for next frame calculation
	//}



}
