using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class SceneM : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public static SceneM sceneManager;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        sceneManager = this;
    }
    #endregion
    // ***********************************************
    #region 3) Funciones originales
    public void CambioEscena(int _indiceEscena)
    {
        SceneManager.LoadScene(_indiceEscena);
    }
    #endregion
// ***********************************************
}

