using UnityEngine;
using System.Collections.Generic;

public class AnimalOrbit : MonoBehaviour
{
    public Transform player; // Assign the player GameObject in the Inspector
    public float baseSpeed = 20f; // Base orbit speed
    private List<OrbitingAnimal> animals = new List<OrbitingAnimal>();

    private void Update()
    {
        foreach (var animal in animals)
        {
            animal.UpdateOrbit();
        }
    }

    public void AddAnimal(GameObject animalPrefab, float orbitRadius, float speedMultiplier)
    {
        GameObject newAnimal = Instantiate(animalPrefab, transform);
        OrbitingAnimal orbitingAnimal = new OrbitingAnimal(newAnimal.transform, orbitRadius, baseSpeed * speedMultiplier);
        animals.Add(orbitingAnimal);
    }

    public void RemoveAnimal(Transform animalTransform)
    {
        animals.RemoveAll(a => a.animal == animalTransform);
        Destroy(animalTransform.gameObject);
        AdjustOrbits();
    }

    private void AdjustOrbits()
    {
        // Move layers inward if necessary (you can refine this logic)
    }

    private class OrbitingAnimal
    {
        public Transform animal;
        private float radius;
        private float speed;
        private float angle;

        public OrbitingAnimal(Transform animal, float radius, float speed)
        {
            this.animal = animal;
            this.radius = radius;
            this.speed = speed;
            this.angle = Random.Range(0f, 360f); // Random starting position
        }

        public void UpdateOrbit()
        {
            angle += speed * Time.deltaTime; // Rotate at set speed
            float radianAngle = angle * Mathf.Deg2Rad;
            Vector3 orbitPosition = new Vector3(Mathf.Cos(radianAngle) * radius, 0, Mathf.Sin(radianAngle) * radius);
            animal.position = orbitPosition; // Update position
        }
    }
}