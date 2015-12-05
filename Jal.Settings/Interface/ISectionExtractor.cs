namespace Jal.Settings.Interface
{
    public interface ISectionExtractor
    {
        T GetSection<T>(string name) where T: class;
    }
}