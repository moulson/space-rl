using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonHandler : MonoBehaviour
{
    public string newGameScene;
    public GameObject mainMenuPanel;
    public GameObject settingsMenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        //show main menu and hide the rest
        mainMenuPanel.SetActive(true);
        settingsMenuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

    public void OpenSettingsMenu()
    {
        mainMenuPanel.SetActive(false);
        settingsMenuPanel.SetActive(true);
        Settings s = new Settings();
        List<Setting> settings = s.GetAll();
        foreach(var setting in settings)
        {
            Debug.Log($"setting: {setting.Name}, value {setting.Value}");
        }
        
    }

    public void CloseSettingsMenu()
    {
        mainMenuPanel.SetActive(true);
        settingsMenuPanel.SetActive(false);
    }
}
