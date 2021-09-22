using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContoller : MonoBehaviour {
    public Text gameover;
    private Rigidbody rb;
    //public float speed = 2.0f;
	 //Use this for initialization
	 void Start ()
     {
        rb = GetComponent<Rigidbody>();        
        rb.freezeRotation = true;
       // gameover.text = "";

	 }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right * 20);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-transform.right * 20);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward * 20);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.forward * 20);
        }
       
       
		

	}


    //void Fixedupdate ()
    //{
    //float moveHorizontal = Input.GetAxis("Horizontal");
    //float moveVertical = Input.GetAxis("Vertical");
    //Vector3 movement = new Vector3(moveHorizontal,0.0f, moveVertical);
    //rb.AddForce(movement);

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Caps"))
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            //animation.Play("fall");
        }
      
    }
    
}
  