using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    int dir = 1;
    float moveTimer;
   public float moveTime = 2;
   public int moveNum = 3;
    int moves;
    public int direction = 1;

        void Start()
    {
        moveTimer = moveTime;
        moves = moveNum;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moves<=0)
        {
        direction *= -1;
        moves = moveNum;
        }

        if (moveTimer > 0)
        {
            moveTimer -= Time.deltaTime;
        }

        if(moveTimer <= 0)
        {
         transform.Translate(new Vector3(1,0,0) * direction);
         moveTimer = moveTime;
         moves-=1;
        }
    }
}
