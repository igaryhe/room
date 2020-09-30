using UnityEngine;
using Fungus;


[CommandInfo("Property",
    "Random Transform",
    "Random Transform")]
public class RandomTransform : Command
{
    public Transform obj;

    public override void OnEnter()
    {
        var rnd = new Random();
        obj.transform.localPosition = new Vector3(Random.Range(-4.8f, 4.8f), Random.Range(-4.8f, 4.8f), obj.transform.localPosition.z);
        Continue();
    }

    public override string GetSummary()
    {
        return "Random Transform";
    }
}
