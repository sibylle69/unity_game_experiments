using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDisapOnColl : MonoBehaviour
{
    public int score = 0;
    void OnTriggerEnter(Collider obj)
    {
        if(obj.tag == "GameController"){
            Destroy(obj.gameObject);
            score +=1;
            Debug.Log(score);
        }
    }
}
