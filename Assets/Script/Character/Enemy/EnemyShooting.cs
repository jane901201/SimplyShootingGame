using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyBullet;
    private float shootingTime, bulletTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        shootingTime = GetComponent<Unit>().shootingTime;
    }

    // Update is called once per frame
    void Update()
    {
        bulletTime += Time.deltaTime;
        if(bulletTime >= shootingTime)
        {
            Instantiate(enemyBullet, transform.position, new Quaternion(0, 0, 0, 0));
            //克隆一個Bullet在小飛兵的位置
            bulletTime = 0f;
        }

    }
}
