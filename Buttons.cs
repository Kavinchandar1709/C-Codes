using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Explosion()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void Strucutre()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void Component()
    {
        SceneManager.LoadScene("Scene4");
    }
    public void Knowledge()
    {
        SceneManager.LoadScene("Scene5");
    }
    public void Quiz()
    {
        SceneManager.LoadScene("Scene6");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Scene5");
    }

    public void Home()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Loadmainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void Scene7()
    {
        SceneManager.LoadScene("Scene7");
    }

    public void Scene8()
    {
        SceneManager.LoadScene("Scene8");
    }

    public void Scene9()
    {
        SceneManager.LoadScene("Scene9");
    }

    public void Scene10()
    {
        SceneManager.LoadScene("Scene10");
    }

}
