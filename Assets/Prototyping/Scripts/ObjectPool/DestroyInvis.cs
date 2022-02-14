using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvis : MonoBehaviour
{
    //Cuando un objeto no se ve
    private void OnBecameInvisible()
    {
        //Destruimos ese objeto
        //Destroy(this.gameObject);

        //Deactivate this object
        this.gameObject.SetActive(false);
    }
}
