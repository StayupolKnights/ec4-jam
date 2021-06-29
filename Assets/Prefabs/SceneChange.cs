﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RestartButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void toMainMenu(){
         SceneManager.LoadScene("MainMenu");
    }

    public void tolevelOne()
    {
         SceneManager.LoadScene("LevelOne");
    }
     public void tolevelTwo()
    {
         SceneManager.LoadScene("LevelTwo");
    }
    
     public void tolevelThree()
    {
         SceneManager.LoadScene("LevelThree");
    }
    
     public void tolevelFour()
    {
         SceneManager.LoadScene("LevelFour");
    }
    
     public void tolevelFive()
    {
         SceneManager.LoadScene("LevelFive");
    }
    public void tolevelSix()
    {
         SceneManager.LoadScene("LevelSix");
    }
    
    
}
