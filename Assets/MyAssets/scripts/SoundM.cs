using UnityEngine;

/// <summary>
/// DESCRIPCION:
/// 
/// </summary>
[RequireComponent (typeof(AudioSource))]
public class SoundM : MonoBehaviour
{
    // ***********************************************
    #region 1) Definicion de variables
    public static SoundM soundManager;
    AudioSource audioSource;
    public AudioClip[] audioClips;
    #endregion
// ***********************************************
    #region 2) Funciones de Unity
    void Awake()
    {
        soundManager = this;
        audioSource = GetComponent<AudioSource>();
    }
    #endregion
// ***********************************************
    #region 3) Funciones originales
    public void ReproducirSonido(int _indiceClips)
    {
        AudioClip audioClip = audioClips[_indiceClips];
        audioSource.clip = audioClip;
        audioSource.Play();
    }
    #endregion
// ***********************************************
}

