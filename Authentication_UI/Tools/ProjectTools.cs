using System.Diagnostics;
using System.Text;

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

    public string CreateClass(string className, string namespaceName, string relativePath, List<(string Name, string Type)>? properties = null)
    {
        try
        {
            var fullPath = Path.Combine(ProjectRoot, relativePath, $"{className}.cs");
            var directory = Path.GetDirectoryName(fullPath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory!);
            }

            var classContent = new StringBuilder();
            classContent.AppendLine($"namespace {namespaceName};");
            classContent.AppendLine();
            classContent.AppendLine($"public class {className}");
            classContent.AppendLine("{");

            if (properties is { Count: > 0 })
            {
                foreach (var (name, type) in properties)
                {
                    classContent.AppendLine($"public {type} {name} {{ get; set; }}");
                }
            }

            classContent.AppendLine("}");

            File.WriteAllText(fullPath, classContent.ToString());

            return $"Klasse '{className}' wurde erfolgreich erstellt unter: {relativePath}";
        }
        catch (Exception ex)
        {
            return $"Fehler beim Erstellen der Klasse: {ex.Message}";
        }
    }
}
