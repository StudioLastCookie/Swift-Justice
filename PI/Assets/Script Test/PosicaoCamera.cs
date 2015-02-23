using UnityEngine;
using System.Collections;

public class PosicaoCamera : MonoBehaviour 
{
	public GameObject Atual;
	private Vector3 Deslocamento;
	
	void Start ()
	{
		Deslocamento = transform.position;
	}

	void Update ()
	{
	//	transform.position = Atual.transform.position + Deslocamento;
	}
}
