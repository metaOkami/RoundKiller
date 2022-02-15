using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public static bool getActivated=false;
    private void Update() {
        BulletSpawner();
        
    }
    private void BulletSpawner(){
        //Creamos una referencia al objeto de la lista de objetos creados mediante el Pool
        GameObject a = Pool.singleton.Get("Bala");
        //Si el objeto que he recibido no está vacío(osea que se puede usar)
        if (a!=null && Input.GetButtonDown("Fire1"))
        {
            getActivated=true;
            //Y activamos la bala
            a.SetActive(true);
            getActivated=true;
            //Hacemos un bool para indicarle a la bala que ha sido activada
        }

        if(getActivated){
            a.transform.position=transform.position;
            getActivated=false;
        }
        
    }

}
