using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class MenuInicio : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public Canvas menuInicio;
    Transform hall;
    Transform sure;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    private void Awake()
    {
        hall = transform.GetChild(0);
        sure = transform.GetChild(1);
    }
    #endregion
    // ***********************************************
    #region 3) Funciones originales
    public void Boton_Jugar()
    {
        SoundM.soundManager.ReproducirSonido(0);
        GameManager.gameManager.NuevoEstado(DataDefinition.EstadosJuego.Jugando);
        SceneM.sceneManager.CambioEscena(1);
    }

    public void Boton_Salir()
    {
        SoundM.soundManager.ReproducirSonido(0);
        hall.gameObject.SetActive(false);
        sure.gameObject.SetActive(true);
    }

    public void Si_Salir()
    {
        SoundM.soundManager.ReproducirSonido(0);
        Application.Quit();
    }
    public void No_Salir()
    {
        SoundM.soundManager.ReproducirSonido(0);
        hall.gameObject.SetActive(true);
        sure.gameObject.SetActive(false);
    }
    #endregion
    // ***********************************************
}

