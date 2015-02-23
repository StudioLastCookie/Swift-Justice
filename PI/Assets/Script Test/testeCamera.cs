using UnityEngine;
using System.Collections;

public class testeCamera : MonoBehaviour 
{
	//private Vector3 Diro;
	
	public  Camera TerceiraPessoa;
	public Camera Mundo;


	void  OnMouseOver()
	{

	}

	void Update () 
	{


		if (Input.GetKeyDown(KeyCode.A))
		{
			//Mundo.camera.enabled = true;

			if (TerceiraPessoa.camera.enabled == false)
			{
				TerceiraPessoa.camera.enabled = true;
			}
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			TerceiraPessoa.enabled = false;
		}

			


			//Mundo.camera.enabled=false;
			// captura mause 
			///Diro = new Vector3 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), 0);
			// camera segue mause
			//Camera.main.transform.forward = Vector3.Slerp (Camera.main.transform.forward,Diro,Time.deltaTime);
			//Atual.transform.forward = Vector3.Slerp (Atual.transform.forward, Diro, Time.deltaTime);

	}
}
