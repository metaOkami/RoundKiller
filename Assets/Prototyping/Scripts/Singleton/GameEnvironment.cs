using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnvironment:MonoBehaviour
{
    //Referencia única de esta clase
    private static GameEnvironment sharedInstance;

    //Lista privada para almacenar los objetos que vamos poniendo en el juego
    private List<GameObject> obstacles = new List<GameObject>();
    //Accesor a esta lista
    public List<GameObject> Obstacles { get { return obstacles; } }

    //Lista privada para almacenar los puntos entre los que se pueden mover los NPCS
    private List<GameObject> goals = new List<GameObject>();
    //Accesor a esta lista
    public List<GameObject> Goals { get { return goals; } }

    //Queremos convertir la instancia sharedInstance en un Singleton
    public static GameEnvironment Singleton
    {
        //Aquí obtenemos los datos
        get
        {
            //Si esa instancia estuviera vacía
            if (sharedInstance == null)
            {
                //Asignamos su valor a la referencia
                sharedInstance = new GameEnvironment();
                sharedInstance.Goals.AddRange(GameObject.FindGameObjectsWithTag("goal"));
            }
            //Ya nos devuelve el sharedInstance convertida en Singleton
            return sharedInstance;
        }
    }

    //Método para añadir objetos a la lista de obstáculos
    public void AddObstacles(GameObject go)
    {
        //Añadimos un objeto a la lista
        obstacles.Add(go);
    }

    //Método para borrar objetos a la lista de obstáculos
    public void RemoveObstacles(GameObject go)
    {
        //Una vez que tenemos el go concreto
        int index = obstacles.IndexOf(go);
        //Lo borramos
        obstacles.RemoveAt(index);
        //Borramos el obstáculo del juego
        GameObject.Destroy(go);
    }

    //Método para obtener un destino de manera aleatoria para nuestros NPCS
    public GameObject GetRandomGoal()
    {
        int index = Random.Range(0, goals.Count);
        return goals[index];
    }

}
