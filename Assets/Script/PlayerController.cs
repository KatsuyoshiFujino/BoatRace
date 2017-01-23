using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	// speedを制御する
	public float speed = 10;
	//public float x = 0;//Input.GetAxis("Horizontal");
	//public float z = 0;//Input.GetAxis("Vertical");
	public void SpeedUp(){
		speed++;
	}

	public void SpeedDown(){
		speed--;
	}

	/*public void TrunLeft(){
		x--;
	}

	public void TrunRight(){
		x++;
	}*/

	public void FixedUpdate ()
	{
		float x =  Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		 
		Rigidbody rigidbody = GameObject.Find("RowBoat").GetComponent<Rigidbody>();

		rigidbody.AddForce( x * speed , 0, z * speed);

	}





}