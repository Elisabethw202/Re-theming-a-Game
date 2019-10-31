using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetImage : MonoBehaviour
{
    public string url;

    public Texture webImage;

   

    IEnumerator GetImageFromWeb(){
        using (WWW www = new WWW(url)){
            yield return www;
           Renderer rend = this.GetComponent<Renderer>();
           rend.material.mainTexture = www.texture;
           webImage = www.texture;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetImageFromWeb());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
