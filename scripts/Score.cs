using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Score : MonoBehaviour{

    public Text scoreText;
    private int accessedScore;

    // Update is called once per frame
    void Update()
    {
        accessedScore = GameObject.Find("Sphere").GetComponent<FoodDisapOnColl>().score;
        scoreText.text = accessedScore.ToString();
    }
}
