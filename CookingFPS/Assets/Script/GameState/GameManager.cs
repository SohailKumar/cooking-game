using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text stoveText;
    public Text handText;
    public GameObject potato;
    public Transform poPos;
    public GameObject bread;
    public Transform bPos;

    [SerializeField] private float timeBtwSpawn;
    private float currTimeSpawn;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F) && currTimeSpawn<=0)
        {
            Instantiate(bread, bPos.position, Quaternion.identity);
            Instantiate(potato, poPos.position, Quaternion.identity);
            currTimeSpawn = timeBtwSpawn;
        }
        if(currTimeSpawn > 0)
        {
            currTimeSpawn -= Time.deltaTime;
        }
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void UpdateStove(string add)
    {
        stoveText.text = ("Stove: " + add);
    }

    public void UpdateHand(string add)
    {
        handText.text = ("Hand: " + add);
    }
}