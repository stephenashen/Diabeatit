using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
  public void scenemainmenuTransition() {
    SceneManager.LoadScene("Main Menu");
  }
}
