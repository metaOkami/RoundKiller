using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    
    public GameObject Player;
    public float speed;
    Rigidbody _rb;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        _rb=GetComponent<Rigidbody>();
        transform.position=Player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer+=Time.fixedDeltaTime;
        if(timer>=10){
            this.gameObject.SetActive(false);
            Pool.singleton.pooledItems.Add(this.gameObject);
        }
        // transform.position=Vector3.MoveTowards(transform.position,new Vector3(transform.position.x,transform.position.y,10),speed*Time.fixedDeltaTime);
        _rb.AddForce(Vector3.forward*speed,ForceMode.Force);
        
    }
   
}
