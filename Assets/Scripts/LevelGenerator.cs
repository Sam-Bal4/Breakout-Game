using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Vector2Int size = new Vector2Int(10,5); //Default grid size, can be changed in the inspector
    public Vector2 offset = new Vector2(1.1f, 0.6f); //Default offset between bricks, can be changed in the inspector
    public GameObject brickPrefab;

    //When the game starts, generate a grid of bricks based on the size and offset provided
    private void Awake(){
        for(int i = 0; i < size.x; i++){
            for(int j = 0; j < size.y; j++){
                GameObject newBrick = Instantiate(brickPrefab, transform);
                newBrick.transform.position = transform.position+new Vector3(((float)(size.x-1)*.5f-i)*offset.x, j*offset.y,0);
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
