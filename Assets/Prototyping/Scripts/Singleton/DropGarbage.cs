using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGarbage : MonoBehaviour {

    public GameObject garbage;

    void Update () {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                //Para instanciar un bote de basura
                //Instantiate(garbage,hitInfo.point,Quaternion.identity);
                //Instanciamos una basura que pueda ser guardada en la lista
                GameObject go = Instantiate(garbage,hitInfo.point,Quaternion.identity);
                //Metemos esa instancia concreta del objeto en la lista que teníamos
                GameEnvironment.Singleton.AddObstacles(go);
            }
        }
    }
}
