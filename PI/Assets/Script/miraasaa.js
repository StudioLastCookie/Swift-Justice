#pragma strict

var CameraMira: Camera;
var PinicialBala: Transform;

var BalaP: GameObject;
var ForcaC: float;

function Start () {
ForcaC = 5;

}

function Update () {

var raio: Ray;

raio = CameraMira.ScreenPointToRay(Vector3(Screen.width/2,Screen.height/2,0));
//raio = CameraMira.ScreenPointToRay(Input.mousePosition);
var colisor: RaycastHit;

if (Physics.Raycast(raio,colisor,1000))
{
var PosicaoAux: Vector3; 
PosicaoAux = colisor.point - transform.position; 

if(Input.GetMouseButton(0))
{
  
  Instantiate(BalaP,PinicialBala.position,transform.rotation);

  if (Random.value>0.5)
  {
  transform.Rotate(ForcaC*Time.deltaTime,0,0);
  }
  else
  {
  transform.Rotate(-ForcaC*Time.deltaTime,0,0);
  }
}
else
{
 transform.rotation = Quaternion.LookRotation(PosicaoAux);
}
 
 //colisor.transform.renderer.material.color = Color.green;
}



}