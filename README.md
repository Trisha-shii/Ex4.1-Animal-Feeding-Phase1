# Ex4.1-Animal-Feeding-Phase1

## Aim:
To develop a animal feeding game-Phase-1 using unity.

## Algorithm:
Player Control :


Step 1 :
Extract the package and in unity , asserts -> Import packages -> Custom packages and select the package. When we go to Assets folders we can see the course library which we extracted

Step 2 :
If you want, drag a different material from Course Library > Materials onto the Ground object

Step 3 :
Drag 1 Human, 3 Animals, and 1 Food object into the Hierarchy

Step 4 :
Rename the character “Player”, then reposition the animals and food so you can see them

Step 5 :
Adjust the XYZ scale of the food (2,2,2) so you can easily see it from above

Step 6 :
In your Assets folder, create a “Scripts” folder, and a “PlayerController” script inside.Attach the script to the Player by dragging the c# file to the player and open in the inspector and check whether it is attached.

Moving Forward :


Step 1 :
Create a new “MoveForward” script, attach script to the Food Pizza by dragging the c# file to the pizza and open in the inspector and check whether it is attached

Step 2 :
Create a new “Prefabs” folder, drag your food (Pizza) into Prefab folder, and a pop up raises-> choose Original Prefab

Step 3 :
Select the Player in the hierarchy, then drag the pizza from your Prefabs folder onto the new Projectile Prefab box in the inspector

Step 4 :
Rotate all animals on the Y axis by 180 degrees to face down

Step 5 :
Select all three animals in the hierarchy and Add Component > Drag the Move Forward script from the Scripts into inspector

Step 6 :
Edit their speed values and test to see how it looks. Drag all three animals into the Prefabs folder, choosing “Original Prefab”

## Program:

## Detect Collsion :
```
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);  
    }
    
}
```
## Move Forward :
```
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
```
## Player Controller :
```
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 5.0f;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange)
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
    }
}
```
## Spawn Manager :

```
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

public GameObject[] animalPrefabs;
private float spawnRangeX = 10;
private float spawnPosZ = 5; //Dist from the player
private float startDelay = 2;
private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // Generate a random index based on the number of animal prefabs
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Generate a random spawn position within the defined range
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Instantiate the selected animal prefab at the generated position with no rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
```

## Output:
<img width="1917" height="1124" alt="Screenshot 2025-10-13 110036" src="https://github.com/user-attachments/assets/dd02befc-2be0-456e-90d2-af9d242d7716" />

<img width="1920" height="1146" alt="Screenshot 2025-10-13 110250" src="https://github.com/user-attachments/assets/72d5e379-dbfe-417c-b5af-22a825ae902c" />

## Result:
Thus,Animal feeding game-Phase-1 using unity is developed successfully.
