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
        obj.transform.localPosition = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), obj.transform.localPosition.z);
        Continue();
    }

    public override string GetSummary()
    {
        return "Random Transform";
    }
}
