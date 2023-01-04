using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
     public int speed = 1;
     public GameObject projectilePrefab; 
    float horizontal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal,0,0) * speed * Time.deltaTime );

        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab,transform.position,transform.rotation);


        }
    
    }
    void FixedUpdate()
    {
     transform.Translate(new Vector3(horizontal,0,0) * speed * Time.fixedDeltaTime );

    }
}
