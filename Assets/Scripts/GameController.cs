using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int score;
    public Text text;

    public GameObject aus;
    
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        score = 0;
        text.color = new Color(0.65f,0f,0f);
        text.text = score.ToString();
    }
    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        DestroyScript.playerScored += AddScore;
        DestroyScript.playerDead += ResetScore;
    }
    void OnDisable()
    {
        DestroyScript.playerScored -= AddScore;
        DestroyScript.playerDead -= ResetScore;
    }
    public void AddScore(){
        score++;
        text.color = new Color(0.3f, 0.3f, 0.3f);
        text.text = score.ToString();
        Debug.Log(score);
    }
    public int GetScore(){
        return score;
    }
    public void ResetScore(){
        score = 0;
        text.color = Color.red;
        text.text = score.ToString();
        GameObject newaus = Instantiate(aus);
        Destroy(newaus,2f);
    }
    public void GoBack(){
        SceneManager.LoadScene("Menu"); 
    }
}
