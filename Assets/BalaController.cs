using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    
    public GameObject Player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=Player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position=Vector3.MoveTowards(transform.position,new Vector3(transform.position.x,transform.position.y,10),speed*Time.fixedDeltaTime);
        
    }
    private void OnDrawGizmos() {
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x,transform.position.y,1));
    }
}
