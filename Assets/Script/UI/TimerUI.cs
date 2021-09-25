using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TimerUI : MonoBehaviour
{
    /*
     * 倒數計時
     * 呼叫gameOver()來結束遊戲
     * 增加時間的function
     */

    UIController uiController;
    SaveData saveData;
    private float currectTime = 60, totalTime = 0, addTimeNum = 0;
    private float[] timeNumber = { 30f, 60f, 120f };

    public Text TimeUI;
    // Start is called before the first frame update
    void Start()
    {

        uiController = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>();
        saveData = GameObject.FindGameObjectWithTag("UIController").GetComponent<SaveData>();
        InvokeRepeating("timer", 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void timer() //這裡的程式碼之後要改
    {
        currectTime -= 1;
        totalTime += 1;
        TimeUI.text = "倒數:" + currectTime;
        if(totalTime == 1)
        {
            uiController.showDialogBox();
            //跳出對話框
        }
        if (currectTime == 0)
        {
            CancelInvoke("timer");
            saveData.triggerSave(3);
            GetComponent<UIController>().gameOver();
        }
    }

    public void addTime(float x)
    {
        currectTime += x;
    }

    public void getTimeNumber(int i)
    {
        addTimeNum = timeNumber[i];
    }

    public float getAddTimeNum()
    {
        return addTimeNum;
    }

    public float getTotalTime()
    {
        return totalTime;
    }
}
