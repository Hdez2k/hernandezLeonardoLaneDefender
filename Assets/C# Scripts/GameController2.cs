using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour
{

    void Update()
    {
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
            else if (Input.GetKey(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }
}
