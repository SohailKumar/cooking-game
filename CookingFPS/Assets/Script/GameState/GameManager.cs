using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GameManager : MonoBehavior
{
    public void SwitchLevel(){
        SceneManager.LoadSciene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart(){
        SceneManger.LoadSciene(SceneManager.GetActiveScene().name);
    }
}