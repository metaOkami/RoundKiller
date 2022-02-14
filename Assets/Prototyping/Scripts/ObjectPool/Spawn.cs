using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //Referencia al objeto que queremos hacer aparecer
    public GameObject asteroid;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Los asteroides saldrán si el número aleatorio entre 0 y 100 sale menor que 5
        if (Random.Range(0, 100) < 5)
        {
            //Hacemos aparecer los asteroides en una posición aleatoria de X con respecto al Spawneador
            //Instantiate(asteroid, this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0), Quaternion.identity);

            //Creamos una referencia al objeto de la lista de objetos creados mediante el Pool
            GameObject a = Pool.singleton.Get("Enemigo");
            //Si el objeto que he recibido no está vacío(osea que se puede usar)
            if (a != null)
            {
                //Le pasamos una posición a ese asteroide concreto
                a.transform.position = this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0);
                //Y activamos el asteroide
                a.SetActive(true);
            }
        }

    }
}
