using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomMovement : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float speed;
    
    
    float secondsToMaxDif;

    Vector2 targetPosition;
    public GameObject restartPanel;

    void Start()
    {
        targetPosition = GetRandomPosition();
    }
    void Update()
    {
        if((Vector2)transform.position != targetPosition){
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed*Time.deltaTime);
        }
            
        else
            targetPosition = GetRandomPosition();
    }

    Vector2 GetRandomPosition() {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY,maxY);
        return new Vector2(randomX, randomY);
    }

    private  void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "snowball"){
            restartPanel.SetActive(true);
        }
    }
    float GetDifficultyPercent(){
            return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDif);
    }
     
    
}
