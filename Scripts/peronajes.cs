using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peronajes : MonoBehaviour
{

    [SerializeField] public int RangoP = 1; 
    [SerializeField] public string Equipo = "cuadrado"; 
    [SerializeField] public string Nombrep = " "; 
        /*public int primera = 0;
        public string primero = "";
        public string primeroN = "";*/
    [SerializeField] vpersonaje v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validacion()
    {
        v.guardar = gameObject;
        v.vjugador();
    }

}
