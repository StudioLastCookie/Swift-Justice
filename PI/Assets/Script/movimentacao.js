#pragma strict

var cameraP: Transform;
var VelocidadeRCorpo: float;
var VelocidadeRCamera: float;

var VelocidadeAndarF : float;
var VelocidadeAndarL : float;

var Rcam: float;




function Start () {

}

function Update () {

Rcam = cameraP.transform.eulerAngles.x;


VelocidadeRCorpo = 45;
VelocidadeRCamera = 50;
VelocidadeAndarF = 8;
VelocidadeAndarL = 6;

//if (cameraP.transform.rotation.x!=0)cameraP.transform.rotation.x=0;
//if (cameraP.transform.rotation.z!=0)cameraP.transform.rotation.z=0;

VelocidadeRCorpo = Input.GetAxis("Mouse X")*VelocidadeRCorpo*Time.deltaTime ;

transform.Rotate(0,VelocidadeRCorpo,0);


VelocidadeRCamera = Input.GetAxis("Mouse Y")*VelocidadeRCamera*Time.deltaTime ;
if (Rcam>100) Rcam=Rcam-360;
if (Rcam<30 && Rcam>-30)
{
  cameraP.transform.Rotate(-VelocidadeRCamera,0,0);
}
else
{
  if (Rcam>30)
  {
    if (-VelocidadeRCamera<0)
    {
      cameraP.transform.Rotate(-VelocidadeRCamera,0,0);
    }
  }
  
  if (Rcam<-30)
  {
    if (-VelocidadeRCamera>0)
     {
       cameraP.transform.Rotate(-VelocidadeRCamera,0,0);
     }
  }

}

VelocidadeAndarF = Input.GetAxis("Vertical")*VelocidadeAndarF*Time.deltaTime;
transform.Translate(0,0,VelocidadeAndarF);

VelocidadeAndarL = Input.GetAxis("Horizontal")*VelocidadeAndarL*Time.deltaTime;
transform.Translate(VelocidadeAndarL,0,0);

}