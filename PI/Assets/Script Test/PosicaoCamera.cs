using UnityEngine;
using System.Collections;

public class PosicaoCamera : MonoBehaviour 
{
	public GameObject Atual;
	public float Velocidade;
	public float MovHorizontal;
	public float MovVertical;
	public float Suavidade;
	private Vector3 Deslocamento;
	
	
	void Start ()
	{
		Deslocamento = Atual.transform.position - transform.position;
	}
	
	void Update ()
	{
		MovHorizontal = Input.GetAxis ("Mouse Y") * Time.deltaTime;
		MovVertical = Input.GetAxis ("Mouse X") * Time.deltaTime;
	}
	
	void LateUpdate()
	{
		float Corrente = transform.eulerAngles.y;
		float AnguloDesejado = Atual.transform.eulerAngles.y;
		float Anglo = Mathf.LerpAngle (Corrente,AnguloDesejado,0);

		
		Quaternion rotacao = Quaternion.Euler (0,Anglo,0);
		
		transform.position = Atual.transform.position - (rotacao * Deslocamento);
		
		//transform.eulerAngles += new Vector3 (-MovHorizontal * Velocidade ,0,0);
		
		
	}
}