using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public float mintime , maxtime ;
    public int minforce , maxforce;
    private float timer;
    private bool reloaded;

    public GameObject fruit;
    public Transform spawnpointleft,spawnpointright;

    // Update is called once per frame
    void Update()
    {
        
        if (reloaded)
        {
            StopCoroutine("Timer");
            int side = Random.Range(0,2);
            int force = Random.Range(minforce,maxforce);
            if (side == 0)
            {
                GameObject newfruit =  Instantiate(fruit,spawnpointleft.position,transform.rotation);
                Rigidbody2D rb = newfruit.GetComponent<Rigidbody2D>();
                rb.AddForce(rb.transform.up * 500);
                rb.AddForce(rb.transform.right * force); 
            }else{
                GameObject newfruit =  Instantiate(fruit,spawnpointright.position,transform.rotation);
                Rigidbody2D rb = newfruit.GetComponent<Rigidbody2D>();
                rb.AddForce(rb.transform.up * 500);
                rb.AddForce(rb.transform.right * force * -1);
            }

            timer = Random.Range(mintime,maxtime);
            reloaded = false;
        }else{
            StartCoroutine("Timer");

        }

    }
    IEnumerator Timer(){
        yield return new WaitForSeconds(timer);
        reloaded = true;
    }
}
