namespace DirectoryService.Domain.Archive;
public class Archive
{
    public static bool ArchiveCondition {get; private set;} = false;
    public void ToArchive(bool archivator)
    {
        ArchiveCondition = archivator;
    }
        public string ArchiveStatus()
    {
        string arcgivestatus = ArchiveCondition.ToString();
        return arcgivestatus;
    }
}