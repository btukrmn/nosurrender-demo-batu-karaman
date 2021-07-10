using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour
{
    GameObject[] enemy;
    public Text enemycounter;
    
    void Start()
    {
        
    }

    void Update()
    {   //Displaying number of enemies on the UI.
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemycounter.text = "Remaining Enemies: " + enemy.Length.ToString() + "/15";

        //Win condition, if there is no enemy player wins.
        var enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(enemies == 0)
        {
            SceneManager.LoadScene("NoSurrenderDemo");
        }

    }
}
