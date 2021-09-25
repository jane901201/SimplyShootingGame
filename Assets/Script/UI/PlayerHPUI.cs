using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPUI : MonoBehaviour
{
    /*
     * 控制玩家HP的UI
     * 控制敵人HP的UI
     * 之後這個程式碼會跟UnitHPUI合併
     */
    public GameObject[] gameObject = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showDecreaseHP(int HP)
    {
        HP -= 1;
        for(int i = (gameObject.Length - 1); i > HP; i--)
        {
            gameObject[i].SetActive(false);
        }
    }

    public void showIncreaseHP(int HP)
    {
        for(int i = 0; i < HP; i++)
        {
            gameObject[i].SetActive(true);
        }
    }

}
