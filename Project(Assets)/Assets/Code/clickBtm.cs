using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickBtm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickPlayBtm()
    {
        // SceneManager.LoadScene("Game");
        // Wa
        SceneManager.LoadScene(2);
    }
    public void clickQuitBtm()
    {
        Application.Quit();
        Debug.Log("Return 0");
    }
    public void clickBackBtm()
    {
        // SceneManager.LoadScene("Game");
        // Wa
        SceneManager.LoadScene(1);
    }
    public void clickLevel1()
    {
        SceneManager.LoadScene(4);
    }
    public void clickLevel2()
    {
        SceneManager.LoadScene(3);
    }
}
