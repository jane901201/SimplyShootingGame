using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    /*
     * 玩家子彈射擊
     */
    public GameObject bullet; //子彈物件
    private float bulletTime = 0f, shootingTime;
    // Start is called before the first frame update
    void Start()
    {
        shootingTime = GetComponent<Unit>().shootingTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //一直按壓按鍵
        {

            bulletTime += Time.deltaTime;

            if (bulletTime > shootingTime)
            {//每隔0.15秒產生一個子彈
                Instantiate(bullet, transform.position, new Quaternion(0, 0, 0, 0));
                //克隆一個Bullet在小飛兵的位置
                bulletTime = 0f;
            }

        }
    }
}
