using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiButtonHandler : MonoBehaviour
{
    public void Go_To_Scene1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 1");
    }

    public void Go_To_Scene2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 2");
    }
}
