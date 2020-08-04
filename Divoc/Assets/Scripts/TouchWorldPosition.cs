using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchWorldPosition : MonoBehaviour
{
    // Referencia a la cámara principal de la escena.
    private Camera mainCamera;

    private void Start()
    {
        // Consigo la referencia de la cámara principal de la escena.
        mainCamera = Camera.main;
    }

    private void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        Vector2 mouseScreenPosition = Input.mousePosition;
        Vector2 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mouseScreenPosition);
#elif UNITY_ANDROID
        // Si hay al menos un toque en pantalla...
        if (Input.touchCount > 0)
        {
            // Consigo la información del primer toque.
            Touch touch = Input.GetTouch(0);

            // Consigo la posición en píxeles del toque.
            Vector2 touchScreenPosition = touch.position;
            // Convierto la posición de píxeles a unidades de mundo usando
            // la función ScreenToWorldPoint perteneciente a la cámara.
            Vector2 touchWorldPosition = mainCamera.ScreenToWorldPoint(touchScreenPosition);
        }
#endif
    }
}
