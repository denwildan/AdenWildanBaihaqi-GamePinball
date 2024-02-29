using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Add this line
using UnityEngine.SceneManagement;

public class MainMenuToCredit : MonoBehaviour
{
  public Button playButton;

  private void Start()
  {
    playButton.onClick.AddListener(PlayGame);
  }

  public void PlayGame()
  {
    SceneManager.LoadScene("Credit");
  }
}