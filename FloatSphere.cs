using System.Collections;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class FloatSphere : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject spherePrefab;

    void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            Vector3 position = trackedImage.transform.position;
            GameObject sphere = Instantiate(spherePrefab, position + new Vector3(0, 0.2f, 0), Quaternion.identity);
            sphere.transform.SetParent(trackedImage.transform);
        }
    }
}
