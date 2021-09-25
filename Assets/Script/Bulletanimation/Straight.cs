using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : MonoBehaviour
{
    /*
      * 子彈的移動方式
      * 子彈的動畫
      */

    private float bulletSpeed, bulletDistance, currentDis = 0;

    private Unit unit;


    // Start is called before the first frame update
    void Start()
    {
        unit = GetComponent<Unit>();
        bulletSpeed = unit.bulletSpeed + Random.Range(0.0f, 20.0f);
        bulletDistance = unit.bulletDistance;
    }

    // Update is called once per frame
    void Update()
    {
        currentDis += bulletSpeed;
        transform.Translate(Vector2.down * bulletSpeed * Time.deltaTime);//移動
        unit.checkDistance(bulletDistance, currentDis);
    }
}
