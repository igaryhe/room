using UnityEngine;
 
[ExecuteInEditMode]
public class CustomImageEffect : MonoBehaviour {
 
    public Material material;

    private void Awake()
    {
        gameObject.GetComponent<Camera>().depthTextureMode = DepthTextureMode.DepthNormals;
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest) {
        Graphics.Blit(src, dest, material);
    }
}
