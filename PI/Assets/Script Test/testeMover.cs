using UnityEngine;
using System.Collections;

public class testeMover : MonoBehaviour 
{	
	public Transform Atual;

	public float velocidade;
	public float Suave;
	public float Angulo;

	Vector3 Posicao;

	// Use this for initialization
	void Start ()
	{
		Atual.renderer.material.color = Color.blue;

	}
	
	// Update is called once per frame
	void Update () 
	{
		// andar para frente 
	
	//	Atual.Translate (0,0,velocidade * Time.deltaTime, Space.World);
		// virar
		Suave = transform.eulerAngles.x;

		float AnguloZ = Input.GetAxis ("Vertical");

		float AnguloX = Input.GetAxis ("Horizontal")* Angulo;

		float MouseX = Input.GetAxis ("Mouse X")*Angulo;
		float lado = MouseX + AnguloX;
	//	Atual.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * Suave);

		Atual.Rotate (0,velocidade * lado * Time.deltaTime,0);

		//Atual.Rotate (0,velocidade * AnguloM * Time.deltaTime,0);
		Atual.Translate (Vector3.forward.normalized * velocidade * Time.deltaTime * AnguloZ);
		
	}
}
