using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Classe respons�vel por conrolar qualquer tipo de �udio
    private AudioSource audioSource;

    // AudioClip � o arquivo de audio que ser� executado
    public AudioClip levelMusic;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        PlayMusic(levelMusic);
    }

    public void PlayMusic(AudioClip music)
    {
        //Define o som que ira ser reproduxido
        audioSource.clip = music;
        //Reproduz o som
        audioSource.Play();
    }
}
