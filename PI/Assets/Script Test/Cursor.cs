using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour 
{
	public float ComandoCamY;
	public float VelocidadeCamera;
	public float VelocidadeCameraLateral;
	public float MovimentoVertical;
	public float Angulo;
	public Camera CameraPersonagem;
	Ray raio;
	RaycastHit colisor;
	void Start () 
	{
		Screen.lockCursor = true;
	
	}

	void  FixedUpdate () 
	{
		// Raio disparado do centro da tela
		raio = CameraPersonagem.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));
		ComandoCamY = CameraPersonagem.transform.eulerAngles.x;
		VelocidadeCamera = 50f;
		VelocidadeCameraLateral = 50f;


		VelocidadeCameraLateral = Input.GetAxis ("Mouse Y") * VelocidadeCameraLateral * Time.deltaTime;
		VelocidadeCamera = Input.GetAxis ("Mouse X") * VelocidadeCamera * Time.deltaTime;

	
		transform.Rotate(0,VelocidadeCamera,0);
		//CameraPersonagem.transform.eulerAngles.x = Mathf.Clamp (360f,0f,0f);

		//CameraPersonagem.transform.Rotate (-VelocidadeCameraLateral, 0, 0);

		CameraPersonagem.transform.Rotate(-VelocidadeCameraLateral,0,0);
		if (CameraPersonagem.transform.eulerAngles.x <350f || CameraPersonagem.transform.eulerAngles.x >10f) 
		{
		//	CameraPersonagem.transform.eulerAngles -= new Vector3 (ComandoCamY * Time.deltaTime, 0, 0);
		}
	
		//distancia em que o raio ira colidir e quando colidir. 
		if(Physics.Raycast(raio,out colisor,1000))
		{
		//	colisor.transform.renderer.material.color = new Color(Random.Range(0f,256f),50f,60f);
		}

	}
}
	