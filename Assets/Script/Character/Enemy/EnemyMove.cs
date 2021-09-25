using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    /*
     * 敵人的移動
     * 敵人血條的移動(該怎麼作才比較不吃效能阿?)
     */


    private float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        enemySpeed = GetComponent<Unit>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * enemySpeed * Time.deltaTime);//移動
    }
}
