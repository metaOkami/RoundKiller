using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    
    BalaController mibala;
    private void Update() {
        BulletSpawner();
        
    }
    private void BulletSpawner(){
        //Creamos una referencia al objeto de la lista de objetos creados mediante el Pool
        GameObject a = Pool.singleton.Get("Bala");
        //Si el objeto que he recibido no está vacío(osea que se puede usar)
        if (a!=null && Input.GetButtonDown("Fire1"))
        {
            mibala.timer=0;
            //Y activamos la bala
            a.SetActive(true);
        }

        
        
    }

}
