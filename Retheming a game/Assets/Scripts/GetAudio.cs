using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAudio : MonoBehaviour
{
    
    public string url;

    public AudioClip webClip;

    AudioSource aud;

    IEnumerator GetAudioFromWeb(){
        using (WWW www = new WWW(url)){
            yield return www;
            webClip = www.GetAudioClip();
            aud.clip = webClip;
            aud.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        aud = this.GetComponent<AudioSource>();
        StartCoroutine(GetAudioFromWeb());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
