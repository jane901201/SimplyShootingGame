using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectCollision : MonoBehaviour
{
    /*
     * 處理所有的碰撞事件
     * 當觸發碰撞事件，呼叫函式扣血
     * 撞到道具時的反應
     * 之後有空把一些太長的名稱指派到start作指派的動作好了
     * 無敵時間根據每個飛機的情況而定
     * 扣血時要用對方的攻擊力
     *  當玩家或boss死亡時，結束遊戲並將數據儲存起來
     */

    private int HP, unitScore = 0;
    public float invincible = 1f;
    private float time = 0f;
    private string name, colName;
    private int team, colTeam;


    UIController uiController;
    ScoreUI scoreUI;
    PlayerHPUI playerHPUI;
    TimerUI timerUI;
    SaveData saveData;



    // Start is called before the first frame update
    void Start()
    {
        uiController = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>();
        scoreUI = GameObject.FindGameObjectWithTag("UIController").GetComponent<ScoreUI>();
        playerHPUI = GameObject.FindGameObjectWithTag("UIController").GetComponent<PlayerHPUI>();
        timerUI = GameObject.FindGameObjectWithTag("UIController").GetComponent<TimerUI>();
        saveData = GameObject.FindGameObjectWithTag("UIController").GetComponent<SaveData>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }
    /*
     * 這邊要作的碰撞
     * 判斷陣營
     * 判斷為子彈或腳色
     * 當被碰撞到時要有無敵時間
     * 碰撞時扣自己的血
     * 這邊的道具碰撞有些改成switch好了，判斷，要是隊伍跟名稱都不同分成switch 目前 Player Enemy Wall Time
     */
    void OnTriggerEnter2D(Collider2D col)
    {
        name = GetComponent<Unit>().unitName;
        colName = col.GetComponent<Unit>().unitName;
        team = GetComponent<Unit>().team;
        colTeam = col.GetComponent<Unit>().team;
        
        if((name != colName) && (team != colTeam))
        {
            if(name == "Wall")
            {
                if(colName == "Player")
                {
                    col.gameObject.transform.position = new Vector3(192f, 40f, -0.4862135f);

                }
                else if(colName != "Bullet")
                {
                    Destroy(col.gameObject);
                }
            }
            else if(name == "Player" && colName == "Time")
            {
                Destroy(col.gameObject);
                timerUI.addTime(timerUI.getAddTimeNum());
            }
            else if((team == 0 && colTeam == 1) || (team == 1 && colTeam == 0))
            {
                if(time >= invincible)
                {
                    GetComponent<Unit>().HP -= col.GetComponent<Unit>().atk;
                    HP = GetComponent<Unit>().HP;
                    checkHP(HP, gameObject, GetComponent<Unit>().unitName);
                    if (name == "Player") //控制血量顯示，之後會有敵人的
                    {
                        playerHPUI.showDecreaseHP(HP);
                    }
                    time = 0f;
                }
                
            }
        }
    }

    private void checkHP(int HP, GameObject gameObject, string unitName) //確認死活
    {
        if(HP  <= 0)
        {
            if(unitName == "Player")
            {
                Destroy(gameObject);
                saveData.triggerSave(2);
            }
            else if(unitName == "Boss")
            {
                Destroy(gameObject);
                unitScore = gameObject.GetComponent<Unit>().unitScore;
                scoreUI.setScore(unitScore);
                saveData.triggerSave(1);
            }
            else
            {
                unitScore = gameObject.GetComponent<Unit>().unitScore;
                scoreUI.setScore(unitScore);
                Destroy(gameObject);
            }
            
        }
    }
    /*private void dead(int end) //如果玩家or boss死掉時，呼叫這個function
     {
        end -= 1;
        saveData.setScoreSave(scoreUI.getScore());
        saveData.setTimeSave(timerUI.getTotalTime());
        saveData.setEndSave(uiController.getEnd(end)); 
        uiController.gameOver();   //結束遊戲     
     }*/
}

   

