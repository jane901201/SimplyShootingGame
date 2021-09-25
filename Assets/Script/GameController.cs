using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    /*
     * 遊戲形成控制
     * 生成敵人
     * 當時間到時事件發生
     * 生出增加時間的道具
     * 生出增加血量的道具
     * 
     */

    TimerUI timerUI;


    public GameObject[] enemy, addTime;


    private float wait = 2.5f, range = 129f;

    

    // Start is called before the first frame update
    void Start()
    {
        timerUI = GameObject.FindGameObjectWithTag("UIController").GetComponent<TimerUI>();
        StartCoroutine(randomEnemy());
        StartCoroutine(addTimeProduce());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator randomEnemy()
    {

        while (true)//隨機產生敵人
        {
            Vector3 pos = new Vector3(Random.Range(374, 4), 300f, 0);
            Instantiate(enemy[Random.Range(0, enemy.Length)], pos, transform.rotation);

            yield return new WaitForSeconds(wait);
        }

    }

    IEnumerator addTimeProduce()
    {

        while (true)//創造時間掉落
        {
            Vector3 pos = new Vector3(Random.Range(374, 4), 300f, 0);

            int num = Random.Range(0, addTime.Length);

            timerUI.getTimeNumber(num);

            Instantiate(addTime[num], pos, transform.rotation);

            yield return new WaitForSeconds(Random.Range(30f, 45f));
        }

    }

}



 

 