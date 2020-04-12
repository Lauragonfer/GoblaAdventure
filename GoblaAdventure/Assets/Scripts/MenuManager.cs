using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    /*
     Numeracion Scene
     0 Menu
     1 Ayuda Sustituido por un canvas
     2 Lvl1
     3 Lvl2 
     4 WIN WIN FINAL
    */

    public Canvas logoCanvas,menuCanvas,helpCanvas;

    public float fallDelay = 3f;

    private void Start()
    {
        Debug.Log("Empezamos a quitar el logo");
        logoCanvas.enabled = true;
        menuCanvas.enabled = false;
        helpCanvas.enabled = false;
        Invoke("QuitarLogo", fallDelay);

    }

    public void PlayGame() {
        Debug.Log("Cargar Juego Menu");
        SceneManager.LoadScene(2);
    }

    public void Help()
    {
        Debug.Log("Cargar Ayuda");
        //SceneManager.LoadScene(1);
        logoCanvas.enabled = false;
        menuCanvas.enabled = false;
        helpCanvas.enabled = true;
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void BackMenu() {

        SceneManager.LoadScene(0);
    }

    //Para cargar la escena tras el logo de la compañia
    public void QuitarLogo() {
        Debug.Log("Final de la escena Logo");
        logoCanvas.enabled = false;
        Debug.Log("Activamos menu");
        menuCanvas.enabled = true;

    }


}
