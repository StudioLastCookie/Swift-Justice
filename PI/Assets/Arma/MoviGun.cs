using UnityEngine;
using System.Collections;

public class MoviGun : MonoBehaviour {
	public float TempoMax;
	public float Forca;
	public float Vel;
	private float Mover;

	void Update () 
	{
	
		transform.Rotate (0,0,Vel*Forca);

		if(Input.GetMouseButton(0))
			{
			//print("Roda");
			//transform.Rotate (0,0,Vel);
			Vel += Time.deltaTime;
				if(Vel >=TempoMax)
				{
			//	transform.Rotate (0,0,Vel);
				Vel= TempoMax;
				}
			}
		else
		{
			Vel -= Time.deltaTime;
				if(Vel <=0)
				Vel = 0;
		}		
	}

}
