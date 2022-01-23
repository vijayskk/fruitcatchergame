using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("Playground"); 
    }
    public void Exit(){
        Application.Quit();
    }
}
