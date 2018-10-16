using UnityEngine;

public class WebCam : MonoBehaviour
{

    public MeshRenderer[] UseTexture;
    private WebCamTexture Texture;

    void Start()
    {
        Texture = new WebCamTexture();
        foreach (MeshRenderer render in UseTexture)
        {
            render.material.mainTexture = Texture;
        }
        GetComponent<Renderer>().material.mainTexture = Texture;
        Texture.Play();
    }

    void OnGUI()
    {
            if (GUILayout.Button("Play"))
            {
                Texture.Play();
            }
        }
    }
