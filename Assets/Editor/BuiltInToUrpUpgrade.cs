using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.Rendering;

static class BuiltInToUrpUpgrade
{
    const string SessionKey = "TerrainLand.UrpUpgradeStarted";

    [InitializeOnLoadMethod]
    static void Schedule()
    {
        EditorApplication.delayCall += RunIfNeeded;
    }

    [MenuItem("Tools/Upgrade Built-in Render Pipeline to URP")]
    public static void RunFromMenu()
    {
        SessionState.SetBool(SessionKey, false);
        RunIfNeeded();
    }

    static void RunIfNeeded()
    {
        if (EditorApplication.isCompiling || EditorApplication.isUpdating)
        {
            EditorApplication.delayCall += RunIfNeeded;
            return;
        }

        if (GraphicsSettings.defaultRenderPipeline != null)
            return;

        if (SessionState.GetBool(SessionKey, false))
            return;

        SessionState.SetBool(SessionKey, true);
        Converters.RunInBatchMode(
            "BuiltInToURP",
            new List<string>
            {
                "RenderSettings",
                "Material",
                "ReadonlyMaterial",
                "AnimationClip"
            },
            true);
        AssetDatabase.SaveAssets();
    }
}
