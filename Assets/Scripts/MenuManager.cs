using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject start;
    public GameObject exit;
    public GameObject settingss;
    public GameObject sound_off;
    public GameObject sound_on;
    public GameObject back_menu;
    private void Start()
    {
        sound_off.SetActive(false);
        sound_on.SetActive(false);
        back_menu.SetActive(false);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackScene()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Settings()
    {
        start.SetActive(false);
        exit.SetActive(false);
        settingss.SetActive(false);
        sound_off.SetActive(true);
        sound_on.SetActive(true);
        back_menu.SetActive(true);
    }
    public void Back_Menu()
    {
        start.SetActive(true);
        exit.SetActive(true);
        settingss.SetActive(true);
        sound_off.SetActive(false);
        sound_on.SetActive(false);
        back_menu.SetActive(false);
    }
   
}
