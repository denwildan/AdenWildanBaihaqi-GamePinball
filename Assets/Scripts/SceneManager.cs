using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Add this line
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
  public Button playButton;

  private void Start()
  {
    playButton.onClick.AddListener(PlayGame);
  }

  public void PlayGame()
  {
    SceneManager.LoadScene("Pinball");
  }
}