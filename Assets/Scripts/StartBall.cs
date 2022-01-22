using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{

    public Vector3 startForce;
    private bool ballHit = false;
    private string hitobject;
   // public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
     // Vector3 speed = new Vector3(startForce,0,0);
      Rigidbody rigidbody = GetComponent<Rigidbody>();
      rigidbody.AddForce(startForce,ForceMode.Impulse);
       
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other.gameObject.name);
        hitobject = other.gameObject.name;
        if (hitobject != "BatBlade") return;
        Debug.Log("Hit the bat from Ball Collider");
        Rigidbody rigidball = GetComponent<Rigidbody>();
        Rigidbody rigidbat = other.gameObject.GetComponent<Rigidbody>();
        Debug.Log(rigidbat.velocity);
        
        //rigidball.AddForce(-startForce,ForceMode.Impulse);

      

        //var colliderGameObject = other.collider.gameObject;
       // colliderGameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * 10000f, ForceMode.Impulse);
 
        
    }

    // Update is called once per frame
    //private void Update()
    //{
        
 
        // float radius = 0.50f;
        // if(!ballHit)
        // {
        //     Rigidbody rigidbody = GetComponent<Rigidbody>();
        //     Vector3 direction = rigidbody.velocity;
        //     RaycastHit hit;
        //     Ray ray =new Ray(transform.position,direction);
        //     if(Physics.SphereCast(transform.position,radius,direction,out hit,.2f))
        //     {
        //         if(hit.transform.name == "BatBlade"){
        //             ballHit = true;
        //             Vector3 balldirection = new Vector3(200, 10, 0);
        //             //rigidbody.AddForce(balldirection,ForceMode.Impulse);  
        //             Debug.Log("Hit the bat"); 
        //             if (gameObject.name == "Ball(Clone)")
        //             {
        //                 Destroy(gameObject,.5f);
        //             }
        //             //Destroy(gameObject,.5f);
        //                             ;
        //         } 
        //         else {
        //             Debug.Log("Missed");
        //         } 
            
        //     }
        
        // }
       
        
    //} 
}
