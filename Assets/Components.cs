using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{
    //Creando el tipo de dato
    public enum Brujula {none , Norte , Sur , Este , Oeste}

    //Creando una variable de tipo brujula
    public Brujula miDireccion = Brujula.Norte;

    

    void Start(){


    }
    
    void Update(){
        //Invocamos a la funcion
        ImprimirDireccion(miDireccion);

    }

    //Tambien podremos añadir funciones a los enum.
    Brujula ImprimirDireccion(Brujula dir){
        Debug.Log(dir);
        return dir;
    }

}
