using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo){
        if(hitInfo.name == "Ball"){
            
            string WallName = transform.name;
            GameManager.Score(WallName);
        }
    }
}
