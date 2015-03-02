using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Certificado para todos os scripts

public abstract class IComando
{
	// executou ! 
	public abstract void Executar (bool Gravar);
}
// para movimentacao

public enum Direcao 
{
 	Norte,
	Sul,
	Leste,
	Oest
}

// ##fazer enum para acoes jogador
// ## fazer tratar camera por mause
//  ## fazer  reset

// comando mover apos estiver fucionado corretamente sera varios comando sepadaramente por estatos


public class Mover: IComando
{
	public List <IComando> HistoricoMover;
	public Direcao direcao;
	public Transform objeto;
	public float Velocidade;
	public float Angulo;
//#	public float Gral;
	//public float Arastro;

	//public Mover (Transform Obj, Direcao direcao,float Vel, float tempo, ref List<IComando> lista)
	
	public Mover (Transform Obj, Direcao direcao,float Vel,float angulo, ref List<IComando> lista)
	{
		this.objeto = Obj;
		this.direcao = direcao;

		this.HistoricoMover = lista;	

		this.Velocidade = Vel;
		this.Angulo = angulo;
		//this.Tempo = tempo;

	}

	public override  void Executar (bool Gravar)
	{
		switch (direcao)
		{
		case Direcao.Norte:
			objeto.Translate (objeto.forward.normalized * Velocidade * Time.deltaTime * Angulo);
			break;
		case Direcao.Leste:
			objeto.Translate (objeto.right.normalized * Velocidade * Time.deltaTime * Angulo);
			break;
		}
	}	
}
public class RotCamera : IComando
{
	public List<IComando> HistoricoCamera;

	public Direcao direcao;
	public Transform objeto;
	public float rotcao;

	public RotCamera (Transform Obj, Direcao derecao, float rotacao, ref List<IComando>lista)
	{
	}
	public override void Executar (bool Gravar)	
	{
	}
	
}