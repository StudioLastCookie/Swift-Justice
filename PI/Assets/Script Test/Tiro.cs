using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour
{
	public	Transform bala;
	public float tempo;
	public	float forca;
	Transform novabala;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	void OnMouseDown ()
	{
	// 
		}


	// Update is called once per frame
	void Update () 
	{
		// emite raio para verificar caminho do tiro
		Debug.DrawRay (transform.position,transform.forward, Color.red);

		//if (Input.GetAxis("Tiro")!=0) 
	if(Input.GetKeyDown(KeyCode.Mouse0) )
	
		{
		novabala = Instantiate(bala,transform.position,Quaternion.identity)as Transform;
		novabala.rigidbody.AddForce(transform.forward * forca, ForceMode.VelocityChange);
		}
		
		//tempo += Time.deltaTime;
	}
}
