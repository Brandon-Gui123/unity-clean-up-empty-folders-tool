using UnityEditor;
using UnityEngine;

namespace BG.EmptyFoldersRemover
{
    public class EmptyFoldersRemoverEditorWindow : EditorWindow
    {
        private const string windowTitle = "Empty Folders Remover";

        [MenuItem("Window/BG/Empty Folders Remover")]
        private static void InitializeWindow()
        {
            var emptyFoldersWindow = GetWindow<EmptyFoldersRemoverEditorWindow>(false, windowTitle, true);
        }

        private void OnGUI()
        {
            // label to describe what this utility is for
            EditorGUILayout.LabelField("You can use this utility to remove empty folders in Unity.");

            if (GUILayout.Button("Search for empty folders"))
            {
                // search for empty folders
                
                // store the search results in a list (also any way to listen in to an event for directory changes?)
            }

            // display the results maybe in a scrollview?
            // maybe allow them to be pingable so we can show them where in the project it is

            // button for deletion of the assets
            if (GUILayout.Button("Delete listed folders"))
            {
                // show a confirmation dialog before we begin the deletion

                // move the listed assets to the OS trash bin for non-destructive window
            }
        }
    }
}