namespace Jal.Settings
{
    public interface ISectionExtractor
    {
        T GetSection<T>(string name) where T: class;
    }
}