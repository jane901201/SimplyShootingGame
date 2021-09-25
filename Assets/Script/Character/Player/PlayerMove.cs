using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /*
     * 處理玩家移動
     */

    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
          playerSpeed  = GetComponent<Unit>().speed; //獲取Unit組件中的Speed值
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * playerSpeed); //向左移動
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * playerSpeed); //向右移動
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * playerSpeed);  //向上移動
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * playerSpeed); //向下移動
        }
    }
}
