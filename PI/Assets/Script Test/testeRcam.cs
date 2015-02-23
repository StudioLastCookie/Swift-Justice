using UnityEngine;
using System.Collections;

public class testeRcam : MonoBehaviour 
{
	public Camera CameraJogador; 
	public Transform PontoInicialBala;	

	public GameObject Balap;
	public float ForcaBala;
	public float Distancia;

	void Start () {}
	

	void Update () 
	{
	Ray Raio;
	RaycastHit colisor;

//		Raio = CameraJogador.ScreenPointToRay(new Vector3 (Screen.width/2, Screen.height/2, 0));
	
//		if(Physics.Raycast(Raio,colisor,Distancia))
//		{
//			Vector3 positionAux;
//			positionAux = colisor.point - transform.position;
//		}
//		if (Input.GetMouseButton (0)) 
//		{
		//
	//	}

	
	}
}
