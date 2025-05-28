using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class GameManager : MonoBehaviour
{
// ***********************************************
    #region 1) Definicion de variables
    public static GameManager gameManager;
    public DataDefinition.EstadosJuego estadoJuego;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void NuevoEstado (DataDefinition.EstadosJuego _nuevoEstado)
    {
        estadoJuego = _nuevoEstado;

        switch (estadoJuego)
        {
            case DataDefinition.EstadosJuego.MenuInicio:
                break;
            case DataDefinition.EstadosJuego.Jugando:
                break;
            case DataDefinition.EstadosJuego.Pause:
                break;
            case DataDefinition.EstadosJuego.CargandoInicio:
                break;
            case DataDefinition.EstadosJuego.CargandoFin:
                break;
        }
    }
    #endregion
    // ***********************************************
}

