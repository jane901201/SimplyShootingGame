using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Trace : MonoBehaviour
{
    /*
     * 子彈的移動方式
     * 子彈的動畫
     */

    public Transform target;
    private float bulletSpeed, bulletDistance, currentDis = 0;
    private Unit unit;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        unit = GetComponent<Unit>();
        bulletSpeed = unit.bulletSpeed;
        bulletDistance = unit.bulletDistance;

    }

    // Update is called once per frame
    void Update()
    {
        unit.checkDistance(bulletDistance, currentDis);
        currentDis += bulletSpeed;
        try //因為這邊會掏出例外，我只好處理他了
        {
            transform.position = Vector2.MoveTowards(transform.position,
                                         target.position, bulletSpeed * Time.deltaTime);
        }
        catch( MissingReferenceException mRE)
        {
            
        }
        finally
        {
            
        }
                                    
    }
}
