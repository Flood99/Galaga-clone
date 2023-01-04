using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public int bulletSpd = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.up * bulletSpd * Time.deltaTime );
    }

    void OnCollisionEnter2D(Collision2D other)
    {
     
         
          Destroy(other.gameObject);
          Destroy(gameObject);
     
    }

}
