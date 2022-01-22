using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlay : MonoBehaviour
{
    // Start is called before the first frame update

    public float timeRate;
    public GameObject Ball;

    void Start()
    {
        StartCoroutine(CreateBalls());
        
    }

     private IEnumerator CreateBalls()
    {
        Vector3 position = new Vector3(Ball.transform.position.x , Ball.transform.position.y, Ball.transform.position.z);
        for (int i = 0; i < 50; i++) 
        {
            
            //WaitForNext();
            Debug.Log("ball: " + i);
            GameObject ball = Instantiate(Ball,position,Ball.transform.rotation) as GameObject;
            //ball.transform.SetParent(transform);
            yield return new WaitForSeconds(timeRate);

         }
        
       
    }

   
}
