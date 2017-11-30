using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.IO;
using ChillyRoom.UnityEditor.iOS.Xcode;

public class PostProcess: MonoBehaviour
{
    [PostProcessBuildAttribute(9999)]
    public static void OnPostProcessBuild(BuildTarget target, string path)
    {
        if (target == BuildTarget.iOS)
        {
            OnIOSBuild(target, path);
        }
    }

    private static void OnIOSBuild(BuildTarget target, string path)
    {
        NativeLocale.AddLocalizedStringsIOS(path, Path.Combine(Application.dataPath, "Appirater/iOS"));
        AddStoreKitFramework(path);
    }

    private const string SoreKitFramework = "StoreKit.framework";    
    private static void AddStoreKitFramework(string projectPath)
    {        
        
        string projPath = projectPath + "/Unity-iPhone.xcodeproj/project.pbxproj";
        PBXProject proj = new PBXProject();
        proj.ReadFromFile(projPath);

//        if (!proj.ContainsFramework(proj.ProjectGuid(), SoreKitFramework))
//        {
//            proj.AddFrameworkToProject(proj.ProjectGuid(), SoreKitFramework, false);
//        }
       
       
        foreach (string targetName in new string[] {PBXProject.GetUnityTargetName(), PBXProject.GetUnityTestTargetName()})
        {
            string guid = proj.TargetGuidByName(targetName);
            if (!proj.ContainsFramework(guid, SoreKitFramework))
            {
                proj.AddFrameworkToProject(guid, SoreKitFramework, false);
            }
        }
        
       
        
        proj.WriteToFile(projPath);
    }
}
