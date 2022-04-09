using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOvers : MonoBehaviour
{

    private bool paused = false;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ClickButton()
    {
        if (!paused)
        {
            Time.timeScale = 0;
            paused = true;
            panel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            paused = false;
            panel.SetActive(false);
        }
    }
}
