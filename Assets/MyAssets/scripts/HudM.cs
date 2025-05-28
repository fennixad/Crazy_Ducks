using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>

public class HudM : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    [SerializeField] private RectTransform limites;
    [SerializeField] private RectTransform mirilla;
    #endregion
    // ***********************************************
    #region 2) Funciones de Unity
    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        MoverMirilla();
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    private void MoverMirilla()
    {
        Vector2 localPoint;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(limites, Input.mousePosition, null, out localPoint);

        // Tamaño del área disponible (restando el tamaño del hijo para que no sobresalga)
        Vector2 halfSize = mirilla.rect.size * 0.5f;
        Vector2 minBounds = limites.rect.min + halfSize;
        Vector2 maxBounds = limites.rect.max - halfSize;

        // Clampeamos la posición dentro de los límites
        localPoint.x = Mathf.Clamp(localPoint.x, minBounds.x, maxBounds.x);
        localPoint.y = Mathf.Clamp(localPoint.y, minBounds.y, maxBounds.y);

        mirilla.anchoredPosition = localPoint;
    }
    #endregion
// ***********************************************
}

