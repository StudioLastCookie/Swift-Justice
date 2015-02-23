using UnityEngine;
using System.Collections;

public class TestRcam2 : MonoBehaviour 
{
public	Transform cameraP;
public	float VelCorpo;
public	float VelCamera;
public	float VelFrente;
public	float VelLateral;
public  float Angulo; 	
public	float Rcam;

	void Start () {
				Screen.lockCursor = true;
		}
	void Update () 
	{

		VelCorpo = 45f;
		VelCamera = 40f;
		VelFrente = 8f;
		VelLateral = 6f;
		Angulo = 30f;

		Rcam = cameraP.transform.eulerAngles.x;
	
		VelCorpo = Input.GetAxis ("Mouse X") * VelCorpo * Time.deltaTime;
		transform.Rotate (0,VelCorpo,0);

		VelCamera = Input.GetAxis ("Mouse Y") * VelCamera * Time.deltaTime;

		if (Rcam > 100) Rcam = Rcam - 360;


		if (Rcam <Angulo && Rcam > -Angulo) 
		{
		cameraP.transform.Rotate(-VelCamera,0,0);			
		}
		else if (Rcam>Angulo)
		{
		if(-VelCamera<0)
		{
		cameraP.transform.Rotate(-VelCamera,0,0);
		}
		}

		if (Rcam < Angulo || Rcam > Angulo) 
		{
			Rcam = Angulo;
		}
	
		VelFrente = Input.GetAxis("Vertical") * VelFrente * Time.deltaTime;
		transform.Translate (0, 0, VelFrente);

		VelLateral = Input.GetAxis ("Horizontal") * VelLateral * Time.deltaTime;

		transform.Translate (VelLateral, 0, 0);
	}
}
