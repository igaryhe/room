using UnityEngine;
using Fungus;
using Kino;


[CommandInfo("Camera",
    "Enable Shader",
    "Enable Shader")]
public class EnableShader : Command
{
    public bool active;
    public override void OnEnter()
    {
        Camera.main.GetComponent<CustomImageEffect>().enabled = active;
        Continue();
    }

    public override string GetSummary()
    {
        return "Enable Shader";
    }
}