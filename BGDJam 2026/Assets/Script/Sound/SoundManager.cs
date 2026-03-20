using UnityEngine;

[System.Serializable]
public enum soundType
{
    unity,
    aseprite,
    emak,
    alarm,
    api
}

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }


    public AudioSource BGM;
    public AudioSource unitySound;
    public AudioSource asepriteSound;
    public AudioSource emakSound;
    public AudioSource alarmSound;
    public AudioSource apiSound;

    [Header("BGM")]
    public AudioClip bgmMusic;

    [Header("SFX")]
    public AudioClip unityClip;
    public AudioClip asepriteClip;
    public AudioClip emakClip;
    public AudioClip alarmClip;
    public AudioClip apiClip;


    private void Start()
    {
        PlayBGM(bgmMusic);
    }


    public void PlayBGM(AudioClip bgmMusic)
    {
        if (BGM != null)
        {
            BGM.Stop();
        }
        BGM.clip = bgmMusic;
        BGM.Play();
    }

    public void PlayAudio(soundType type)
    {
        switch (type)
        {
            case soundType.unity:
                unitySound.clip = unityClip;
                unitySound.loop = true;
                unitySound.Play();
                break;

            case soundType.aseprite:
                asepriteSound.clip = asepriteClip;
                asepriteSound.loop = true;
                asepriteSound.Play();
                break;

            case soundType.emak:
                emakSound.clip = emakClip;
                emakSound.loop = true;
                emakSound.Play();
                break;

            case soundType.alarm:
                alarmSound.clip = alarmClip;
                alarmSound.loop = true;
                alarmSound.Play();
                break;

            case soundType.api:
                apiSound.clip = apiClip;
                apiSound.loop = true;
                apiSound.Play();
                break;
        }
    }
    //public void PlaySFX(AudioClip clip)
    //{
    //    SFX.PlayOneShot(clip);
    //}
}
