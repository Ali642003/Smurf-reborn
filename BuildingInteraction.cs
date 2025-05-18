using UnityEngine;

public class BuildingInteraction : MonoBehaviour
{
    public bool canBeMoved = true;
    public bool isPurchasable = true;
    public int stage = 0; // For Story Elements stages

    public Vector2Int[] occupiedTiles;

    void Start()
    {
        // Initialization code here
    }

    public void OnClick()
    {
        if (stage == 0)
        {
            Debug.Log("Building interaction: Stage 0");
            // Specific interaction for stage 0
        }
        else if (stage == 1)
        {
            Debug.Log("Building interaction: Stage 1");
            // Unlock or remove building for story elements
        }
    }
}