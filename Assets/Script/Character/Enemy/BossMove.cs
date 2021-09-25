using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    /*
     * Boss的移動方式
     * 我隨機一個範圍讓物件移動到點，在繼續隨機移動
     */


    private float x, y, rangeX = 10f, rangeY = 4f, speed;
    private Vector2 target, position;

    // Start is called before the first frame update
    void Start()
    {
        x = randomX();
        y = randomY();
        target = new Vector2(x, y);
        position = gameObject.transform.position;
        speed = GetComponent<Unit>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(target != position)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                 target, speed * Time.deltaTime);
            position = gameObject.transform.position;
        }
        else
        {
            x = randomX();
            y = randomY();
            target = new Vector2(x, y);
            position = gameObject.transform.position;
        }
    }

    private float randomX()
    {
        float x = Random.Range(0f, 400f);

        return x;
    }

    private float randomY()
    {
        float y = Random.Range(309f, 173f);

        return y;
    }
}
