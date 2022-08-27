using Packages.Rider.Editor;
using UnityEditor;

namespace Kogane.Internal
{
    internal static class JetBrainsRiderRegenerateProjectFiles
    {
        [MenuItem( "Kogane/Rider/Regenerate project files" )]
        private static void SyncSolution()
        {
            RiderScriptEditor.SyncSolution();
        }

        [MenuItem( "Kogane/Rider/Regenerate project files and Open" )]
        private static void SyncSolutionAndOpenExternalEditor()
        {
            RiderScriptEditor.SyncSolutionAndOpenExternalEditor();
        }
    }
}