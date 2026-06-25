using UnityEngine;

public class player : MonoBehaviour
{
    public SpriteRenderer playeer;
    public Color c;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            playeer.color=c;
        }
    }
}
