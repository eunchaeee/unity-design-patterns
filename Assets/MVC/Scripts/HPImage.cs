using UnityEngine;

[CreateAssetMenu(fileName = "HPImage", menuName = "Scriptable Objects/HPImage")]
public class HPImage : ScriptableObject
{
    public Sprite[] hpImages = new Sprite[8];
}
