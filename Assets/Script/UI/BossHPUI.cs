using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHPUI : MonoBehaviour
{
    UIController uiController;

    public Image bosshpUI;
    //最大生命值
    private float MaxHp, nowHP, halfHP;

    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        uiController = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>();
        nowHP = GetComponent<Unit>().HP;
        MaxHp = nowHP;
        int n = (int)(MaxHp / 2);
        halfHP = (float)n;
    }

    // Update is called once per frame
    void Update()
    {
        nowHP = GetComponent<Unit>().HP;
        if(nowHP == halfHP && !check)
        {
            uiController.showBossHalf();
            check = true;
        }
        bosshpUI.fillAmount = nowHP / MaxHp;
    }
}
