using UnityEngine;
 
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class CustomImageEffect : MonoBehaviour {
 
    public Material material;

    private void Awake()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.DepthNormals;
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest) {
        Graphics.Blit(src, dest, material);
    }
}
