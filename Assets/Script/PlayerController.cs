using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	// gunanya buat variable untuk gameobject kita
//	public float MultiplierSpeed;
//	public bool canMove;
//    public float inputDelay = 0.1f;
//    public float forwardVel = 12;
//    public float hoverVel = 12;
//	InputManager InstInput;
//    Rigidbody rBody;
//    float forwardInput, horizontalInput;
//
//
//    void Start()
//    {
//		canMove = true;
//		InstInput = GetComponent<InputManager>();
//        if (GetComponent<Rigidbody>())
//            rBody = GetComponent<Rigidbody>();
//        else
//            Debug.LogError("Karakternya butuh rigid body boy");
//
//        forwardInput = horizontalInput = 0;
//    }
//		
//
//    void FixedUpdate()
//    {
//        Run();
//	
//    }
//    void Update()
//    {
////		Debug.Log ("player update check");
//		if(!canMove){
//			return;
//		}
//		forwardInput = InstInput.GetAxisX ();
//		horizontalInput = InstInput.GetAxisY();
//
//    }
//
//    void Run()
//    {
//        if (Mathf.Abs(forwardInput) > inputDelay)
//        {
//            rBody.velocity = transform.forward * forwardInput * forwardVel;
//        }
//        else
//            rBody.velocity = Vector3.zero;
//
//        if (Mathf.Abs(horizontalInput) > inputDelay)
//        {
//            rBody.velocity = transform.right * horizontalInput * hoverVel;
//        }
//        
//    }
	float forwardInput, horizontalInput;
	public float moveSpeed;
	private float currentMoveSpeed;
	InputManager InstInput;
	public bool canMove;
	public GameObject gameattention;
	void Start () {
		gameattention.SetActive(false);
	}


	void Update() {
		canMove = true;
		InstInput = GetComponent<InputManager>();
		forwardInput = InstInput.GetAxisX ();
		horizontalInput = InstInput.GetAxisY();

		if (forwardInput > 0.5f || forwardInput < -0.5f)
		{
			transform.Translate(new Vector3(0f, 0f, forwardInput * currentMoveSpeed * Time.deltaTime));
		}
		if (horizontalInput > 0.5f || horizontalInput < -0.5f)
		{
			transform.Translate(new Vector3(horizontalInput * currentMoveSpeed * Time.deltaTime,0f,0f));
		}
		if (Mathf.Abs(forwardInput) > 0.5f && Mathf.Abs(horizontalInput) > 0.5f)
		{
			currentMoveSpeed = moveSpeed /1.4f;
		} 
		else
		{ currentMoveSpeed = moveSpeed;
		}
	}
	public void setactive (){
		gameattention.SetActive(true);
	}
	public void setinactive(){
		gameattention.SetActive(false);
	}
}