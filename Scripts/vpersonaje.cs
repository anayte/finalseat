using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class vpersonaje : MonoBehaviour
{

    public GameObject guardar;
    public GameObject primeraguardar;
    private int primera = 0;
    private string primero = "";
    private string primeroN = "";
    public string ganador = " ";
    public GameObject GameObjectToDesactivate;
    [SerializeField] TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ocultar()
    {
        Debug.Log("Se desactivó guardar **********************************************************+++++++++++" + guardar.name);
        guardar.SetActive(false);
        primeraguardar.SetActive(false);
    }

    public void vjugador()
    {
        peronajes p = guardar.GetComponent<peronajes>();

        Debug.Log
        (
            
            p.Equipo + p.RangoP + p.Nombrep
            //guardar.GetComponent()<peronajes>.RangoP()
        );

        if (primera > 0 ){

            if(primero != p.Equipo ){

                Debug.Log("No son del mismo equipo");
                if(primera > p.RangoP ){
                    Debug.Log("El ganador es " + primero);
                    text.text = "El ganador es " + primero;
                    ganador = primero;
            
                }else if (p.RangoP > primera){
                    Debug.Log("El ganador es " + p.Equipo);
                    text.text = "El ganador es " + p.Equipo;
                    ganador =  p.Equipo; 

                }else{
                    Debug.Log("Empate");
                    ganador =  "Ambos ganaron"; 
                    text.text = "Ambos ganaron ";
                }
                primera = 0;   
                Invoke("ocultar",1);
                //return ganador; 
    
            }else
            {
                Debug.Log(" Mismo Equipo");
            }

        }else
        {
            primera = p.RangoP;
            primero = p.Equipo;
            primeroN = p.Nombrep;
            Debug.Log("Asignó valores" + primera);
            primeraguardar = guardar; 
        }
        
    }

}
