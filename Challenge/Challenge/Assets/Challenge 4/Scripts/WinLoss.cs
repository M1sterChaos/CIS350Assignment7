/*
 * (Austin Buck)
 * (Challenge)
 * (Controls the win/loss)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLoss : MonoBehaviour
{

    public Text loss;
    GameObject player;
    private void Start()
    {
        loss.gameObject.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -10)
        {
            loss.gameObject.SetActive(true);
            loss.text = "You Lose! Press R to Restart!";

            if (Input.GetKeyDown(KeyCode.R))
            {
                SpawnManagerX.waveCount = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (SpawnManagerX.waveCount == 10)
        {
            loss.gameObject.SetActive(true);
            loss.text = "You Win! Press R to Restart!";

            if (Input.GetKeyDown(KeyCode.R))
            {
                SpawnManagerX.waveCount = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
