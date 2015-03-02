using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MovePersonagem : MonoBehaviour {

	List<IComando> historico;
	
	public float Angulo;
	public 	float Velocidade;



	IComando _Frente;
	IComando _Lado;
	public Transform Atual;

	Vector3 direcao;

	void Start () 
	{	
//		Atual.renderer.material.color = Color.blue;
	}

	void OnMouseDown ()
	{
	//	Debug.Log ("Clikou");
	}

	void FixedUpdate() {
		if (direcao != Vector3.zero) {
			rigidbody.AddForce(direcao.normalized * Velocidade * Time.fixedDeltaTime, ForceMode.VelocityChange); 
		}
	}

	// Update is called once per frame
	void Update () 
	{
		float Vetical = Input.GetAxis ("Vertical");
		float Horizontal = Input.GetAxis ("Horizontal");
		float RotMouseY = Input.GetAxis ("");
		direcao = new Vector3 (Horizontal, 0, Vetical);

		/*
		if( Vetical != 0 )
		{
			_Frente = new Mover (Atual,Direcao.Norte,Velocidade,Vetical,ref historico);
			_Frente.Executar(false);
			//Atual.Translate (Vector3.forward.normalized * Velocidade * Time.deltaTime);
		}
		if(Horizontal != 0 )
		{
			_Lado = new Mover (Atual, Direcao.Leste,Velocidade,Horizontal, ref historico);
			_Lado.Executar (false);
		}
		if(Horizontal !=0 && Vetical != 0) 
		{
			Vetical-= Horizontal;
			Horizontal-=Vetical;
		}*/
	//	print (historico.Count);
	}
}
