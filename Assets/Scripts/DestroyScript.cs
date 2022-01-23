using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public delegate void Scored();
    public static event Scored playerScored;
    public static event Scored playerDead;
    public GameObject ps;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground")){
            playerDead();
            GameObject newps = Instantiate(ps, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
            Destroy(newps,2f);
        }
        if(other.gameObject.CompareTag("Target")){
            // GameObject newps = Instantiate(ps, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            
            playerScored();
            Destroy(gameObject);
            // Destroy(newps,2f);
        }
    }
}
