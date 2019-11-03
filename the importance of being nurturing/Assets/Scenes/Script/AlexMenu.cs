using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AlexMenu : MonoBehaviour
{
    public menuSelect MenuSelect = menuSelect.Play;
    public GameObject SettingsGO;

    public void ClickButton()
    {

        switch (MenuSelect)
        {
            case menuSelect.Play:
                break;
            case menuSelect.Settings:
                Setting.SettingsOpen = !Setting.SettingsOpen;
                break;
            case menuSelect.Quit:
                Application.Quit();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Setting.SettingsOpen)
        {
            SettingsGO.SetActive(true);
        }
        else if (!Setting.SettingsOpen)
        {
            SettingsGO.SetActive(false);
        }
    }

    public enum menuSelect
    {
        Play,
        Settings,
        Quit
    };
}