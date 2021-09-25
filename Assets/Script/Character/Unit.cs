using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Unit : MonoBehaviour
{
    /*
     * 單位血量
     * 單位移動速度
     * 單位攻擊力
     * 名稱
     * 飛機的射擊速度
     *  子彈的飛行速度
     * 子彈的攻擊力
     * 子彈的飛行距離
     * 如果還有下次，我要好好想想這種高度相關的單元數字要怎麼處理了....
     * */
    // Start is called before the first frame update
    public string unitName; //單位名稱
    public int HP = 3;    //生命值
    public int atk = 1;    //攻擊力
    public float speed = 3; //單位移動速度  
    public int team = 0; //所屬陣營，如果再判斷碰撞的地方不相符就會觸發事件 0為玩家 1為敵人 2為道具 3為系統物(ex:牆之類的)
    public int unitScore = 0;
    public float shootingTime = 1; //射擊速度      
    public float bulletSpeed = 2;  //子彈飛行的速度
    public float bulletDistance = 2000; //子彈飛行距離

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkDistance(float dis, float currentDis) //當超過距離時，就銷毀物件
    {
        if (currentDis > dis)
        {
            Destroy(gameObject);
        }
    }



}
