using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDivideScreen : MonoBehaviour
{
    private void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        float movementDirection = Input.GetAxisRaw("Horizontal");
#elif UNITY_ANDROID
        // Si hay al menos un toque en pantalla...
        if (Input.touchCount > 0)
        {
            // Recibo la información del primer toque.
            Touch touch = Input.GetTouch(0);

            // Variable que guarda la mitad de la anchura de la
            // pantalla en píxeles.
            int halfScreenWidth = Screen.width / 2;

            // Si el toque está en la parte izquierda de mi pantalla...
            if(touch.position.x < halfScreenWidth)
            {
                // Estoy a la izquierda de mi pantalla.
            }
            // Si el toque está en la parte derecha de mi pantalla...
            else
            {
                // Estoy a la derecha de mi pantalla.
            }
        }
#endif

    }
}
