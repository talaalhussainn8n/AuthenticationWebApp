using System.Diagnostics;

namespace AuthenticationUI.Tools;

public class ProjectTools(string projectRoot)
{
    public string ProjectRoot { get; } = projectRoot;

    public string ReadFile(string relativePath)
    {
        var file = Path.Combine(ProjectRoot, relativePath);

        if (!File.Exists(file))
            return $"Datei {relativePath} existiert nicht.";

        return File.ReadAllText(file);
    }

    public string WriteFile(string relativePath, string content)
    {
        var file = Path.Combine(ProjectRoot, relativePath);

        Directory.CreateDirectory(Path.GetDirectoryName(file)!);

        File.WriteAllText(file, content);

        return "Datei gespeichert.";
    }

    public string ListFiles()
    {
        return string.Join(Environment.NewLine,
            Directory.GetFiles(ProjectRoot, "*.cs", SearchOption.AllDirectories)
                     .Select(x => Path.GetRelativePath(ProjectRoot, x)));
    }

    public string Build()
    {
        Process process = new();

        process.StartInfo.FileName = "dotnet";
        process.StartInfo.Arguments = "build";
        process.StartInfo.WorkingDirectory = ProjectRoot;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;

        process.Start();

        var output = process.StandardOutput.ReadToEnd();
        output += process.StandardError.ReadToEnd();

        process.WaitForExit();

        return output;
    }
}
