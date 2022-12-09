using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio : MonoBehaviour
{
    // Start is called before the first frame update

    public void cambiomenu(){

        //Inicia el juego 
        SceneManager.LoadScene("game");

    }

    public void salida(){

        //Cierra 
        Application.Quit();
    }



}
