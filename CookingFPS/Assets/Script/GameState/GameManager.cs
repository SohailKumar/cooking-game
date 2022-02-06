using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GameManager : MonoBehavior
{
    public void SwitchLevel(){
        sceneManager.LoadSciene(SceneManger.GetActiveScene().buildIndex + 1);
    }

    public void Restart(){
        ScneneManger.LoadSciene(SceneManger.GetActiveScene().name);
    }
}