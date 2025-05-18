using UnityEngine;

public class StoryElement : MonoBehaviour
{
    public string elementName;
    public Vector2Int position;
    public Vector2Int size;
    public bool canBeMoved = false;
    public bool isPurchasable = false;
    public int stage = 0; // 0: petrified, 1: freed

    public void Interact()
    {
        if(stage == 0)
        {
            Debug.Log(elementName + " is petrified. Interaction limited.");
            // Show dialog or interaction
        }
        else if(stage == 1)
        {
            Debug.Log(elementName + " is freed.");
            // Remove statue and spawn NPC
            Destroy(this.gameObject);
        }
    }
}