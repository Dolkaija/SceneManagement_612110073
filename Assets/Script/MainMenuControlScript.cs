using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _startButton;   
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;
    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener (
 delegate{StartButtonClick(_startButton);});
 _optionsButton.onClick.AddListener (
 delegate{OptionsButtonClick(_optionsButton);});
 _exitButton.onClick.AddListener (
 delegate{ExitButtonClick(_exitButton);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButtonClick(Button button) {
 SceneManager.LoadScene("SceneGameplay");
 }
    public void StartButtonClick1(Button button)
    {
        SceneManager.LoadScene("SceneGameplay 1");
    }
    public void StartButtonClick2(Button button)
    {
        SceneManager.LoadScene("SceneGameplay 2");
    }
    public void OptionsButtonClick(Button button) {
 if (!GameApplicationManager.Instance.IsOptionMenuActive)
     {
     SceneManager.LoadScene("SceneOption", LoadSceneMode.Additive);
    GameApplicationManager.Instance.IsOptionMenuActive = true;
    }
 }

 public void ExitButtonClick(Button button) {
 Application.Quit();
 }
}
