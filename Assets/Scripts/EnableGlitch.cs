using UnityEngine;
using Fungus;
using Kino;


[CommandInfo("Camera",
    "Enable Glitch",
    "Enable Glitch")]
public class EnableGlitch : Command
{
    public bool active;
    public override void OnEnter()
    {
        Camera.main.GetComponent<DigitalGlitch>().enabled = active;
        Continue();
    }

    public override string GetSummary()
    {
        return "Enable Glitch";
    }
}