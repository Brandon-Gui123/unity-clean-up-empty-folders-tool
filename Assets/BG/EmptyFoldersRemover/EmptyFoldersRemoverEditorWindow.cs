using UnityEditor;

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
    }
}