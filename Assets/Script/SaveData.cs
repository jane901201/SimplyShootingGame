using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveData : MonoBehaviour
{
    /*
     * 數字的儲存跟提取都放在這裡
     * 結局
     * 分數
     * 時間
     */

    UIController uiController;
    ScoreUI scoreUI;
    TimerUI timerUI;

    // Start is called before the first frame update
    void Start()
    {
        uiController = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>();
        scoreUI = GameObject.FindGameObjectWithTag("UIController").GetComponent<ScoreUI>();
        timerUI = GameObject.FindGameObjectWithTag("UIController").GetComponent<TimerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setEndSave(int i)
    {
        PlayerPrefs.SetInt("End", i);
    }

    public int getEndSave()
    {
        int i = PlayerPrefs.GetInt("End");

        return i;
    }

    public void setScoreSave(int i)
    {
        PlayerPrefs.SetInt("Score", i);
    }

    public int getScoreSave()
    {
        int i = PlayerPrefs.GetInt("Score");

        return i;
    }

    public void setTimeSave(float i)
    {
        PlayerPrefs.SetFloat("Time", i);
    }

    public float getTimeSave()
    {
        float i = PlayerPrefs.GetFloat("Time");

        return i;
    }

    public void triggerSave(int end) //如果觸發結局事件，叫出這個函式
    {
        end -= 1;
        setScoreSave(scoreUI.getScore());
        setTimeSave(timerUI.getTotalTime());
        setEndSave(uiController.getEnd(end));
        uiController.gameOver();   //結束遊戲     
    }

}
