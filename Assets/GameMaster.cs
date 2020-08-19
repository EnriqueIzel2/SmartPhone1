using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameMaster : MonoBehaviour
{   

    public Text score;
    private bool asLost;

    public void GoToGameScene(){
        SceneManager.LoadScene("Game");
    }
    public void Restart(){
        asLost = false;
        score.text = "0";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    } 
    private void Update(){
        if(asLost == false) 
            score.text = Time.time.ToString("F0");
    }
}

