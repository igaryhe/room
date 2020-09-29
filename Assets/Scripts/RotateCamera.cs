using System.Collections;
using UnityEngine;
using Fungus;


[CommandInfo("Camera",
    "Rotate",
    "Rotate the camera")]
public class RotateCamera : Command
{
    public float degree;

    public override void OnEnter()
    {
        // Camera.main.transform.Rotate(0, degree, 0, Space.World);
        Continue();
    }

    public override string GetSummary()
    {
        return "rotate the main camera";
    }
}
