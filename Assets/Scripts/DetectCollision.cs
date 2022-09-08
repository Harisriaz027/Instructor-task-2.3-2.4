using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectCollision : MonoBehaviour
{
    public int collisionCount = 0;
    
    public GameObject[] lives;
    private void Start()
    {
        
        collisionCount = 0;
    }

    private void Update()
    {
        if(collisionCount==1)
        {
            lives[0].gameObject.SetActive(false);
        }
        else if (collisionCount == 2)
        {
            lives[1].gameObject.SetActive(false);
        }
        else if (collisionCount == 3)
        {
            lives[2].gameObject.SetActive(false);
            Time.timeScale = 0.6f;
            Invoke("SceneRestart", 0.6f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        Time.timeScale = 0.3f;
     }
   
    void SceneRestart()
    {
        SceneManager.LoadScene("GameOver");
    }
    
}
