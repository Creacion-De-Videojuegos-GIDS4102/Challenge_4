using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    public void cambiarNivel()
    {
        SceneManager.LoadScene(2);
    }
    public void cambiarMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void CambiarOpciones()
    {
        SceneManager.LoadScene(1);
    }
}
