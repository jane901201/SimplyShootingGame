using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreUI : MonoBehaviour
{
    /*
     * 控制分數的UI
     */
    private int totalScore = 0;
    public Text scoreTextUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScore(int unitScore)
    {        
        totalScore += unitScore;
        scoreTextUI.text = "分數" + totalScore;
    }

    public int getScore()
    {
        
        return totalScore;
    }
}
