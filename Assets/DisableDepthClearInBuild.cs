using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisableDepthClearInBuild : MonoBehaviour
{
    public int callbackOrder { get { return 1; } }

    public void OnProcessScene(Scene scene, BuildReport report)
    {
        //foreach (GameObject rootGameObject in scene.GetRootGameObjects())
        //    foreach (string uselessComponentName in _uselessComponentNames)
        //        DeleteComponents(rootGameObject.transform, uselessComponentName);

        //Object[] deletionComponents = Resources.FindObjectsOfTypeAll(typeof(DeleteSpecificComponentsFromBuild));
        //foreach (DeleteSpecificComponentsFromBuild deletionComponent in deletionComponents)
        //    deletionComponent.DeleteComponents();
    }
}
